using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chequeusbwebserber
{
    public partial class FmrMenu : Form
    {
        public FmrMenu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrTest Fmr = new FmrTest();

            //definir el formlario padre 

            Fmr.MdiParent = this;
            Fmr.Show(); 




        }

        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Fmr = new Form1();
            Fmr.MdiParent = this;
            Fmr.Show();





        }
    }
}
