using IshanTools;
using OutputParser.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OutputParser
{
    public partial class MainWindow : Form
    {
        public string FileName { get; set; }
        public IList<Log> Logs { get; set; } = new List<Log>();

        private int _selectedLog = 0;

        public MainWindow()
        {
            this.InitializeComponent();

            this.ApplyStyles();
        }

        private void ApplyStyles()
        {
            IshanStylers.RunStylers(this, Settings.Default.Theme);

            lst.BorderStyle = BorderStyle.None;
            dgv.BorderStyle = BorderStyle.None;

            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl2.BorderStyle = BorderStyle.FixedSingle;

            pnl2.Panel1.BackColor = IshanStylers.IshanLightestBlue;
            lblMessage.BackColor = IshanStylers.IshanLightestBlue;
            lblPort.BackColor = IshanStylers.IshanLightestBlue;
            chkExcludeOK.BackColor = IshanStylers.IshanLightestBlue;
            chkExcludeHeader.BackColor = IshanStylers.IshanLightestBlue;
            lnkPosition.BackColor = IshanStylers.IshanLightestBlue;
        }

        private void SearchFile()
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    this.FileName = ofd.FileName;

                    txtFile.Text = this.FileName;
                }
            }

            txtFile.SelectionStart = txtFile.Text.Length;
            txtFile.SelectionLength = 0;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            this.SearchFile();
            this.LoadFile();

            try
            {
                lst.SelectedIndex = 0;
            }
            catch { }
        }

        private void LoadFile()
        {
            if (File.Exists(this.FileName))
            {
                string[] data;

                try
                {
                    data = File.ReadAllLines(this.FileName);

                    this.ParseData(data);
                }
                catch { }
            }
            else
            {
                this.SearchFile();
            }
        }

        private void ParseData(string[] data)
        {
            this.Logs.Clear();

            lst.Items.Clear();
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            string[] fields;
            string command = string.Empty;

            try
            {
                int j = 0;

                foreach (string line in data)
                {
                    if (string.IsNullOrWhiteSpace(line.Trim()))
                    {
                        continue;
                    }

                    if (!line.StartsWith("#") || !line.Contains(",") || !line.Contains(";"))
                    {
                        continue;
                    }

                    if (line.Trim().Split(',').Length > 7)
                    {
                        fields = line.Trim().Split(',');

                        command = fields[0].ToUpper().Replace("#", "").Trim('A');

                        Logs.Add(new Log((j + 1) + ": " + command, command)
                        {
                            Port = fields[1],
                            IdleTime = fields[3],
                            TimeStatus = fields[4],
                            ReferenceWeek = Convert.ToInt32(fields[5]),
                            ReferenceSeconds = Convert.ToDouble(fields[6]),
                            HexReceiverStatus = fields[7],
                            DataRows = line.Split(';')[1].Split(',')
                        });

                        j++;
                    }
                }
            }
            catch
            {
                Logs.Clear();
                lst.Items.Clear();

                return;
            }

            lst.Items.AddRange(Logs.Select(x => x.Name).ToArray());
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedIndex >= 0 && this.Logs.Count >= lst.SelectedIndex && (lst.SelectedIndex != _selectedLog || _selectedLog == 0))
            {
                _selectedLog = lst.SelectedIndex;

                if (dgv.Columns.Count == 0)
                {
                    dgv.Columns.Add("ColProperty", "Property");
                    dgv.Columns.Add("ColValue", "Value");

                    chkExcludeOK.Visible = true;
                    chkExcludeHeader.Visible = true;
                }

                this.DisplayData(this.Logs[lst.SelectedIndex]);
            }
        }

        private void DisplayData(Log log)
        {
            lblMessage.Text = log.Name;

            dgv.Rows.Clear();

            foreach (KeyValuePair<string, string> pair in log.GetAvailable(chkExcludeOK.Checked, chkExcludeHeader.Checked))
            {
                dgv.Rows.Add(pair.Key, pair.Value);
            }

            lblPort.Text = "Port: " + log.Port + "     Time Status: " + log.TimeStatusMessage + "     Estimated Time: " + log.Time.ToString("MMMM d, yyyy h:mm:ss tt");
            tsReady2.Text = log.Command;
            tsReady2.Text = dgv.Rows.Count + " records available.";
            tsReady2.Visible = true;
            tsSplit.Visible = true;

            if (log.Command == "BESTPOS")
            {
                lnkPosition.Text = "View Position";
            }
            else
            {
                lnkPosition.Text = string.Empty;
            }
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            this.DisplayData(this.Logs[lst.SelectedIndex]);
        }

        private void lnkPosition_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (this.Logs[lst.SelectedIndex].Command)
            {
                case "BESTPOS":
                    try
                    {
                        Process.Start("https://www.google.com/maps/search/?api=1&query=" + this.Logs[lst.SelectedIndex].Latitude + "," + this.Logs[lst.SelectedIndex].Longitude);
                    }
                    catch { }
                    break;
            }
        }

        private void tsJade_Click(object sender, EventArgs e)
        {
            Settings.Default.Theme = StyleTheme.Jade;
            Settings.Default.Save();

            tsColor.Text = "Theme: Jade (Change...)";

            this.ApplyStyles();
        }

        private void tsSteel_Click(object sender, EventArgs e)
        {
            Settings.Default.Theme = StyleTheme.Steel;
            Settings.Default.Save();

            tsColor.Text = "Theme: Steel (Change...)";

            this.ApplyStyles();
        }

        private void tsRose_Click(object sender, EventArgs e)
        {
            Settings.Default.Theme = StyleTheme.Rose;
            Settings.Default.Save();

            tsColor.Text = "Theme: Rose (Change...)";

            this.ApplyStyles();
        }
    }
}
