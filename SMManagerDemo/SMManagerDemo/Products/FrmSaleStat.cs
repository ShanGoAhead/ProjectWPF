using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMManagerDemo.Product
{
    public partial class FrmSaleStat : Form
    {
        public FrmSaleStat()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSaleStat_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain .objSaleStat = null;
        }
    }
}
