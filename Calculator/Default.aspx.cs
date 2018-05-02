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
        double new_num1;
        double new_num2;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // click event on 1-9 button click
        protected void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Result_box.Text == "0")
            {
                Result_box.Text = string.Empty;
                lbl_result.Text = "";
            }
            Result_box.Text = Result_box.Text + btn.Text;
            
        }

        // getting value of first number and selected operator
        protected void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            String str = Result_box.Text;
            string op = btn.Text;
           
            if (Result_box.Text == "")
            {
                lbl_result.Text = "Enter a valid number before operation.";
                Result_box.Text = "0";
            }
            else if ((str.LastIndexOf("+") > 0) || (str.LastIndexOf("x") > 0) || (str.LastIndexOf("/") > 0) || (str.LastIndexOf("-") > 0)) //checking if user is trying to enter more than 1 operator
            {
                lbl_result.Text = "Only one operation is allowed.";
            }
            else
            {
                if(Result_box.Text == "0")
                {
                    Result_box.Text = "0";
                }
                else
                {
                    Result_box.Text = Result_box.Text + btn.Text;
                }
                
                ViewState["Operator"] = btn.Text;
            }
        }

        //enter a negative value
        protected void plusMinus_Click(object sender, EventArgs e)
        {
            String str = Result_box.Text;
            char minusFounder = str[str.Length - 1]; //checking if the last character is "-"
            string minus = "-";
            char charMinus = Convert.ToChar(minus);

            if (minusFounder == charMinus) //if last character is "-", do nothing. This prevents adding many "-" signs
            {
                //Result_box.Text = Result_box.Text + "-";
            }
            else if(Result_box.Text == "0")
            {
                Result_box.Text = "-";
            }
            else
            {
                Result_box.Text = Result_box.Text + "-";
            }
        }


        //decimal point button
        protected void Button_DOT_Click(object sender, EventArgs e)
        {
            String str = Result_box.Text;
            Button btn = (Button)sender;
            char dot = Convert.ToChar(".");
            int count = 0;
            String op = Convert.ToString(str[str.Length - 1]);

            //counting the number of decimal points in a equation
            foreach (char ch in str)
            {
                if (ch == dot)
                {
                    count++;
                }
            }

            //checking if user is trying to enter invalid decimal point values
            if ((str.IndexOf(".") < 0) && ((str.IndexOf("+") < 0) || (str.IndexOf("-") < 0) || (str.IndexOf("x") < 0) || (str.IndexOf("/") < 0)))
            {
                if ((op == "+") || (op == "-") || (op == "/") || (op == "x")) //if user press decimal after operator, appending 0 before decimal
                {
                    Result_box.Text = Result_box.Text + "0" + btn.Text;
                }
                else
                {
                    Result_box.Text = Result_box.Text + btn.Text;
                }
            }
            else if ((count == 1) && ((str.IndexOf("+") > 0) || (str.IndexOf("-") > 0) || (str.IndexOf("x") > 0) || (str.IndexOf("/") > 0)))
            {
                if ((op == "+") || (op == "-") || (op == "/") || (op == "x")) //if user press decimal after operator, appending 0 before decimal
                {
                    Result_box.Text = Result_box.Text + "0" + btn.Text;
                }
                else
                {
                    Result_box.Text = Result_box.Text + btn.Text;
                }
            }
            else
            {
                lbl_result.Text = "Too many decimal points.";
            }
        }


        // calculate results based on operator selection
        protected void Button_EQUAL_Click(object sender, EventArgs e)
        {
            String str = Result_box.Text;
            String num1 = "";
            String num2 = "";
            int index = 0;
            string op = "";
            string catchOperator = Convert.ToString(ViewState["Operator"]);

            op = Convert.ToString(ViewState["Operator"]);

            if (catchOperator == "")
            {
                op = "-";
            }
            else
            {
                op = catchOperator;
            }
           
            if(op == "-")
            {
                index = str.LastIndexOf(op);
            }
            else
            {
                index = str.IndexOf(op);
            }
           
        
            // getting first number from the equation
            for (int i = 0; i < index; i++)
            {
                num1 = num1 + str[i];
            }

            // getting second number from the equation
            for (int j = index + 1; j < str.Length; j++)
            {
                num2 = num2 + str[j];
            }

            try
            {
                 new_num1 = Convert.ToDouble(num1);
                 new_num2 = Convert.ToDouble(num2);
                 lbl_result.Text = num1 + " " + op + " " + num2;
            }
            catch(Exception ex)
            {
                
            }
        
            //doing calculation according to operator selection
            if (op == "+")
            {
                Result_box.Text = Convert.ToString(new_num1 + new_num2);
            }
            else if (op == "x")
            {
                Result_box.Text = Convert.ToString(new_num1 * new_num2);
            }
            else if (op == "-")
            {
                Result_box.Text = Convert.ToString(new_num1 - new_num2);
            }
            else if (op == "/")
            {
                Result_box.Text = Convert.ToString(new_num1 / new_num2);
            }
        }

        //clear entry function
        protected void Button_CE_Click(object sender, EventArgs e)
        {
            Result_box.Text = "0";
            lbl_result.Text = "";
        }

       
        // return key press function
        protected void Button_BACKSPACE_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            string newNumber = string.Empty;

            for (int i = 0; i < number.Length - 1; i++)
            {
                newNumber = newNumber + number[i]; //getting new string after removing last number
            }
            if (newNumber == "")
            {
                Result_box.Text = "0";
                lbl_result.Text = "";
            }
            else
            {
                Result_box.Text = newNumber; //displaying new string
            }
        }

        //function x^2 (x * x)
        protected void btn_x2_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    double num = Convert.ToDouble(Result_box.Text);
                    lbl_result.Text = Convert.ToString(num + "x" + num);
                    Result_box.Text = Convert.ToString(num * num);
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }

        //function x^3 (x * x * x)
        protected void btn_x3_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    double num = Convert.ToDouble(Result_box.Text);
                    lbl_result.Text = Convert.ToString(num + "x" + num + "x" + num);
                    Result_box.Text = Convert.ToString(num * num * num);
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }


        //converting decimal value to hexadecimal value(https://www.rapidtables.com/convert/number/decimal-to-hex.html)
        protected void btn_hex_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf(".") >= 0) || (number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid whole number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    int num = Convert.ToInt32(Result_box.Text);
                    Result_box.Text = Convert.ToString(num);
                    lbl_result.Text = "Hex " + num;
                    Result_box.Text = (Convert.ToString(num, 16));
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }

        //calculationg mod 
        protected void btn_mod_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number == "∞") || (number.IndexOf("-") >= 0))
            {
                lbl_result.Text = "Please enter a valid whole number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    double num = Convert.ToDouble(Result_box.Text);
                    lbl_result.Text = Convert.ToString(num + " / " + 100);
                    Result_box.Text = Convert.ToString(num / 100);
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }


        //converting decimal value to binary value(https://www.rapidtables.com/convert/number/decimal-to-hex.html)
        protected void btn_bin_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf(".") >= 0) || (number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid whole number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    int num = Convert.ToInt32(Result_box.Text);
                    Result_box.Text = Convert.ToString(num, 2);
                    lbl_result.Text = "Binary of " + num;
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }

        //calculating 1/user_value
        protected void btn_1x_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    double num = Convert.ToDouble(Result_box.Text);
                    lbl_result.Text = Convert.ToString("1 / " + num);
                    Result_box.Text = Convert.ToString(1 / num);
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }


        protected void btn_Pi_Click(object sender, EventArgs e)
        {
            String str = Result_box.Text;
            String op = Convert.ToString(str[str.Length - 1]);
            if ((op == "+") || (op == "-") || (op == "/") || (op == "x")) //if user already has an equation, then append the value of Pi
            {
                Result_box.Text = Result_box.Text + "3.14159";
            }
            else
            {
                Result_box.Text = "3.14159";
            }
        }


        protected void btn_log_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number == "∞") || (number.IndexOf("-") >= 0))
            {
                lbl_result.Text = "Please enter a valid whole number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    double num = Convert.ToDouble(Result_box.Text);
                    lbl_result.Text = Convert.ToString("Log " + "(" + Result_box.Text + ")");
                    Result_box.Text = Convert.ToString(Math.Log10(num));
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }


        protected void btn_Sqrt_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid whole number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    lbl_result.Text = Convert.ToString("Sqrt " + "(" + Result_box.Text + ")");
                    double num = Convert.ToDouble(Result_box.Text);
                    Result_box.Text = Convert.ToString(Math.Sqrt(num));
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }

        protected void btn_sinh_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid whole number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    lbl_result.Text = Convert.ToString("Sinh " + "(" + Result_box.Text + ")");
                    double num = Convert.ToDouble(Result_box.Text);
                    Result_box.Text = Convert.ToString(Math.Sinh(num));
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }

        protected void btn_sin_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid whole number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    lbl_result.Text = Convert.ToString("Sin " + "(" + Result_box.Text + ")");
                    double num = Convert.ToDouble(Result_box.Text);
                    Result_box.Text = Convert.ToString(Math.Sin(num));
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }

        protected void btn_cosh_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid whole number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    lbl_result.Text = Convert.ToString("Cosh " + "(" + Result_box.Text + ")");
                    double num = Convert.ToDouble(Result_box.Text);
                    Result_box.Text = Convert.ToString(Math.Cosh(num));
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }

        protected void btn_tanh_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid whole number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    lbl_result.Text = Convert.ToString("Tanh " + "(" + Result_box.Text + ")");
                    double num = Convert.ToDouble(Result_box.Text);
                    Result_box.Text = Convert.ToString(Math.Tanh(num));
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }

        protected void btn_tan_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid whole number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    lbl_result.Text = Convert.ToString("Tan " + "(" + Result_box.Text + ")");
                    double num = Convert.ToDouble(Result_box.Text);
                    Result_box.Text = Convert.ToString(Math.Tan(num));
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }


        protected void btn_cos_Click(object sender, EventArgs e)
        {
            string number = Result_box.Text;
            if ((number.IndexOf("-") >= 0) || (number == "∞"))
            {
                lbl_result.Text = "Please enter a valid whole number.";
                Result_box.Text = "0";
            }
            else
            {
                try
                {
                    lbl_result.Text = Convert.ToString("Cos " + "(" + Result_box.Text + ")");
                    double num = Convert.ToDouble(Result_box.Text);
                    Result_box.Text = Convert.ToString(Math.Cos(num));
                }
                catch (Exception ex)
                {
                    lbl_result.Text = "Please enter a valid number.";
                    Result_box.Text = "0";
                }
            }
        }

    }
}