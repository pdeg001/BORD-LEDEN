using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scorebord_leden
{
    public partial class BondsLeden : Form
    {
        public BondsLeden()
        {
            InitializeComponent();
        }

        private void chkKnbbSpelers_CheckedChanged(object sender, EventArgs e)
        {
            MainForm frm = new MainForm
            {
                Top = this.Top,
                Left = this.Left,
                Height = this.Height,
                Width = this.Width
            };

            this.Hide();
            
            frm.ShowVereniging();


        }

        private void BondsLeden_Load(object sender, EventArgs e)
        {
            this.Text += GenFunction.GetVersionNumber();
        }
    }
}
