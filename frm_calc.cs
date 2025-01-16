using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalc : Form
    {
        float num1 = 0;
        float num2 = 0;
        string op = "";
        const string divError = "This is a very complex question. Many people say it's undefinined, but what is that? Well, it can also be considered indeterminent, but that's just the begining. There are many odd results when you get to the smallest part";
        bool firstnum = true; //flag for if it's the first number
        string mem = "";
        bool memClear = true; //whether the memory is clear

        public frmCalc()
        {
            InitializeComponent();


        }
        bool debug = true;
        string confirmClose = "please confirm your desire to leave"; //custom text for confirming close
        private void frmCalc_Load(object sender, EventArgs e)
        {
            
            if( debug == true)
            {
                txt_debug.Visible = true;
            } //if debug on see list
            else {
                this.Size = new Size(816, 489);
            }// if deug off, shrink form for conscisness;

            string closeText = bttnClose.Text;
            

            addItem(debug.ToString(),false); //debug mode?
            addItem(closeText, true); //close text
            addItem(confirmClose, false); //confirm close
            memClear = !memClear; //invert it, as the useage makes it such that the variable should be inverse. Another possible flaw, fix?
        }

        const string closeText = "Close";
        const string confirmText = "Confirm";

        private string addItem(string item, bool newEntry)
        {
            string empty = Environment.NewLine;
            if (newEntry == true)
            {
                txt_debug.AppendText(empty);
            }
            else
            {
            }
            txt_debug.AppendText(item);
            txt_debug.AppendText(empty);
            return txt_debug.Text.ToString();
        }
        private void bttnClose_Click(object sender, EventArgs e)
        {
            if ( bttnClose.Text == closeText) // next name
            {
                bttnClose.Text = confirmText;
            }
            else {
                Application.Exit(); //exit
            } // close
            tmr_ConfirmClose.Start(); //timer to allow confirmation
            
        }

        private void txt_debug_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmr_ConfirmClose_Tick(object sender, EventArgs e)
        {
            tmr_ConfirmClose.Stop();
            bttnClose.Text = closeText;
        }

        private void bttn_num_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string val = btn.Text;
            bool recall = false;
            if (val == bttn_recalFast.Text)
            {
                val = mem;
                recall = true;
            }


            if (rtb_ans.Text == "0" || firstnum)
            {
                rtb_ans.Text = val;
                firstnum = false;
            }
            else
            {
                rtb_ans.Text += val;
                if ( recall )
                {
                    rtb_ans.Text = val; //as recalled from memory, set to value from memory
                }
                else 
                {
                    rtb_ans.Text += val; //add entry to text
                }
            };
            // also the following works (but sometimes it works in cases like strings to integers. Sometimes it works, sometimes it doesn't.
            // Button btn = (Button)sender;
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            op = btn.Text;
            num1 = float.Parse(rtb_ans.Text);
            rtb_ans.Text = "0"; //set to 0 as after hitting operator you need 0, si?
            firstnum = false;

        }

        private void clear_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Clear Equation") //ensure it's clear equation (no operators, both nums are 0, 0 as answer)
            {
                num1 = 0;
                num2 = 0;
                op = "";
            } 
            rtb_ans.Text = "0";
            firstnum = false;
        }

        private void bttn_equal_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(rtb_ans.Text);

            switch ( op ) //runs only exact kinda like an if and an equal, with in-built if-else
            {
                case "+":
                    rtb_ans.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    rtb_ans.Text = (num1 - num2).ToString();
                    break;
                case "*":
                        rtb_ans.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        rtb_ans.Text = (num1 / num2).ToString();
                    } else {
                        MessageBox.Show(divError);
                    }
                    break;
                case "%":
                    if (num2 != 0)
                    {
                        rtb_ans.Text = (num1 % num2).ToString();
                    } else
                    {
                        MessageBox.Show(divError);
                    }
                    break;
                default:
                    {
                        rtb_ans.Text = num1.ToString();
                        break;
                    }
         
            }
            num1 = 0;
            num2 = 0;
            op = "";
            firstnum = true;
        }

        private void rtb_ans_TextChanged(object sender, EventArgs e)
        {
            string content = rtb_ans.Text;
            if (content == "0" || content == "")
            {
                bttn_memStoreFast.Visible = false;
            } else
            {
                bttn_memStoreFast.Visible = true;
            }
        }

        private void bttn_memStore_Click(object sender, EventArgs e)
        {
            mem = rtb_ans.Text;
            txt_memFastPrev.Text = mem; //shows the stored value in the textbox
            memClear = true; //shows memory is not clear, to allow viewing of memory and such
                //one falw: it assumes that this button requires you to be adding to memory. With future design, that could be issue
            txt_memFastPrev.Visible = memClear;
            bttn_recalFast.Visible = memClear;
            bttn_clear.Visible = memClear;
            bttn_clearMemFast.Visible = memClear;
        }

        private void bttn_clearMemFast_Click(object sender, EventArgs e)
        {
            memClear = false;
            txt_memFastPrev.Visible = memClear;
            bttn_recalFast.Visible = memClear;
            bttn_clearMemFast.Visible = memClear;
            mem = "";
        }
    }
}
