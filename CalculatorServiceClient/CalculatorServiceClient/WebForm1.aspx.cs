using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorServiceClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceReference1.CalculatorServiceClient client = new ServiceReference1.CalculatorServiceClient("BasicHttpBinding_ICalculatorService");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int firstNumber = Convert.ToInt32(TextBox1.Text);
            int secondNumber = Convert.ToInt32(TextBox2.Text);
            Label1.Text = client.sum(firstNumber, secondNumber).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(TextBox1.Text);
            int secondNumber = Convert.ToInt32(TextBox2.Text);
            Label1.Text = client.div(firstNumber, secondNumber).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(TextBox1.Text);
            int secondNumber = Convert.ToInt32(TextBox2.Text);
            Label1.Text = client.mul(firstNumber, secondNumber).ToString();
        }
    }
}