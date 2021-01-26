using OutputParser.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace OutputParser
{
    public class Log
    {
        public string Command { get; }
        public string Name { get; }

        public string Port { get; set; }
        public string IdleTime { get; set; }
        public string TimeStatus { get; set; }
        public string TimeStatusMessage { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public int ReferenceWeek { get; set; }
        public double ReferenceSeconds { get; set; }

        public string HexReceiverStatus { get; set; }

        public IList<string> DataRows { get; set; }

        public DateTime Time
        {
            get
            {
                return CultureInfo.InvariantCulture.Calendar
                    .AddWeeks(new DateTime(1980, 1, 6, 0, 0, 0), this.ReferenceWeek)
                    .AddSeconds(this.ReferenceSeconds);
            }
        }

        public Log(string logName, string logCommand)
        {
            this.Name = logName;
            this.Command = logCommand.ToUpper();
        }

        public IDictionary<string, string> GetAvailable(bool excludeOK, bool excludeHeader)
        {
            IDictionary<string, string> d = new Dictionary<string, string>
            {
                { "Port", this.Port }
            };

            d = CombineTrimDictionary(d, ConvertEnumToFlags("GPS Time Status", this.TimeStatus, Resources.HDR_TIME));

            d.Add("GPS Time (Estimated)", this.Time.ToString("MMMM d, yyyy h:mm:ss tt"));
            d.Add("Reference Week", this.ReferenceWeek.ToString());
            d.Add("Reference Seconds", this.ReferenceSeconds.ToString());
            d.Add("CPU Idle Time", this.IdleTime + "%");

            if (!excludeHeader)
            {
                d = CombineTrimDictionary(d, ConvertHexadecimalToFlags(this.HexReceiverStatus, Resources.HDR_STAT, excludeOK));
            }

            this.TimeStatusMessage = d["GPS Time Status"];

            switch (this.Command)
            {
                case "RXSTATUS":
                    if (this.DataRows.Count > 0)
                    {
                        d = CombineTrimDictionary(d, ConvertHexadecimalToFlags(this.DataRows[0], Resources.RXSTATU0, excludeOK));
                    }

                    if (this.DataRows.Count > 6)
                    {
                        d = CombineTrimDictionary(d, ConvertHexadecimalToFlags(this.DataRows[6], Resources.RXSTATU1, excludeOK));
                    }

                    if (this.DataRows.Count > 10)
                    {
                        d = CombineTrimDictionary(d, ConvertHexadecimalToFlags(this.DataRows[10], Resources.RXSTATU2, excludeOK));
                    }

                    if (this.DataRows.Count > 14)
                    {
                        d = CombineTrimDictionary(d, ConvertHexadecimalToFlags(this.DataRows[14], Resources.RXSTATU3, excludeOK));
                    }
                    break;

                case "BESTPOS":
                    d = CombineTrimDictionary(d, ConvertCsvToFlags(this.DataRows, Resources.BESTPOS0));

                    try
                    {
                        this.Latitude = d["Latitude (Degrees)"];
                        this.Longitude = d["Longitude (Degrees)"];
                    }
                    catch { }

                    if (this.DataRows.Count > 0)
                    {
                        d = CombineTrimDictionary(d, ConvertEnumToFlags("Solution Status", this.DataRows[0], Resources.BESTPOS1));
                    }

                    if (this.DataRows.Count > 1)
                    {
                        d = CombineTrimDictionary(d, ConvertEnumToFlags("Position Type", this.DataRows[1], Resources.BESTPOS2));
                    }
                    break;

                case "TIME":
                    d = CombineTrimDictionary(d, ConvertCsvToFlags(this.DataRows, Resources.TIME0));

                    if (this.DataRows.Count > 3)
                    {
                        d.Add("GPS Time (Exact): ", this.Time.AddSeconds(Convert.ToDouble(this.DataRows[1])).AddSeconds(Convert.ToDouble(this.DataRows[3])).ToString("MMMM d, yyyy h:mm:ss tt"));
                    }

                    if (this.DataRows.Count > 0)
                    {
                        d = CombineTrimDictionary(d, ConvertEnumToFlags("Clock Status", this.DataRows[0], Resources.TIME1));
                    }

                    if (this.DataRows.Count > 10)
                    {
                        d = CombineTrimDictionary(d, ConvertEnumToFlags("UTC Status", this.DataRows[10], Resources.TIME2));
                    }
                    break;
            }

            return d;
        }

        private static IDictionary<string, string> CombineTrimDictionary(IDictionary<string, string> a, IDictionary<string, string> b)
        {
            Dictionary<string, string> c = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> pair in a)
            {
                c.Add(pair.Key.Trim(), pair.Value.Trim());
            }

            foreach (KeyValuePair<string, string> pair in b)
            {
                c.Add(pair.Key.Trim(), pair.Value.Trim());
            }

            return c;
        }

        private static Dictionary<string, string> ConvertHexadecimalToFlags(string hexadecimal, string flagTable, bool excludeOK)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            char[] bin = ConvertHexadecimalToBinary(hexadecimal)
                .Reverse()
                .ToArray();

            string[] fields;

            try
            {
                foreach (string line in flagTable.Split('\n'))
                {
                    if (!line.StartsWith("#"))
                    {
                        fields = line.Split(',');

                        if (fields.Length > 3)
                        {
                            if (bin[Convert.ToInt32(fields[0])] == '1')
                            {
                                d.Add(fields[1], fields[3]);
                            }
                            else if (bin[Convert.ToInt32(fields[0])] == '0' && !excludeOK)
                            {
                                d.Add(fields[1], fields[2]);
                            }
                        }
                    }
                }
            }
            catch { }

            return d;
        }

        private static Dictionary<string, string> ConvertCsvToFlags(IList<string> csv, string flagTable)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            string[] fields;

            try
            {
                foreach (string line in flagTable.Split('\n'))
                {
                    if (!line.StartsWith("#"))
                    {
                        fields = line.Split(',');

                        if (fields.Length > 1)
                        {
                            if (csv.Count > Convert.ToInt32(fields[0]))
                            {
                                d.Add(fields[1], csv[Convert.ToInt32(fields[0])]);
                            }
                        }
                    }
                }
            }
            catch { }

            return d;
        }

        private static Dictionary<string, string> ConvertEnumToFlags(string property, string value, string flagTable)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            string[] fields;

            try
            {
                foreach (string line in flagTable.Split('\n'))
                {
                    if (!line.StartsWith("#"))
                    {
                        fields = line.Split(',');

                        if (fields.Length > 2)
                        {
                            if (value.ToUpper() == fields[1].ToUpper())
                            {
                                d.Add(property, fields[2]);
                            }
                        }
                    }
                }
            }
            catch { }

            return d;
        }

        private static string ConvertHexadecimalToBinary(string value)
        {
            string a = String
                .Join(string.Empty, value
                    .Select(x => Convert.ToString(Convert.ToInt32(x.ToString(), 16), 2)
                        .PadLeft(4, '0')));

            while (a.Length < 32)
            {
                a = '0' + a;
            }

            return a;
        }
    }
}
