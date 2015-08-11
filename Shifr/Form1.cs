using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shifr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCod_Click(object sender, EventArgs e)
        {//шифрование
            string text = tbOpenText.Text;
            string keyword = tbKey.Text;
            AlbertyRu alb = new AlbertyRu(text, keyword, true);
            alb.Coder();
            tbShText.Text = alb.ShifrText;

        }

        private void btnDecod_Click(object sender, EventArgs e)
        {
            string text = tbShText.Text;
            string keyword = tbKey.Text;
            AlbertyRu alb = new AlbertyRu(text, keyword, true);
            alb.Decoder();
            tbOpenText.Text = alb.OpenText;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbKey.Text = "";
            tbOpenText.Text = "";
            tbShText.Text = "";
        }
    }
}
