using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string p1;
            string p2;
            string p3;

            p1 = tbxPart1.Text;
            p2 = tbxPart2.Text;
            p3 = tbxPart3.Text;

            ListItem li = new ListItem(p1, p2, p3);

            lbxList.Items.Add(li);
        }
    }
}
