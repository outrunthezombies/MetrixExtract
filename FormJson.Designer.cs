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
            this.SuspendLayout();
            // 
            // TxtIssues
            // 
            this.TxtIssues.Location = new System.Drawing.Point(12, 401);
            this.TxtIssues.Multiline = true;
            this.TxtIssues.Name = "TxtIssues";
            this.TxtIssues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtIssues.Size = new System.Drawing.Size(545, 431);
            this.TxtIssues.TabIndex = 7;
            // 
            // TxtWorkRates
            // 
            this.TxtWorkRates.Location = new System.Drawing.Point(563, 267);
            this.TxtWorkRates.Multiline = true;
            this.TxtWorkRates.Name = "TxtWorkRates";
            this.TxtWorkRates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtWorkRates.Size = new System.Drawing.Size(545, 328);
            this.TxtWorkRates.TabIndex = 6;
            // 
            // BtnParseFromTextBox
            // 
            this.BtnParseFromTextBox.Location = new System.Drawing.Point(196, 41);
            this.BtnParseFromTextBox.Name = "BtnParseFromTextBox";
            this.BtnParseFromTextBox.Size = new System.Drawing.Size(164, 23);
            this.BtnParseFromTextBox.TabIndex = 5;
            this.BtnParseFromTextBox.Text = "Parse from Txt";
            this.BtnParseFromTextBox.UseVisualStyleBackColor = true;
            this.BtnParseFromTextBox.Click += new System.EventHandler(this.BtnParseFromTextBox_Click);
            // 
            // TxtJson
            // 
            this.TxtJson.Location = new System.Drawing.Point(13, 72);
            this.TxtJson.Multiline = true;
            this.TxtJson.Name = "TxtJson";
            this.TxtJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtJson.Size = new System.Drawing.Size(544, 145);
            this.TxtJson.TabIndex = 4;
            this.TxtJson.Text = resources.GetString("TxtJson.Text");
            // 
            // TxtColumns
            // 
            this.TxtColumns.Location = new System.Drawing.Point(563, 601);
            this.TxtColumns.Multiline = true;
            this.TxtColumns.Name = "TxtColumns";
            this.TxtColumns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtColumns.Size = new System.Drawing.Size(545, 231);
            this.TxtColumns.TabIndex = 8;
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(563, 12);
            this.TxtAverage.Multiline = true;
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAverage.Size = new System.Drawing.Size(545, 249);
            this.TxtAverage.TabIndex = 10;
            // 
            // BtnLoadAndParseJSON
            // 
            this.BtnLoadAndParseJSON.Location = new System.Drawing.Point(12, 41);
            this.BtnLoadAndParseJSON.Name = "BtnLoadAndParseJSON";
            this.BtnLoadAndParseJSON.Size = new System.Drawing.Size(183, 23);
            this.BtnLoadAndParseJSON.TabIndex = 11;
            this.BtnLoadAndParseJSON.Text = "Load and Parse JSON";
            this.BtnLoadAndParseJSON.UseVisualStyleBackColor = true;
            this.BtnLoadAndParseJSON.Click += new System.EventHandler(this.BtnLoadJSON_Click);
            // 
            // TxtJSONPath
            // 
            this.TxtJSONPath.Location = new System.Drawing.Point(66, 12);
            this.TxtJSONPath.Name = "TxtJSONPath";
            this.TxtJSONPath.Size = new System.Drawing.Size(351, 20);
            this.TxtJSONPath.TabIndex = 12;
            this.TxtJSONPath.Text = "C:\\Users\\Greg\\Desktop\\Delete\\ONJSON.txt";
            // 
            // LblJSONPath
            // 
            this.LblJSONPath.AutoSize = true;
            this.LblJSONPath.Location = new System.Drawing.Point(9, 15);
            this.LblJSONPath.Name = "LblJSONPath";
            this.LblJSONPath.Size = new System.Drawing.Size(51, 13);
            this.LblJSONPath.TabIndex = 13;
            this.LblJSONPath.Text = "File Path:";
            // 
            // BtnParseFromCoded
            // 
            this.BtnParseFromCoded.Location = new System.Drawing.Point(364, 41);
            this.BtnParseFromCoded.Name = "BtnParseFromCoded";
            this.BtnParseFromCoded.Size = new System.Drawing.Size(193, 23);
            this.BtnParseFromCoded.TabIndex = 14;
            this.BtnParseFromCoded.Text = "Parse from Coded";
            this.BtnParseFromCoded.UseVisualStyleBackColor = true;
            this.BtnParseFromCoded.Click += new System.EventHandler(this.BtnParseFromCoded_Click);
            // 
            // BtnGetBoards
            // 
            this.BtnGetBoards.Location = new System.Drawing.Point(13, 223);
            this.BtnGetBoards.Name = "BtnGetBoards";
            this.BtnGetBoards.Size = new System.Drawing.Size(216, 23);
            this.BtnGetBoards.TabIndex = 15;
            this.BtnGetBoards.Text = "Get Boards";
            this.BtnGetBoards.UseVisualStyleBackColor = true;
            this.BtnGetBoards.Click += new System.EventHandler(this.BtnGetBoards_Click);
            // 
            // CboBoards
            // 
            this.CboBoards.FormattingEnabled = true;
            this.CboBoards.Location = new System.Drawing.Point(235, 223);
            this.CboBoards.MaxDropDownItems = 50;
            this.CboBoards.Name = "CboBoards";
            this.CboBoards.Size = new System.Drawing.Size(322, 21);
            this.CboBoards.TabIndex = 16;
            // 
            // TxtBoards
            // 
            this.TxtBoards.Location = new System.Drawing.Point(13, 252);
            this.TxtBoards.Multiline = true;
            this.TxtBoards.Name = "TxtBoards";
            this.TxtBoards.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoards.Size = new System.Drawing.Size(544, 143);
            this.TxtBoards.TabIndex = 17;
            this.TxtBoards.Text = resources.GetString("TxtBoards.Text");
            // 
            // FormJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 844);
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
            this.Name = "FormJson";
            this.Text = "Json Test";
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
    }
}