using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MetrixExtract
{
    public partial class FormManualData : Form
    {
        public FormManualData()
        {
            InitializeComponent();
            PopulateCycleTypes();
            PopulateLOB();
        }

        private string sqlCycleTimes = "SELECT ID,cycle_date,days From Cycle_Time";
        private string sqlDeleteCycleTime = "DELETE FROM Cycle_Time WHERE id=";
        private void BtnCycle_Click(object sender, EventArgs e)
        {
            LoadCycleTimeTable();
        }
        private void LoadCycleTimeTable()
        {
            GrpCycleTimes.Visible = false;

            if (CboLob.SelectedIndex > -1 && CboTeam.SelectedIndex > -1 && CboCycleType.SelectedIndex > -1)
            {
                GrpCycleTimes.Text = ("Cycle: " + CboCycleType.Text.Replace("_", " ")).ToUpperInvariant();
                LoadCycleTimes();
                GrpCycleTimes.Visible = true;
            }
        }
        private void LoadCycleTimes()
        {
            string sql = sqlCycleTimes + " WHERE lob = \"" + CboLob.SelectedItem.ToString() +
                "\" AND team_key = \"" + CboTeam.SelectedItem.ToString() +
                "\" AND cycle_type = \"" + CboCycleType.SelectedItem.ToString() +
                "\" ORDER BY cycle_date DESC";
            this.DgvData.Rows.Clear();

            try
            {
                if (MetrixSharedCode.OpenDBConnection(sql))
                {
                    MetrixSharedCode.oOleDbDataReader = MetrixSharedCode.oOleDbCommand.ExecuteReader();

                    while (MetrixSharedCode.oOleDbDataReader.Read())
                    {
                        int index = MetrixSharedCode.oOleDbDataReader.FieldCount;
                        string[] str = new string[index];
                        for (int i = 0; i < index; i++)
                        {
                            str[i] = MetrixSharedCode.oOleDbDataReader.GetValue(i).ToString();
                        }
                        this.DgvData.Rows.Add(str);
                    }

                    MetrixSharedCode.oOleDbDataReader.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Function failed, check logs");
                Console.WriteLine(ex.StackTrace);
            } finally {
                MetrixSharedCode.oOleDbDataReader = null;

                MetrixSharedCode.CloseDBConnection();
            }
        }

        private void PopulateComboBox(string sql, ComboBox cbo)
        {
            try
            {
                if (MetrixSharedCode.OpenDBConnection(sql))
                {
                    MetrixSharedCode.oOleDbDataReader = MetrixSharedCode.oOleDbCommand.ExecuteReader();

                    while (MetrixSharedCode.oOleDbDataReader.Read())
                    {
                        cbo.Items.Add(MetrixSharedCode.oOleDbDataReader.GetValue(0));
                    }

                    MetrixSharedCode.oOleDbDataReader.Close();
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
            } finally {
                MetrixSharedCode.oOleDbDataReader = null;

                MetrixSharedCode.CloseDBConnection();
            }
        }

        private void PopulateCycleTypes()
        {
            string sql = "SELECT DISTINCT cycle_type from Cycle_Types ORDER BY cycle_type";
            CboCycleType.Items.Clear();
            PopulateComboBox(sql, CboCycleType);
        }

        private void PopulateLOB()
        {
            string sql = "SELECT DISTINCT lob from Areas ORDER BY lob";
            CboLob.Items.Clear();
            PopulateComboBox(sql, CboLob);
        }

        private void PopulateTeams()
        {
            string sql = "SELECT DISTINCT team_key from Areas WHERE lob = '" + CboLob.SelectedItem.ToString() + "' ORDER BY team_key";
            CboTeam.Items.Clear();
            PopulateComboBox(sql, CboTeam);
        }

        private Boolean DeleteCycleTime(int index)
        {
            try
            {
                if (MetrixSharedCode.OpenDBConnection(sqlDeleteCycleTime + index.ToString()))
                    MetrixSharedCode.oOleDbCommand.ExecuteReader();
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                return false;
            } finally {
                MetrixSharedCode.CloseDBConnection();
            }
            return true;
        }
        private void CboTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrpCycleTimes.Visible = false;
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FormEdit frmEdit;

            if (DgvData.Rows.Count > 0)
            {
                frmEdit = new FormEdit();
                frmEdit.pRecordType = MetrixSharedCode.RecordType.CycleTime;
                frmEdit.GrpEdit.Text = "Edit Record";
                frmEdit.BtnUpdate.Text = "Update";
                frmEdit.RecordType = Convert.ToInt32(DgvData.Rows[DgvData.CurrentCell.RowIndex].Cells[0].Value);
                frmEdit.CalDate.Value = Convert.ToDateTime(DgvData.Rows[DgvData.CurrentCell.RowIndex].Cells[1].Value);
                frmEdit.TxtValue.Text = (string)DgvData.Rows[DgvData.CurrentCell.RowIndex].Cells[2].Value;
                frmEdit.TxtType.Text = CboCycleType.SelectedItem.ToString();
                frmEdit.TxtLOB.Text = CboLob.SelectedItem.ToString();
                frmEdit.TxtTeam.Text = CboTeam.SelectedItem.ToString();
                frmEdit.ShowDialog();
            }
        }
        private void BtnChartData_Click(object sender, EventArgs e)
        {
            DataPoint dp;

            FormGraph frmGraph = new FormGraph();
            frmGraph.ChtMetrics.Series.Clear();
            frmGraph.ChtMetrics.Series.Add(GrpCycleTimes.Text);
            frmGraph.ChtMetrics.Series[GrpCycleTimes.Text].ChartType = SeriesChartType.Column;
            for (int i=0; i < DgvData.Rows.Count; i++)
            {
                dp = new DataPoint();
                dp.SetValueXY(DgvData.Rows[i].Cells[1].Value, DgvData.Rows[i].Cells[2].Value);
                frmGraph.ChtMetrics.Series[0].Points.Add(dp);
                frmGraph.ChtMetrics.ChartAreas[0].AxisX.IsReversed = true;
            }
            frmGraph.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int iDBIndex;
            int iDBRowIndex;
            if (DgvData.Rows.Count > 0)
            {
                iDBRowIndex = DgvData.CurrentCell.RowIndex;
                iDBIndex = Convert.ToInt32(DgvData.Rows[iDBRowIndex].Cells[0].Value);
                DialogResult dialog = MessageBox.Show("Delete Row: " + System.Environment.NewLine + System.Environment.NewLine
                                                        + "For Date: " + System.Environment.NewLine
                                                        + DgvData.Rows[iDBRowIndex].Cells[1].Value + System.Environment.NewLine
                                                        + "With Value: " + DgvData.Rows[iDBRowIndex].Cells[2].Value
                                            , "Exit", MessageBoxButtons.YesNoCancel);

                switch (dialog)
                {
                    case DialogResult.Yes:
                        if (DeleteCycleTime(iDBIndex))
                        {
                            MessageBox.Show("Deleted");
                        } else {
                            MessageBox.Show("Not Complete");
                        }
                        LoadCycleTimes();
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Aborted");
                        break;
                }
            } else {
                MessageBox.Show("No available data");
            }
        }
        private void CboLob_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrpCycleTimes.Visible = false;
            PopulateTeams();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormEdit frmEdit = new FormEdit();


            frmEdit.pRecordType = MetrixSharedCode.RecordType.CycleTime;
            frmEdit.GrpEdit.Text = "Add Record";
            frmEdit.BtnUpdate.Text = "Add";
            frmEdit.TxtType.Text = CboCycleType.SelectedItem.ToString();
            frmEdit.TxtLOB.Text = CboLob.SelectedItem.ToString();
            frmEdit.TxtTeam.Text = CboTeam.SelectedItem.ToString();
            frmEdit.ShowDialog();
        }
    }
}