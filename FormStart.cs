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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void BtnMetrixThruDB_Click(object sender, EventArgs e)
        {
            FormManualData frmManualData = new FormManualData();
            frmManualData.ShowDialog();
        }

        private void BtnParseJSON_Click(object sender, EventArgs e)
        {
            FormJson frmJSON = new FormJson();
            frmJSON.ShowDialog();
        }
    }
}
