namespace MetrixExtract
{
    partial class FormMain
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
            this.BtnCycle = new System.Windows.Forms.Button();
            this.GrpCycleTimes = new System.Windows.Forms.GroupBox();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CycleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CycleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnJsonTest = new System.Windows.Forms.Button();
            this.BtnChartData = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.CboCycleType = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.CboLob = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CboTeam = new System.Windows.Forms.ComboBox();
            this.GrpCycleTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCycle
            // 
            this.BtnCycle.Location = new System.Drawing.Point(287, 12);
            this.BtnCycle.Name = "BtnCycle";
            this.BtnCycle.Size = new System.Drawing.Size(125, 21);
            this.BtnCycle.TabIndex = 12;
            this.BtnCycle.Text = "Show Cycle Times";
            this.BtnCycle.UseVisualStyleBackColor = true;
            this.BtnCycle.Click += new System.EventHandler(this.BtnCycle_Click);
            // 
            // GrpCycleTimes
            // 
            this.GrpCycleTimes.Controls.Add(this.DgvData);
            this.GrpCycleTimes.Location = new System.Drawing.Point(12, 68);
            this.GrpCycleTimes.Name = "GrpCycleTimes";
            this.GrpCycleTimes.Size = new System.Drawing.Size(400, 216);
            this.GrpCycleTimes.TabIndex = 13;
            this.GrpCycleTimes.TabStop = false;
            this.GrpCycleTimes.Text = "Cycle Times";
            this.GrpCycleTimes.Visible = false;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.CycleDate,
            this.CycleTime});
            this.DgvData.Location = new System.Drawing.Point(6, 19);
            this.DgvData.MultiSelect = false;
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Size = new System.Drawing.Size(388, 192);
            this.DgvData.TabIndex = 7;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Visible = false;
            // 
            // CycleDate
            // 
            this.CycleDate.HeaderText = "Date";
            this.CycleDate.Name = "CycleDate";
            this.CycleDate.ReadOnly = true;
            // 
            // CycleTime
            // 
            this.CycleTime.HeaderText = "Cycle Time";
            this.CycleTime.Name = "CycleTime";
            this.CycleTime.ReadOnly = true;
            // 
            // BtnJsonTest
            // 
            this.BtnJsonTest.Location = new System.Drawing.Point(231, 39);
            this.BtnJsonTest.Name = "BtnJsonTest";
            this.BtnJsonTest.Size = new System.Drawing.Size(85, 23);
            this.BtnJsonTest.TabIndex = 21;
            this.BtnJsonTest.Text = "JSON Test";
            this.BtnJsonTest.UseVisualStyleBackColor = true;
            this.BtnJsonTest.Click += new System.EventHandler(this.BtnJsonTest_Click);
            // 
            // BtnChartData
            // 
            this.BtnChartData.Location = new System.Drawing.Point(332, 39);
            this.BtnChartData.Name = "BtnChartData";
            this.BtnChartData.Size = new System.Drawing.Size(80, 23);
            this.BtnChartData.TabIndex = 20;
            this.BtnChartData.Text = "Chart Data";
            this.BtnChartData.UseVisualStyleBackColor = true;
            this.BtnChartData.Click += new System.EventHandler(this.BtnChartData_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(81, 39);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(63, 23);
            this.BtnEdit.TabIndex = 19;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // CboCycleType
            // 
            this.CboCycleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCycleType.FormattingEnabled = true;
            this.CboCycleType.Location = new System.Drawing.Point(12, 12);
            this.CboCycleType.Name = "CboCycleType";
            this.CboCycleType.Size = new System.Drawing.Size(94, 21);
            this.CboCycleType.TabIndex = 17;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(150, 39);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(63, 23);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // CboLob
            // 
            this.CboLob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboLob.FormattingEnabled = true;
            this.CboLob.Location = new System.Drawing.Point(112, 12);
            this.CboLob.Name = "CboLob";
            this.CboLob.Size = new System.Drawing.Size(86, 21);
            this.CboLob.TabIndex = 15;
            this.CboLob.SelectedIndexChanged += new System.EventHandler(this.CboLob_SelectedIndexChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 39);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(63, 23);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CboTeam
            // 
            this.CboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTeam.FormattingEnabled = true;
            this.CboTeam.Location = new System.Drawing.Point(204, 12);
            this.CboTeam.Name = "CboTeam";
            this.CboTeam.Size = new System.Drawing.Size(77, 21);
            this.CboTeam.TabIndex = 14;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 290);
            this.Controls.Add(this.BtnCycle);
            this.Controls.Add(this.GrpCycleTimes);
            this.Controls.Add(this.BtnJsonTest);
            this.Controls.Add(this.BtnChartData);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.CboCycleType);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.CboLob);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CboTeam);
            this.Name = "FormMain";
            this.Text = "Metrix Extract";
            this.GrpCycleTimes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnCycle;
        internal System.Windows.Forms.GroupBox GrpCycleTimes;
        internal System.Windows.Forms.DataGridView DgvData;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Index;
        internal System.Windows.Forms.DataGridViewTextBoxColumn CycleDate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn CycleTime;
        internal System.Windows.Forms.Button BtnJsonTest;
        internal System.Windows.Forms.Button BtnChartData;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.ComboBox CboCycleType;
        internal System.Windows.Forms.Button BtnDelete;
        internal System.Windows.Forms.ComboBox CboLob;
        internal System.Windows.Forms.Button BtnAdd;
        internal System.Windows.Forms.ComboBox CboTeam;
    }
}

