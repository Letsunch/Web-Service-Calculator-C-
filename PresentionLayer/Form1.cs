using System;
using System.Windows.Forms;
using PresentionLayer.ServiceReference1;
using DataAccessLayer;


namespace PresentionLayer
{
    public partial class Form1 : Form
    {
        WebService1SoapClient obj;
        public Form1()
        {
            InitializeComponent();
        }
        private readonly DataLayer dataLayer = new DataLayer();
        String CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void subtractbtn_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void multiplybtn_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            num2= int.Parse(txtTotal.Text);
            if (option.Equals("+"))
            
                result = num1 + num2;

            
            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            txtTotal.Text = result + "";
            dataLayer.SaveCalculation($"{num1} {option} {num2} = {result}");

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new WebService1SoapClient();
        }
    }
}
