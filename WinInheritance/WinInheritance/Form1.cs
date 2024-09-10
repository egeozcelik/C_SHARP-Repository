using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Saz s = new Saz();
            MessageBox.Show(s.SesVer());

            Gitar g = new Gitar();
            MessageBox.Show(g.SesVer());

            Keman k = new Keman();
            MessageBox.Show(k.SesVer());
        }

      
    }
}
