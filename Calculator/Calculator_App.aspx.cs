using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calculator_App : System.Web.UI.Page
    {
        Boolean operator_Check = false;
        double first_Number, second_Number;
      
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if ((Result_box.Text == "0")||(operator_Check))
                Result_box.Text = string.Empty;
            Button btn = (Button)sender;
            Result_box.Text = Result_box.Text + btn.Text;
            
        }

        protected void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ViewState["Operator"] = btn.Text;
            ViewState["Value"] = Result_box.Text;
            Result_box.Text = string.Empty;
            operator_Check = true;
            
        }
        
        protected void Button_CE_Click(object sender, EventArgs e)
        {
            Result_box.Text = "0";
        }

        protected void Button_MOD_Click(object sender, EventArgs e)
        {
            first_Number = Convert.ToDouble(Result_box.Text);
            Result_box.Text = Convert.ToString(first_Number / 100);
        }

        protected void Button_BACKSPACE_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            string newNumber = string.Empty;

            for(int i= 0; i < number.Length-1; i++)
            {
                newNumber = newNumber + number[i];
            }
            if(newNumber == "")
            {
                Result_box.Text = "0";
            }
            else
            {
                Result_box.Text = newNumber;
            }
            
        }

        protected void Button_EQUAL_Click(object sender, EventArgs e)
        {
            first_Number = Convert.ToDouble(ViewState["Value"]);
            second_Number = Convert.ToDouble(Result_box.Text);
            Result_box.Text = string.Empty;
           
            string op = Convert.ToString(ViewState["Operator"]);
            if (op == "+")
            {
                Result_box.Text = Convert.ToString(first_Number + second_Number);
            }
            else if (op == "x")
            {
                Result_box.Text = Convert.ToString(first_Number * second_Number);
            }
            else if (op == "-")
            {
                if (first_Number > second_Number)
                    Result_box.Text = Convert.ToString(first_Number - second_Number);
                else
                    Result_box.Text = "-" + Convert.ToString(second_Number - first_Number);
            }
            else if (op == "/")
            {
                Result_box.Text = Convert.ToString(first_Number / second_Number);
            }
           
        }
    }
}