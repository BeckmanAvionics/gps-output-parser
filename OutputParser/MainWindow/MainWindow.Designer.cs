namespace OutputParser
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.SplitContainer();
            this.lst = new System.Windows.Forms.ListBox();
            this.pnl2 = new System.Windows.Forms.SplitContainer();
            this.lnkPosition = new System.Windows.Forms.LinkLabel();
            this.chkExcludeHeader = new System.Windows.Forms.CheckBox();
            this.chkExcludeOK = new System.Windows.Forms.CheckBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsReady2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsRose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsJade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSplit = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSteel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).BeginInit();
            this.pnl.Panel1.SuspendLayout();
            this.pnl.Panel2.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl2)).BeginInit();
            this.pnl2.Panel1.SuspendLayout();
            this.pnl2.Panel2.SuspendLayout();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(662, 44);
            this.label1.TabIndex = 1;
            this.label1.Tag = "heading";
            this.label1.Text = "Log Output Parser";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl
            // 
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 76);
            this.pnl.Margin = new System.Windows.Forms.Padding(2);
            this.pnl.Name = "pnl";
            // 
            // pnl.Panel1
            // 
            this.pnl.Panel1.Controls.Add(this.lst);
            // 
            // pnl.Panel2
            // 
            this.pnl.Panel2.Controls.Add(this.pnl2);
            this.pnl.Size = new System.Drawing.Size(662, 385);
            this.pnl.SplitterDistance = 150;
            this.pnl.SplitterWidth = 2;
            this.pnl.TabIndex = 1;
            // 
            // lst
            // 
            this.lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(0, 0);
            this.lst.Margin = new System.Windows.Forms.Padding(2);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(150, 385);
            this.lst.TabIndex = 0;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // pnl2
            // 
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(0, 0);
            this.pnl2.Margin = new System.Windows.Forms.Padding(2);
            this.pnl2.Name = "pnl2";
            this.pnl2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // pnl2.Panel1
            // 
            this.pnl2.Panel1.Controls.Add(this.lnkPosition);
            this.pnl2.Panel1.Controls.Add(this.chkExcludeHeader);
            this.pnl2.Panel1.Controls.Add(this.chkExcludeOK);
            this.pnl2.Panel1.Controls.Add(this.lblPort);
            this.pnl2.Panel1.Controls.Add(this.lblMessage);
            // 
            // pnl2.Panel2
            // 
            this.pnl2.Panel2.Controls.Add(this.dgv);
            this.pnl2.Size = new System.Drawing.Size(510, 385);
            this.pnl2.SplitterDistance = 69;
            this.pnl2.SplitterWidth = 2;
            this.pnl2.TabIndex = 0;
            // 
            // lnkPosition
            // 
            this.lnkPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPosition.Location = new System.Drawing.Point(201, 13);
            this.lnkPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkPosition.Name = "lnkPosition";
            this.lnkPosition.Size = new System.Drawing.Size(85, 16);
            this.lnkPosition.TabIndex = 1;
            this.lnkPosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkPosition.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPosition_LinkClicked);
            // 
            // chkExcludeHeader
            // 
            this.chkExcludeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExcludeHeader.AutoSize = true;
            this.chkExcludeHeader.Location = new System.Drawing.Point(299, 12);
            this.chkExcludeHeader.Margin = new System.Windows.Forms.Padding(2);
            this.chkExcludeHeader.Name = "chkExcludeHeader";
            this.chkExcludeHeader.Size = new System.Drawing.Size(102, 17);
            this.chkExcludeHeader.TabIndex = 6;
            this.chkExcludeHeader.Text = "Exclude Header";
            this.chkExcludeHeader.UseVisualStyleBackColor = true;
            this.chkExcludeHeader.Visible = false;
            this.chkExcludeHeader.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkExcludeOK
            // 
            this.chkExcludeOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExcludeOK.AutoSize = true;
            this.chkExcludeOK.Location = new System.Drawing.Point(417, 12);
            this.chkExcludeOK.Margin = new System.Windows.Forms.Padding(2);
            this.chkExcludeOK.Name = "chkExcludeOK";
            this.chkExcludeOK.Size = new System.Drawing.Size(82, 17);
            this.chkExcludeOK.TabIndex = 5;
            this.chkExcludeOK.Text = "Exclude OK";
            this.chkExcludeOK.UseVisualStyleBackColor = true;
            this.chkExcludeOK.Visible = false;
            this.chkExcludeOK.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoEllipsis = true;
            this.lblPort.Location = new System.Drawing.Point(5, 41);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(494, 20);
            this.lblPort.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblMessage.Size = new System.Drawing.Size(510, 32);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Tag = "skip";
            this.lblMessage.Text = "No output selected.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 82;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(510, 314);
            this.dgv.TabIndex = 0;
            this.dgv.Tag = "rows";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 32);
            this.panel1.TabIndex = 1;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(260, 6);
            this.btnFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(56, 20);
            this.btnFile.TabIndex = 2;
            this.btnFile.Tag = "blue";
            this.btnFile.Text = "Browse...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log File";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(66, 6);
            this.txtFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(193, 20);
            this.txtFile.TabIndex = 0;
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "gps";
            this.ofd.Filter = "GPS Files (*.gps)|*.gps|Log Files (*.log)|*.log|All Files (*.*)|*.*\"";
            this.ofd.RestoreDirectory = true;
            this.ofd.Title = "Log File";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel6,
            this.tsSplit,
            this.tsReady2,
            this.toolStripStatusLabel5,
            this.tsColor,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(662, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // tsReady2
            // 
            this.tsReady2.Name = "tsReady2";
            this.tsReady2.Size = new System.Drawing.Size(42, 17);
            this.tsReady2.Text = "Ready.";
            this.tsReady2.Visible = false;
            // 
            // tsColor
            // 
            this.tsColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSteel,
            this.tsJade,
            this.tsRose});
            this.tsColor.Image = ((System.Drawing.Image)(resources.GetObject("tsColor.Image")));
            this.tsColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsColor.Name = "tsColor";
            this.tsColor.Size = new System.Drawing.Size(148, 20);
            this.tsColor.Text = "Theme: Steel (Change...)";
            // 
            // tsRose
            // 
            this.tsRose.Name = "tsRose";
            this.tsRose.Size = new System.Drawing.Size(180, 22);
            this.tsRose.Text = "Rose";
            this.tsRose.Click += new System.EventHandler(this.tsRose_Click);
            // 
            // tsJade
            // 
            this.tsJade.Name = "tsJade";
            this.tsJade.Size = new System.Drawing.Size(180, 22);
            this.tsJade.Text = "Jade";
            this.tsJade.Click += new System.EventHandler(this.tsJade_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "Ishan Pranav";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel3.Text = "2020";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // tsSplit
            // 
            this.tsSplit.Name = "tsSplit";
            this.tsSplit.Size = new System.Drawing.Size(10, 17);
            this.tsSplit.Text = "|";
            this.tsSplit.Visible = false;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel6.Text = "Ready.";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // tsSteel
            // 
            this.tsSteel.Name = "tsSteel";
            this.tsSteel.Size = new System.Drawing.Size(180, 22);
            this.tsSteel.Text = "Steel";
            this.tsSteel.Click += new System.EventHandler(this.tsSteel_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 483);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(448, 275);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Log Output Parser";
            this.pnl.Panel1.ResumeLayout(false);
            this.pnl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl2.Panel1.ResumeLayout(false);
            this.pnl2.Panel1.PerformLayout();
            this.pnl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl2)).EndInit();
            this.pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer pnl;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SplitContainer pnl2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.CheckBox chkExcludeOK;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox chkExcludeHeader;
        private System.Windows.Forms.ToolStripStatusLabel tsReady2;
        private System.Windows.Forms.LinkLabel lnkPosition;
        private System.Windows.Forms.ToolStripDropDownButton tsColor;
        private System.Windows.Forms.ToolStripMenuItem tsJade;
        private System.Windows.Forms.ToolStripMenuItem tsRose;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tsSplit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripMenuItem tsSteel;
    }
}

