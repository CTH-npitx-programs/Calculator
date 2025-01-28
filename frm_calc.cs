using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalc : Form
    {
        float num1 = 0;
        float num2 = 0;
        string op = "";
        string mem = "";
        const string divError = "This is a very complex question. Many people say it's undefinined, but what is that? Well, it can also be considered indeterminent, but that's just the begining. There are many odd results when you get to the smallest part";
        bool firstnum = true; //flag for if it's the first number
        string rapidMem = "";
        bool rapidMemClear = true; //whether the memory is clear
        string memFull = "";
        

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
            rapidMemClear = !rapidMemClear; //invert it, as the useage makes it such that the variable should be inverse. Another possible flaw, fix?
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
        } //debug text boxes
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
            
        } //close after confirm

        private void txt_debug_TextChanged(object sender, EventArgs e)
        {

        } //if change in debug text

        private void tmr_ConfirmClose_Tick(object sender, EventArgs e)
        {
            tmr_ConfirmClose.Stop();
            bttnClose.Text = closeText;
        } //when you hit close, this timer will change the text for 3 seconds. if you hit the button within those 3 seconds the application closes

        private void bttn_num_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string val = btn.Text;
            bool recall = false;
            if (val == bttn_recalFast.Text)
            {
                val = rapidMem;
                recall = true;
            }


            if (rtb_ans.Text == "0" || firstnum)
            {
                rtb_ans.Text = val;
                firstnum = false;
            }
            else
            {
                if ( recall )
                {
                    rtb_ans.Text = val; //as recalled from memory, set to value from memory
                }
                else if (btn.Text == bttn_recalFull.Text) //as recalled from full memory, set
                {
                    rtb_ans.Text = txt_previewFull.Text;
                } else {
                    rtb_ans.Text += val; //add entry to text
                }
            };
            // also the following works (but sometimes it works in cases like strings to integers. Sometimes it works, sometimes it doesn't.
            // Button btn = (Button)sender;
        } //input numbers

        private void op_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            op = btn.Text;
            num1 = float.Parse(rtb_ans.Text);
            mem = rtb_ans.Text + op;
            rtb_ans.Text = "0"; //set to 0 as after hitting operator you need 0, si?
            firstnum = false;

        } //add operators

        private void clear_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;


            num1 = 0; //these three lines clear all the numbers
            num2 = 0;
            op = "";

            rtb_ans.Text = "0"; //set answer to 0

            if (btn.Text == "Clear All") //check if it's clear all, if so wipe both memories as well
            {
                lst_memFull.Items.Clear(); //clear full memory
                rapidMem = ""; //clear rapid mem
                rapidMemClear = false; //set clear to say it is clear (due to convoluted reasons the boolean is inverted)
            }
            firstnum = false;
        } //clear equation

        private void bttn_equal_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(rtb_ans.Text);
            mem += rtb_ans.Text;

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

            
            mem += "="+rtb_ans.Text;
            lst_memFull.Items.Add(mem);

            mem = "";
            num1 = 0;
            num2 = 0;
            op = "";
            firstnum = true;
        } //equals button

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
        } //controll systems based on the answer changeing

        private void bttn_memStoreFast_Click(object sender, EventArgs e)
        {
            rapidMem = rtb_ans.Text;
            txt_memFastPrev.Text = rapidMem; //shows the stored value in the textbox
            rapidMemClear = true; //shows memory is not clear, to allow viewing of memory and such
                             //one flaw: it assumes that this button requires you to be adding to memory. With future design, that could be issue
            txt_memFastPrev.Visible = rapidMemClear;
            bttn_recalFast.Visible = rapidMemClear;
            bttn_clear.Visible = rapidMemClear;
            bttn_clearMemFast.Visible = rapidMemClear;
        } //store code in fast mem

        private void bttn_clearMemFast_Click(object sender, EventArgs e)
        {
            rapidMemClear = false;
            txt_memFastPrev.Visible = rapidMemClear;
            bttn_recalFast.Visible = rapidMemClear;
            bttn_clearMemFast.Visible = rapidMemClear;
            rapidMem = "";
        } //clear the rapid mem

        private void lst_memFull_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = lst_memFull.SelectedIndex;  //get intex
            memFull = lst_memFull.SelectedItem.ToString(); //get selected item, to manipulate to get the correct item
            var memItems = memFull.Split('=').ToList();
            position = memItems.Count; //posistion is also used to find where the equals sign is
            memFull = memItems[position-1];
            txt_previewFull.Text = memFull; //set preview box
            
        }

        private void txt_previewFull_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
