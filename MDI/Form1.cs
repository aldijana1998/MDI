using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Otvori(object sender, EventArgs e)
        {
            Form oChildForm = new Form2();
            oChildForm.MdiParent = this;
            oChildForm.Show();
        }

        private void Zatvori(object sender, EventArgs e)
        {
            bool bZatvoreno = false;
            foreach (Form childForm in MdiChildren)
            { 
                if ((childForm == ActiveMdiChild) && !bZatvoreno)
                {
                    childForm.Close();
                    bZatvoreno = true;
                }
            }
        }
    }
}





