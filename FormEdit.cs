using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetrixExtract
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        private MetrixSharedCode.RecordType vRecordType;
        private int iRecordType = -1;
        public MetrixSharedCode.RecordType pRecordType
        {
            get => vRecordType;
            set => vRecordType = value;
        }
        public int RecordType
        {
            get => iRecordType;
            set => iRecordType = value;
        }
        private string SqlInsertUpdateCycleTime()
        {
            if (iRecordType < 0)
            {
                return "INSERT INTO Cycle_Time (cycle_type,lob,team_key,cycle_date,days) " +
                    "VALUES (\"" + TxtType.Text + "\",\"" + TxtLOB.Text + "\",\"" +
                    TxtTeam.Text + "\",\"" + CalDate.Value + "\"," + TxtValue.Text + ")";
            } else {
                return "UPDATE Cycle_Time SET cycle_date=\"" + CalDate.Value +
                    "\", days = \"" + TxtValue.Text + "\" WHERE id=" + iRecordType.ToString();
            }
        }

        private string SqlInsertUpdateHealth()
        {
            if (iRecordType < 0)
            {
                return "INSERT INTO Cycle_Time (cycle_type,lob,team_key,cycle_date,days) " +
                    "VALUES (\"" + TxtType.Text + "\",\"" + TxtLOB.Text + "\",\"" +
                    TxtTeam.Text + "\",\"" + CalDate.Value + "\"," + TxtValue.Text + ")";
            }
            else
            {
                return "UPDATE Cycle_Time SET cycle_date=\"" + CalDate.Value +
                    "\", days = \"" + TxtValue.Text + "\" WHERE id=" + iRecordType.ToString();
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string sqlInsertUpdate = "";

            switch (pRecordType)
            {
                case MetrixSharedCode.RecordType.CycleTime:
                    sqlInsertUpdate = SqlInsertUpdateCycleTime();
                    break;
                case MetrixSharedCode.RecordType.Health:
                    sqlInsertUpdate = SqlInsertUpdateHealth();
                    break;
            }

            try
            {
                if (MetrixSharedCode.OpenDBConnection(sqlInsertUpdate))
                    MetrixSharedCode.oOleDbCommand.ExecuteReader();

            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
            } finally {
                MetrixSharedCode.CloseDBConnection();
                //LoadCycleTimeTable();
                this.Close();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}