namespace MetrixExtract
{
    partial class FormEdit
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
            this.GrpEdit = new System.Windows.Forms.GroupBox();
            this.LblTeam = new System.Windows.Forms.Label();
            this.LblLOB = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LblType = new System.Windows.Forms.Label();
            this.LblValue = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.CalDate = new System.Windows.Forms.DateTimePicker();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.TxtTeam = new System.Windows.Forms.TextBox();
            this.TxtLOB = new System.Windows.Forms.TextBox();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.GrpEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpEdit
            // 
            this.GrpEdit.Controls.Add(this.LblTeam);
            this.GrpEdit.Controls.Add(this.LblLOB);
            this.GrpEdit.Controls.Add(this.BtnCancel);
            this.GrpEdit.Controls.Add(this.BtnUpdate);
            this.GrpEdit.Controls.Add(this.LblType);
            this.GrpEdit.Controls.Add(this.LblValue);
            this.GrpEdit.Controls.Add(this.LblDate);
            this.GrpEdit.Controls.Add(this.CalDate);
            this.GrpEdit.Controls.Add(this.TxtValue);
            this.GrpEdit.Controls.Add(this.TxtTeam);
            this.GrpEdit.Controls.Add(this.TxtLOB);
            this.GrpEdit.Controls.Add(this.TxtType);
            this.GrpEdit.Location = new System.Drawing.Point(12, 12);
            this.GrpEdit.Name = "GrpEdit";
            this.GrpEdit.Size = new System.Drawing.Size(345, 201);
            this.GrpEdit.TabIndex = 1;
            this.GrpEdit.TabStop = false;
            this.GrpEdit.Text = "Edit";
            // 
            // LblTeam
            // 
            this.LblTeam.AutoSize = true;
            this.LblTeam.Location = new System.Drawing.Point(43, 76);
            this.LblTeam.Name = "LblTeam";
            this.LblTeam.Size = new System.Drawing.Size(37, 13);
            this.LblTeam.TabIndex = 14;
            this.LblTeam.Text = "Team:";
            // 
            // LblLOB
            // 
            this.LblLOB.AutoSize = true;
            this.LblLOB.Location = new System.Drawing.Point(43, 50);
            this.LblLOB.Name = "LblLOB";
            this.LblLOB.Size = new System.Drawing.Size(31, 13);
            this.LblLOB.TabIndex = 13;
            this.LblLOB.Text = "LOB:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(173, 157);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(76, 157);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(43, 22);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(34, 13);
            this.LblType.TabIndex = 10;
            this.LblType.Text = "Type:";
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.Location = new System.Drawing.Point(43, 129);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(37, 13);
            this.LblValue.TabIndex = 9;
            this.LblValue.Text = "Value:";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(43, 106);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(33, 13);
            this.LblDate.TabIndex = 8;
            this.LblDate.Text = "Date:";
            // 
            // CalDate
            // 
            this.CalDate.Location = new System.Drawing.Point(121, 100);
            this.CalDate.Name = "CalDate";
            this.CalDate.Size = new System.Drawing.Size(200, 20);
            this.CalDate.TabIndex = 7;
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(121, 126);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(100, 20);
            this.TxtValue.TabIndex = 5;
            // 
            // TxtTeam
            // 
            this.TxtTeam.Enabled = false;
            this.TxtTeam.Location = new System.Drawing.Point(121, 73);
            this.TxtTeam.Name = "TxtTeam";
            this.TxtTeam.Size = new System.Drawing.Size(100, 20);
            this.TxtTeam.TabIndex = 4;
            // 
            // TxtLOB
            // 
            this.TxtLOB.Enabled = false;
            this.TxtLOB.Location = new System.Drawing.Point(121, 47);
            this.TxtLOB.Name = "TxtLOB";
            this.TxtLOB.Size = new System.Drawing.Size(100, 20);
            this.TxtLOB.TabIndex = 3;
            // 
            // TxtType
            // 
            this.TxtType.Enabled = false;
            this.TxtType.Location = new System.Drawing.Point(121, 19);
            this.TxtType.Name = "TxtType";
            this.TxtType.Size = new System.Drawing.Size(100, 20);
            this.TxtType.TabIndex = 2;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 224);
            this.Controls.Add(this.GrpEdit);
            this.Name = "FormEdit";
            this.Text = "Edit";
            this.GrpEdit.ResumeLayout(false);
            this.GrpEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GrpEdit;
        internal System.Windows.Forms.Label LblTeam;
        internal System.Windows.Forms.Label LblLOB;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnUpdate;
        internal System.Windows.Forms.Label LblType;
        internal System.Windows.Forms.Label LblValue;
        internal System.Windows.Forms.Label LblDate;
        internal System.Windows.Forms.DateTimePicker CalDate;
        internal System.Windows.Forms.TextBox TxtValue;
        internal System.Windows.Forms.TextBox TxtTeam;
        internal System.Windows.Forms.TextBox TxtLOB;
        internal System.Windows.Forms.TextBox TxtType;
    }
}