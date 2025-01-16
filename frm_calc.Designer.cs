namespace Calculator
{
    partial class frmCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCalc
            // 
            this.ClientSize = new System.Drawing.Size(1005, 539);
            this.Name = "frmCalc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnClose;
        private System.Windows.Forms.Timer tmr_ConfirmClose;
        private System.Windows.Forms.TextBox txt_debug;
        private System.Windows.Forms.Button bttn_1;
        private System.Windows.Forms.Button bttn_2;
        private System.Windows.Forms.Button bttn_3;
        private System.Windows.Forms.Button bttn_6;
        private System.Windows.Forms.Button bttn_5;
        private System.Windows.Forms.Button bttn_4;
        private System.Windows.Forms.Button bttn_9;
        private System.Windows.Forms.Button bttn_8;
        private System.Windows.Forms.Button bttn_7;
        private System.Windows.Forms.Button bttn_sub;
        private System.Windows.Forms.Button bttn_add;
        private System.Windows.Forms.Button bttn_equal;
        private System.Windows.Forms.Button bttn_mult;
        private System.Windows.Forms.Button bttn_div;
        private System.Windows.Forms.Button bttn_mod;
        private System.Windows.Forms.Button bttn_clear;
        private System.Windows.Forms.Button bttn_clearEvery;
        private System.Windows.Forms.Button bttn_0;
        private System.Windows.Forms.RichTextBox rtb_ans;
        private System.Windows.Forms.Button bttn_recalFast;
        private System.Windows.Forms.Button bttn_memStoreFast;
        private System.Windows.Forms.TextBox txt_memPrev;
        private System.Windows.Forms.Button bttn_clearMemFast;
    }
}

