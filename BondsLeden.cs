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

        private void BondsLeden_Load(object sender, EventArgs e)
        {
            this.Text += GenFunction.GetVersionNumber();
        }

        private void Btn_Knbb_Spelers_Click(object sender, EventArgs e)
        {
            Owner.StartPosition = FormStartPosition.Manual;
            Owner.Location = Location;
            Hide();
            Owner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Applicatie sluiten", "Vereniging - Leden",
                                   MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                System.Threading.Thread.Sleep(100);
                Application.Exit();
            }
        }
    }
}
