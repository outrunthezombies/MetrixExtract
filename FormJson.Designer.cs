namespace MetrixExtract
{
    partial class FormJson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJson));
            this.TxtIssues = new System.Windows.Forms.TextBox();
            this.TxtWorkRates = new System.Windows.Forms.TextBox();
            this.BtnParseFromTextBox = new System.Windows.Forms.Button();
            this.TxtJson = new System.Windows.Forms.TextBox();
            this.TxtColumns = new System.Windows.Forms.TextBox();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.BtnLoadAndParseJSON = new System.Windows.Forms.Button();
            this.TxtJSONPath = new System.Windows.Forms.TextBox();
            this.LblJSONPath = new System.Windows.Forms.Label();
            this.BtnParseFromCoded = new System.Windows.Forms.Button();
            this.BtnGetBoards = new System.Windows.Forms.Button();
            this.CboBoards = new System.Windows.Forms.ComboBox();
            this.TxtBoards = new System.Windows.Forms.TextBox();
            this.LblCycleTimes = new System.Windows.Forms.Label();
            this.LblJSON = new System.Windows.Forms.Label();
            this.LblIssues = new System.Windows.Forms.Label();
            this.LblWorkRates = new System.Windows.Forms.Label();
            this.LblBoardsJSON = new System.Windows.Forms.Label();
            this.LblColumns = new System.Windows.Forms.Label();
            this.CboFilters = new System.Windows.Forms.ComboBox();
            this.BtnFilters = new System.Windows.Forms.Button();
            this.TxtFilters = new System.Windows.Forms.TextBox();
            this.LblFilterJSON = new System.Windows.Forms.Label();
            this.LblBoardData = new System.Windows.Forms.Label();
            this.TxtBoardData = new System.Windows.Forms.TextBox();
            this.LblFilterData = new System.Windows.Forms.Label();
            this.TxtFilterData = new System.Windows.Forms.TextBox();
            this.MnuView = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CboProjects = new System.Windows.Forms.ComboBox();
            this.BtnProjects = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnFile = new System.Windows.Forms.Button();
            this.MnuView.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtIssues
            // 
            this.TxtIssues.Location = new System.Drawing.Point(11, 202);
            this.TxtIssues.Multiline = true;
            this.TxtIssues.Name = "TxtIssues";
            this.TxtIssues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtIssues.Size = new System.Drawing.Size(418, 92);
            this.TxtIssues.TabIndex = 7;
            // 
            // TxtWorkRates
            // 
            this.TxtWorkRates.Location = new System.Drawing.Point(11, 587);
            this.TxtWorkRates.Multiline = true;
            this.TxtWorkRates.Name = "TxtWorkRates";
            this.TxtWorkRates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtWorkRates.Size = new System.Drawing.Size(418, 73);
            this.TxtWorkRates.TabIndex = 6;
            // 
            // BtnParseFromTextBox
            // 
            this.BtnParseFromTextBox.Location = new System.Drawing.Point(198, 56);
            this.BtnParseFromTextBox.Name = "BtnParseFromTextBox";
            this.BtnParseFromTextBox.Size = new System.Drawing.Size(93, 23);
            this.BtnParseFromTextBox.TabIndex = 5;
            this.BtnParseFromTextBox.Text = "Parse from Txt";
            this.BtnParseFromTextBox.UseVisualStyleBackColor = true;
            this.BtnParseFromTextBox.Click += new System.EventHandler(this.BtnParseFromTextBox_Click);
            // 
            // TxtJson
            // 
            this.TxtJson.Location = new System.Drawing.Point(11, 107);
            this.TxtJson.Multiline = true;
            this.TxtJson.Name = "TxtJson";
            this.TxtJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtJson.Size = new System.Drawing.Size(417, 76);
            this.TxtJson.TabIndex = 4;
            this.TxtJson.Text = resources.GetString("TxtJson.Text");
            // 
            // TxtColumns
            // 
            this.TxtColumns.Location = new System.Drawing.Point(11, 487);
            this.TxtColumns.Multiline = true;
            this.TxtColumns.Name = "TxtColumns";
            this.TxtColumns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtColumns.Size = new System.Drawing.Size(418, 77);
            this.TxtColumns.TabIndex = 8;
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(11, 314);
            this.TxtAverage.Multiline = true;
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAverage.Size = new System.Drawing.Size(418, 154);
            this.TxtAverage.TabIndex = 10;
            // 
            // BtnLoadAndParseJSON
            // 
            this.BtnLoadAndParseJSON.Location = new System.Drawing.Point(12, 56);
            this.BtnLoadAndParseJSON.Name = "BtnLoadAndParseJSON";
            this.BtnLoadAndParseJSON.Size = new System.Drawing.Size(165, 23);
            this.BtnLoadAndParseJSON.TabIndex = 11;
            this.BtnLoadAndParseJSON.Text = "Load and Parse JSON from .txt";
            this.BtnLoadAndParseJSON.UseVisualStyleBackColor = true;
            this.BtnLoadAndParseJSON.Click += new System.EventHandler(this.BtnLoadJSON_Click);
            // 
            // TxtJSONPath
            // 
            this.TxtJSONPath.Location = new System.Drawing.Point(65, 30);
            this.TxtJSONPath.Name = "TxtJSONPath";
            this.TxtJSONPath.ReadOnly = true;
            this.TxtJSONPath.Size = new System.Drawing.Size(298, 20);
            this.TxtJSONPath.TabIndex = 12;
            this.TxtJSONPath.Text = "C:\\Users\\Greg\\Desktop\\Delete\\ONJSON.txt";
            // 
            // LblJSONPath
            // 
            this.LblJSONPath.AutoSize = true;
            this.LblJSONPath.Location = new System.Drawing.Point(8, 33);
            this.LblJSONPath.Name = "LblJSONPath";
            this.LblJSONPath.Size = new System.Drawing.Size(51, 13);
            this.LblJSONPath.TabIndex = 13;
            this.LblJSONPath.Text = "File Path:";
            // 
            // BtnParseFromCoded
            // 
            this.BtnParseFromCoded.Location = new System.Drawing.Point(304, 56);
            this.BtnParseFromCoded.Name = "BtnParseFromCoded";
            this.BtnParseFromCoded.Size = new System.Drawing.Size(125, 23);
            this.BtnParseFromCoded.TabIndex = 14;
            this.BtnParseFromCoded.Text = "Parse from Hard Coded";
            this.BtnParseFromCoded.UseVisualStyleBackColor = true;
            this.BtnParseFromCoded.Click += new System.EventHandler(this.BtnParseFromCoded_Click);
            // 
            // BtnGetBoards
            // 
            this.BtnGetBoards.Location = new System.Drawing.Point(435, 30);
            this.BtnGetBoards.Name = "BtnGetBoards";
            this.BtnGetBoards.Size = new System.Drawing.Size(74, 23);
            this.BtnGetBoards.TabIndex = 15;
            this.BtnGetBoards.Text = "Get Boards";
            this.BtnGetBoards.UseVisualStyleBackColor = true;
            this.BtnGetBoards.Click += new System.EventHandler(this.BtnGetBoards_Click);
            // 
            // CboBoards
            // 
            this.CboBoards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBoards.FormattingEnabled = true;
            this.CboBoards.Location = new System.Drawing.Point(515, 32);
            this.CboBoards.MaxDropDownItems = 50;
            this.CboBoards.Name = "CboBoards";
            this.CboBoards.Size = new System.Drawing.Size(124, 21);
            this.CboBoards.TabIndex = 16;
            // 
            // TxtBoards
            // 
            this.TxtBoards.Location = new System.Drawing.Point(435, 74);
            this.TxtBoards.Multiline = true;
            this.TxtBoards.Name = "TxtBoards";
            this.TxtBoards.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoards.Size = new System.Drawing.Size(419, 85);
            this.TxtBoards.TabIndex = 17;
            this.TxtBoards.Text = resources.GetString("TxtBoards.Text");
            // 
            // LblCycleTimes
            // 
            this.LblCycleTimes.AutoSize = true;
            this.LblCycleTimes.Location = new System.Drawing.Point(8, 298);
            this.LblCycleTimes.Name = "LblCycleTimes";
            this.LblCycleTimes.Size = new System.Drawing.Size(67, 13);
            this.LblCycleTimes.TabIndex = 18;
            this.LblCycleTimes.Text = "Cycle Times:";
            // 
            // LblJSON
            // 
            this.LblJSON.AutoSize = true;
            this.LblJSON.Location = new System.Drawing.Point(8, 86);
            this.LblJSON.Name = "LblJSON";
            this.LblJSON.Size = new System.Drawing.Size(83, 13);
            this.LblJSON.TabIndex = 19;
            this.LblJSON.Text = "JSON of Issues:";
            // 
            // LblIssues
            // 
            this.LblIssues.AutoSize = true;
            this.LblIssues.Location = new System.Drawing.Point(5, 186);
            this.LblIssues.Name = "LblIssues";
            this.LblIssues.Size = new System.Drawing.Size(94, 13);
            this.LblIssues.TabIndex = 20;
            this.LblIssues.Text = "Issues from JSON:";
            // 
            // LblWorkRates
            // 
            this.LblWorkRates.AutoSize = true;
            this.LblWorkRates.Location = new System.Drawing.Point(8, 571);
            this.LblWorkRates.Name = "LblWorkRates";
            this.LblWorkRates.Size = new System.Drawing.Size(67, 13);
            this.LblWorkRates.TabIndex = 21;
            this.LblWorkRates.Text = "Work Rates:";
            // 
            // LblBoardsJSON
            // 
            this.LblBoardsJSON.AutoSize = true;
            this.LblBoardsJSON.Location = new System.Drawing.Point(432, 58);
            this.LblBoardsJSON.Name = "LblBoardsJSON";
            this.LblBoardsJSON.Size = new System.Drawing.Size(86, 13);
            this.LblBoardsJSON.TabIndex = 22;
            this.LblBoardsJSON.Text = "JSON of Boards:";
            // 
            // LblColumns
            // 
            this.LblColumns.AutoSize = true;
            this.LblColumns.Location = new System.Drawing.Point(8, 471);
            this.LblColumns.Name = "LblColumns";
            this.LblColumns.Size = new System.Drawing.Size(50, 13);
            this.LblColumns.TabIndex = 23;
            this.LblColumns.Text = "Columns:";
            // 
            // CboFilters
            // 
            this.CboFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboFilters.FormattingEnabled = true;
            this.CboFilters.Location = new System.Drawing.Point(519, 354);
            this.CboFilters.MaxDropDownItems = 50;
            this.CboFilters.Name = "CboFilters";
            this.CboFilters.Size = new System.Drawing.Size(214, 21);
            this.CboFilters.TabIndex = 25;
            // 
            // BtnFilters
            // 
            this.BtnFilters.Location = new System.Drawing.Point(439, 352);
            this.BtnFilters.Name = "BtnFilters";
            this.BtnFilters.Size = new System.Drawing.Size(74, 23);
            this.BtnFilters.TabIndex = 24;
            this.BtnFilters.Text = "Get Filters";
            this.BtnFilters.UseVisualStyleBackColor = true;
            this.BtnFilters.Click += new System.EventHandler(this.BtnFilters_Click);
            // 
            // TxtFilters
            // 
            this.TxtFilters.Location = new System.Drawing.Point(439, 394);
            this.TxtFilters.Multiline = true;
            this.TxtFilters.Name = "TxtFilters";
            this.TxtFilters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtFilters.Size = new System.Drawing.Size(415, 59);
            this.TxtFilters.TabIndex = 26;
            this.TxtFilters.Text = resources.GetString("TxtFilters.Text");
            // 
            // LblFilterJSON
            // 
            this.LblFilterJSON.AutoSize = true;
            this.LblFilterJSON.Location = new System.Drawing.Point(439, 378);
            this.LblFilterJSON.Name = "LblFilterJSON";
            this.LblFilterJSON.Size = new System.Drawing.Size(63, 13);
            this.LblFilterJSON.TabIndex = 27;
            this.LblFilterJSON.Text = "Filter JSON:";
            // 
            // LblBoardData
            // 
            this.LblBoardData.AutoSize = true;
            this.LblBoardData.Location = new System.Drawing.Point(435, 162);
            this.LblBoardData.Name = "LblBoardData";
            this.LblBoardData.Size = new System.Drawing.Size(64, 13);
            this.LblBoardData.TabIndex = 29;
            this.LblBoardData.Text = "Board Data:";
            // 
            // TxtBoardData
            // 
            this.TxtBoardData.Location = new System.Drawing.Point(438, 178);
            this.TxtBoardData.Multiline = true;
            this.TxtBoardData.Name = "TxtBoardData";
            this.TxtBoardData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoardData.Size = new System.Drawing.Size(416, 168);
            this.TxtBoardData.TabIndex = 28;
            // 
            // LblFilterData
            // 
            this.LblFilterData.AutoSize = true;
            this.LblFilterData.Location = new System.Drawing.Point(435, 456);
            this.LblFilterData.Name = "LblFilterData";
            this.LblFilterData.Size = new System.Drawing.Size(58, 13);
            this.LblFilterData.TabIndex = 31;
            this.LblFilterData.Text = "Filter Data:";
            // 
            // TxtFilterData
            // 
            this.TxtFilterData.Location = new System.Drawing.Point(438, 472);
            this.TxtFilterData.Multiline = true;
            this.TxtFilterData.Name = "TxtFilterData";
            this.TxtFilterData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtFilterData.Size = new System.Drawing.Size(416, 188);
            this.TxtFilterData.TabIndex = 30;
            // 
            // MnuView
            // 
            this.MnuView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.MnuView.Location = new System.Drawing.Point(0, 0);
            this.MnuView.Name = "MnuView";
            this.MnuView.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MnuView.Size = new System.Drawing.Size(866, 24);
            this.MnuView.TabIndex = 32;
            this.MnuView.Text = "Menu";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualEntryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // manualEntryToolStripMenuItem
            // 
            this.manualEntryToolStripMenuItem.Name = "manualEntryToolStripMenuItem";
            this.manualEntryToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.manualEntryToolStripMenuItem.Text = "Manual Entry";
            this.manualEntryToolStripMenuItem.Click += new System.EventHandler(this.ManualEntryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // CboProjects
            // 
            this.CboProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProjects.FormattingEnabled = true;
            this.CboProjects.Location = new System.Drawing.Point(725, 32);
            this.CboProjects.MaxDropDownItems = 50;
            this.CboProjects.Name = "CboProjects";
            this.CboProjects.Size = new System.Drawing.Size(129, 21);
            this.CboProjects.TabIndex = 34;
            // 
            // BtnProjects
            // 
            this.BtnProjects.Location = new System.Drawing.Point(645, 30);
            this.BtnProjects.Name = "BtnProjects";
            this.BtnProjects.Size = new System.Drawing.Size(74, 23);
            this.BtnProjects.TabIndex = 33;
            this.BtnProjects.Text = "Get Projects";
            this.BtnProjects.UseVisualStyleBackColor = true;
            this.BtnProjects.Click += new System.EventHandler(this.BtnProjects_Click);
            // 
            // BtnFile
            // 
            this.BtnFile.Location = new System.Drawing.Point(369, 30);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(59, 20);
            this.BtnFile.TabIndex = 35;
            this.BtnFile.Text = "File";
            this.BtnFile.UseVisualStyleBackColor = true;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // FormJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 670);
            this.Controls.Add(this.BtnFile);
            this.Controls.Add(this.CboProjects);
            this.Controls.Add(this.BtnProjects);
            this.Controls.Add(this.LblFilterData);
            this.Controls.Add(this.TxtFilterData);
            this.Controls.Add(this.LblBoardData);
            this.Controls.Add(this.TxtBoardData);
            this.Controls.Add(this.LblFilterJSON);
            this.Controls.Add(this.TxtFilters);
            this.Controls.Add(this.CboFilters);
            this.Controls.Add(this.BtnFilters);
            this.Controls.Add(this.LblColumns);
            this.Controls.Add(this.LblBoardsJSON);
            this.Controls.Add(this.LblWorkRates);
            this.Controls.Add(this.LblIssues);
            this.Controls.Add(this.LblJSON);
            this.Controls.Add(this.LblCycleTimes);
            this.Controls.Add(this.TxtBoards);
            this.Controls.Add(this.CboBoards);
            this.Controls.Add(this.BtnGetBoards);
            this.Controls.Add(this.BtnParseFromCoded);
            this.Controls.Add(this.LblJSONPath);
            this.Controls.Add(this.TxtJSONPath);
            this.Controls.Add(this.BtnLoadAndParseJSON);
            this.Controls.Add(this.TxtAverage);
            this.Controls.Add(this.TxtColumns);
            this.Controls.Add(this.TxtIssues);
            this.Controls.Add(this.TxtWorkRates);
            this.Controls.Add(this.BtnParseFromTextBox);
            this.Controls.Add(this.TxtJson);
            this.Controls.Add(this.MnuView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuView;
            this.Name = "FormJson";
            this.Text = "Json Test";
            this.MnuView.ResumeLayout(false);
            this.MnuView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtIssues;
        internal System.Windows.Forms.TextBox TxtWorkRates;
        internal System.Windows.Forms.Button BtnParseFromTextBox;
        internal System.Windows.Forms.TextBox TxtJson;
        internal System.Windows.Forms.TextBox TxtColumns;
        internal System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.Button BtnLoadAndParseJSON;
        private System.Windows.Forms.TextBox TxtJSONPath;
        private System.Windows.Forms.Label LblJSONPath;
        internal System.Windows.Forms.Button BtnParseFromCoded;
        private System.Windows.Forms.Button BtnGetBoards;
        private System.Windows.Forms.ComboBox CboBoards;
        internal System.Windows.Forms.TextBox TxtBoards;
        private System.Windows.Forms.Label LblCycleTimes;
        private System.Windows.Forms.Label LblJSON;
        private System.Windows.Forms.Label LblIssues;
        private System.Windows.Forms.Label LblWorkRates;
        private System.Windows.Forms.Label LblBoardsJSON;
        private System.Windows.Forms.Label LblColumns;
        private System.Windows.Forms.ComboBox CboFilters;
        private System.Windows.Forms.Button BtnFilters;
        internal System.Windows.Forms.TextBox TxtFilters;
        private System.Windows.Forms.Label LblFilterJSON;
        private System.Windows.Forms.Label LblBoardData;
        internal System.Windows.Forms.TextBox TxtBoardData;
        private System.Windows.Forms.Label LblFilterData;
        internal System.Windows.Forms.TextBox TxtFilterData;
        private System.Windows.Forms.MenuStrip MnuView;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox CboProjects;
        private System.Windows.Forms.Button BtnProjects;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button BtnFile;
    }
}