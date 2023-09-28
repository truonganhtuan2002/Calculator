using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaytinhCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // doi dau khi bam vao
        private void btnAmDuong_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(lbDisplay.Text) * (-1);
            lbDisplay.Text = System.Convert.ToString(a);
        }
        // bat su kien cho cac dau 
        private void operator_Click(object sender, EventArgs e)
        {
           
        }
        // click bang
        private void btnBang_Click(object sender, EventArgs e)
        {
                var result = tinh(lbDisplay.Text);
                lbKetQua.Text = Convert.ToString(result);
        }

        private void click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            lbDisplay.Text += bt.Text;
           
        }

        private double tinh(String contents)
        {
            DataTable tb = new DataTable();
            return Convert.ToDouble(tb.Compute(contents, String.Empty));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbDisplay.Text = " ";
            lbKetQua.Text = " ";
        }
        // xu ly xoa
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lbDisplay.Text.Length > 0)
            {
                lbDisplay.Text = lbDisplay.Text.Remove(lbDisplay.Text.Length - 1, 1);
            }
            if (lbDisplay.Text == "")
            {
                lbDisplay.Text = "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lbDisplay.Text = "0";
            lbKetQua.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lbDisplay.Text = "0";
            lbKetQua.Text = "";
        }
    }
}
