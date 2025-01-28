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
            this.components = new System.ComponentModel.Container();
            this.bttnClose = new System.Windows.Forms.Button();
            this.tmr_ConfirmClose = new System.Windows.Forms.Timer(this.components);
            this.txt_debug = new System.Windows.Forms.TextBox();
            this.bttn_1 = new System.Windows.Forms.Button();
            this.bttn_2 = new System.Windows.Forms.Button();
            this.bttn_3 = new System.Windows.Forms.Button();
            this.bttn_6 = new System.Windows.Forms.Button();
            this.bttn_5 = new System.Windows.Forms.Button();
            this.bttn_4 = new System.Windows.Forms.Button();
            this.bttn_9 = new System.Windows.Forms.Button();
            this.bttn_8 = new System.Windows.Forms.Button();
            this.bttn_7 = new System.Windows.Forms.Button();
            this.bttn_sub = new System.Windows.Forms.Button();
            this.bttn_add = new System.Windows.Forms.Button();
            this.bttn_equal = new System.Windows.Forms.Button();
            this.bttn_mult = new System.Windows.Forms.Button();
            this.bttn_div = new System.Windows.Forms.Button();
            this.bttn_mod = new System.Windows.Forms.Button();
            this.bttn_clear = new System.Windows.Forms.Button();
            this.bttn_clearAll = new System.Windows.Forms.Button();
            this.rtb_ans = new System.Windows.Forms.RichTextBox();
            this.bttn_recalFast = new System.Windows.Forms.Button();
            this.bttn_memStoreFast = new System.Windows.Forms.Button();
            this.txt_memFastPrev = new System.Windows.Forms.TextBox();
            this.bttn_clearMemFast = new System.Windows.Forms.Button();
            this.lst_memFull = new System.Windows.Forms.ListBox();
            this.bttn_0 = new System.Windows.Forms.Button();
            this.bttn_recalFull = new System.Windows.Forms.Button();
            this.txt_previewFull = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnClose
            // 
            this.bttnClose.BackColor = System.Drawing.Color.Red;
            this.bttnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnClose.FlatAppearance.BorderSize = 0;
            this.bttnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClose.ForeColor = System.Drawing.Color.Black;
            this.bttnClose.Location = new System.Drawing.Point(1, 1);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(85, 43);
            this.bttnClose.TabIndex = 0;
            this.bttnClose.Text = "Close";
            this.bttnClose.UseVisualStyleBackColor = false;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // tmr_ConfirmClose
            // 
            this.tmr_ConfirmClose.Interval = 2500;
            this.tmr_ConfirmClose.Tick += new System.EventHandler(this.tmr_ConfirmClose_Tick);
            // 
            // txt_debug
            // 
            this.txt_debug.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_debug.Location = new System.Drawing.Point(913, 1);
            this.txt_debug.Multiline = true;
            this.txt_debug.Name = "txt_debug";
            this.txt_debug.ReadOnly = true;
            this.txt_debug.Size = new System.Drawing.Size(200, 203);
            this.txt_debug.TabIndex = 1;
            this.txt_debug.TabStop = false;
            this.txt_debug.Visible = false;
            this.txt_debug.TextChanged += new System.EventHandler(this.txt_debug_TextChanged);
            // 
            // bttn_1
            // 
            this.bttn_1.Location = new System.Drawing.Point(149, 249);
            this.bttn_1.Name = "bttn_1";
            this.bttn_1.Size = new System.Drawing.Size(75, 23);
            this.bttn_1.TabIndex = 2;
            this.bttn_1.Text = "1";
            this.bttn_1.UseVisualStyleBackColor = true;
            this.bttn_1.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // bttn_2
            // 
            this.bttn_2.Location = new System.Drawing.Point(230, 249);
            this.bttn_2.Name = "bttn_2";
            this.bttn_2.Size = new System.Drawing.Size(75, 23);
            this.bttn_2.TabIndex = 3;
            this.bttn_2.Text = "2";
            this.bttn_2.UseVisualStyleBackColor = true;
            this.bttn_2.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // bttn_3
            // 
            this.bttn_3.Location = new System.Drawing.Point(311, 249);
            this.bttn_3.Name = "bttn_3";
            this.bttn_3.Size = new System.Drawing.Size(75, 23);
            this.bttn_3.TabIndex = 4;
            this.bttn_3.Text = "3";
            this.bttn_3.UseVisualStyleBackColor = true;
            this.bttn_3.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // bttn_6
            // 
            this.bttn_6.Location = new System.Drawing.Point(311, 220);
            this.bttn_6.Name = "bttn_6";
            this.bttn_6.Size = new System.Drawing.Size(75, 23);
            this.bttn_6.TabIndex = 7;
            this.bttn_6.Text = "6";
            this.bttn_6.UseVisualStyleBackColor = true;
            this.bttn_6.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // bttn_5
            // 
            this.bttn_5.Location = new System.Drawing.Point(230, 220);
            this.bttn_5.Name = "bttn_5";
            this.bttn_5.Size = new System.Drawing.Size(75, 23);
            this.bttn_5.TabIndex = 6;
            this.bttn_5.Text = "5";
            this.bttn_5.UseVisualStyleBackColor = true;
            this.bttn_5.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // bttn_4
            // 
            this.bttn_4.Location = new System.Drawing.Point(149, 220);
            this.bttn_4.Name = "bttn_4";
            this.bttn_4.Size = new System.Drawing.Size(75, 23);
            this.bttn_4.TabIndex = 5;
            this.bttn_4.Text = "4";
            this.bttn_4.UseVisualStyleBackColor = true;
            this.bttn_4.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // bttn_9
            // 
            this.bttn_9.Location = new System.Drawing.Point(311, 191);
            this.bttn_9.Name = "bttn_9";
            this.bttn_9.Size = new System.Drawing.Size(75, 23);
            this.bttn_9.TabIndex = 10;
            this.bttn_9.Text = "9";
            this.bttn_9.UseVisualStyleBackColor = true;
            this.bttn_9.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // bttn_8
            // 
            this.bttn_8.Location = new System.Drawing.Point(230, 191);
            this.bttn_8.Name = "bttn_8";
            this.bttn_8.Size = new System.Drawing.Size(75, 23);
            this.bttn_8.TabIndex = 9;
            this.bttn_8.Text = "8";
            this.bttn_8.UseVisualStyleBackColor = true;
            this.bttn_8.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // bttn_7
            // 
            this.bttn_7.Location = new System.Drawing.Point(149, 191);
            this.bttn_7.Name = "bttn_7";
            this.bttn_7.Size = new System.Drawing.Size(75, 23);
            this.bttn_7.TabIndex = 8;
            this.bttn_7.Text = "7";
            this.bttn_7.UseVisualStyleBackColor = true;
            this.bttn_7.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // bttn_sub
            // 
            this.bttn_sub.Location = new System.Drawing.Point(392, 220);
            this.bttn_sub.Name = "bttn_sub";
            this.bttn_sub.Size = new System.Drawing.Size(75, 23);
            this.bttn_sub.TabIndex = 13;
            this.bttn_sub.Text = "-";
            this.bttn_sub.UseVisualStyleBackColor = false;
            this.bttn_sub.Click += new System.EventHandler(this.op_Click);
            // 
            // bttn_add
            // 
            this.bttn_add.Location = new System.Drawing.Point(392, 191);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(75, 23);
            this.bttn_add.TabIndex = 12;
            this.bttn_add.Text = "+";
            this.bttn_add.UseVisualStyleBackColor = false;
            this.bttn_add.Click += new System.EventHandler(this.op_Click);
            // 
            // bttn_equal
            // 
            this.bttn_equal.Location = new System.Drawing.Point(311, 278);
            this.bttn_equal.Name = "bttn_equal";
            this.bttn_equal.Size = new System.Drawing.Size(75, 23);
            this.bttn_equal.TabIndex = 11;
            this.bttn_equal.Text = "=";
            this.bttn_equal.UseVisualStyleBackColor = false;
            this.bttn_equal.Click += new System.EventHandler(this.bttn_equal_Click);
            // 
            // bttn_mult
            // 
            this.bttn_mult.Location = new System.Drawing.Point(392, 249);
            this.bttn_mult.Name = "bttn_mult";
            this.bttn_mult.Size = new System.Drawing.Size(75, 23);
            this.bttn_mult.TabIndex = 14;
            this.bttn_mult.Text = "*";
            this.bttn_mult.UseVisualStyleBackColor = false;
            this.bttn_mult.Click += new System.EventHandler(this.op_Click);
            // 
            // bttn_div
            // 
            this.bttn_div.Location = new System.Drawing.Point(392, 278);
            this.bttn_div.Name = "bttn_div";
            this.bttn_div.Size = new System.Drawing.Size(75, 23);
            this.bttn_div.TabIndex = 15;
            this.bttn_div.Text = "/";
            this.bttn_div.UseVisualStyleBackColor = false;
            this.bttn_div.Click += new System.EventHandler(this.op_Click);
            // 
            // bttn_mod
            // 
            this.bttn_mod.Location = new System.Drawing.Point(392, 162);
            this.bttn_mod.Name = "bttn_mod";
            this.bttn_mod.Size = new System.Drawing.Size(75, 23);
            this.bttn_mod.TabIndex = 16;
            this.bttn_mod.Text = "%";
            this.bttn_mod.UseVisualStyleBackColor = false;
            this.bttn_mod.Click += new System.EventHandler(this.op_Click);
            // 
            // bttn_clear
            // 
            this.bttn_clear.Location = new System.Drawing.Point(149, 162);
            this.bttn_clear.Name = "bttn_clear";
            this.bttn_clear.Size = new System.Drawing.Size(75, 23);
            this.bttn_clear.TabIndex = 17;
            this.bttn_clear.Text = "Clear";
            this.bttn_clear.UseVisualStyleBackColor = false;
            this.bttn_clear.Click += new System.EventHandler(this.clear_click);
            // 
            // bttn_clearAll
            // 
            this.bttn_clearAll.Location = new System.Drawing.Point(230, 162);
            this.bttn_clearAll.Name = "bttn_clearAll";
            this.bttn_clearAll.Size = new System.Drawing.Size(156, 23);
            this.bttn_clearAll.TabIndex = 18;
            this.bttn_clearAll.Text = "Clear All";
            this.bttn_clearAll.UseVisualStyleBackColor = false;
            this.bttn_clearAll.Click += new System.EventHandler(this.clear_click);
            // 
            // rtb_ans
            // 
            this.rtb_ans.Location = new System.Drawing.Point(149, 135);
            this.rtb_ans.Name = "rtb_ans";
            this.rtb_ans.Size = new System.Drawing.Size(318, 21);
            this.rtb_ans.TabIndex = 20;
            this.rtb_ans.Text = "0";
            this.rtb_ans.TextChanged += new System.EventHandler(this.rtb_ans_TextChanged);
            // 
            // bttn_recalFast
            // 
            this.bttn_recalFast.Location = new System.Drawing.Point(149, 307);
            this.bttn_recalFast.Name = "bttn_recalFast";
            this.bttn_recalFast.Size = new System.Drawing.Size(156, 23);
            this.bttn_recalFast.TabIndex = 21;
            this.bttn_recalFast.Text = "Recall Rapid Memory";
            this.bttn_recalFast.UseVisualStyleBackColor = true;
            this.bttn_recalFast.Visible = false;
            this.bttn_recalFast.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // bttn_memStoreFast
            // 
            this.bttn_memStoreFast.Location = new System.Drawing.Point(311, 307);
            this.bttn_memStoreFast.Name = "bttn_memStoreFast";
            this.bttn_memStoreFast.Size = new System.Drawing.Size(156, 23);
            this.bttn_memStoreFast.TabIndex = 22;
            this.bttn_memStoreFast.Text = "Store Rapid Memory";
            this.bttn_memStoreFast.UseVisualStyleBackColor = true;
            this.bttn_memStoreFast.Visible = false;
            this.bttn_memStoreFast.Click += new System.EventHandler(this.bttn_memStoreFast_Click);
            // 
            // txt_memFastPrev
            // 
            this.txt_memFastPrev.Location = new System.Drawing.Point(149, 109);
            this.txt_memFastPrev.Name = "txt_memFastPrev";
            this.txt_memFastPrev.ReadOnly = true;
            this.txt_memFastPrev.Size = new System.Drawing.Size(75, 20);
            this.txt_memFastPrev.TabIndex = 0;
            this.txt_memFastPrev.TabStop = false;
            this.txt_memFastPrev.Visible = false;
            this.txt_memFastPrev.WordWrap = false;
            // 
            // bttn_clearMemFast
            // 
            this.bttn_clearMemFast.Location = new System.Drawing.Point(19, 162);
            this.bttn_clearMemFast.Name = "bttn_clearMemFast";
            this.bttn_clearMemFast.Size = new System.Drawing.Size(124, 23);
            this.bttn_clearMemFast.TabIndex = 23;
            this.bttn_clearMemFast.Text = "Clear Rapid Memory";
            this.bttn_clearMemFast.UseVisualStyleBackColor = false;
            this.bttn_clearMemFast.Visible = false;
            this.bttn_clearMemFast.Click += new System.EventHandler(this.bttn_clearMemFast_Click);
            // 
            // lst_memFull
            // 
            this.lst_memFull.FormattingEnabled = true;
            this.lst_memFull.Location = new System.Drawing.Point(607, 119);
            this.lst_memFull.Name = "lst_memFull";
            this.lst_memFull.Size = new System.Drawing.Size(120, 95);
            this.lst_memFull.TabIndex = 24;
            this.lst_memFull.SelectedIndexChanged += new System.EventHandler(this.lst_memFull_SelectedIndexChanged);
            // 
            // bttn_0
            // 
            this.bttn_0.Location = new System.Drawing.Point(230, 278);
            this.bttn_0.Name = "bttn_0";
            this.bttn_0.Size = new System.Drawing.Size(75, 23);
            this.bttn_0.TabIndex = 19;
            this.bttn_0.Text = "0";
            this.bttn_0.UseVisualStyleBackColor = true;
            this.bttn_0.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // bttn_recalFull
            // 
            this.bttn_recalFull.Location = new System.Drawing.Point(526, 119);
            this.bttn_recalFull.Name = "bttn_recalFull";
            this.bttn_recalFull.Size = new System.Drawing.Size(75, 23);
            this.bttn_recalFull.TabIndex = 25;
            this.bttn_recalFull.Text = "Recall";
            this.bttn_recalFull.UseVisualStyleBackColor = true;
            this.bttn_recalFull.Click += new System.EventHandler(this.bttn_num_Click);
            // 
            // txt_previewFull
            // 
            this.txt_previewFull.Location = new System.Drawing.Point(607, 91);
            this.txt_previewFull.Name = "txt_previewFull";
            this.txt_previewFull.Size = new System.Drawing.Size(110, 20);
            this.txt_previewFull.TabIndex = 26;
            this.txt_previewFull.TextChanged += new System.EventHandler(this.txt_previewFull_TextChanged);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.bttnClose;
            this.ClientSize = new System.Drawing.Size(1113, 489);
            this.ControlBox = false;
            this.Controls.Add(this.txt_previewFull);
            this.Controls.Add(this.bttn_recalFull);
            this.Controls.Add(this.lst_memFull);
            this.Controls.Add(this.bttn_clearMemFast);
            this.Controls.Add(this.txt_memFastPrev);
            this.Controls.Add(this.bttn_memStoreFast);
            this.Controls.Add(this.bttn_recalFast);
            this.Controls.Add(this.rtb_ans);
            this.Controls.Add(this.bttn_0);
            this.Controls.Add(this.bttn_clearAll);
            this.Controls.Add(this.bttn_clear);
            this.Controls.Add(this.bttn_mod);
            this.Controls.Add(this.bttn_div);
            this.Controls.Add(this.bttn_mult);
            this.Controls.Add(this.bttn_sub);
            this.Controls.Add(this.bttn_add);
            this.Controls.Add(this.bttn_equal);
            this.Controls.Add(this.bttn_9);
            this.Controls.Add(this.bttn_8);
            this.Controls.Add(this.bttn_7);
            this.Controls.Add(this.bttn_6);
            this.Controls.Add(this.bttn_5);
            this.Controls.Add(this.bttn_4);
            this.Controls.Add(this.bttn_3);
            this.Controls.Add(this.bttn_2);
            this.Controls.Add(this.bttn_1);
            this.Controls.Add(this.txt_debug);
            this.Controls.Add(this.bttnClose);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalc";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Inator";
            this.Load += new System.EventHandler(this.frmCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button bttn_clearAll;
        private System.Windows.Forms.RichTextBox rtb_ans;
        private System.Windows.Forms.Button bttn_recalFast;
        private System.Windows.Forms.Button bttn_memStoreFast;
        private System.Windows.Forms.TextBox txt_memFastPrev;
        private System.Windows.Forms.Button bttn_clearMemFast;
        private System.Windows.Forms.ListBox lst_memFull;
        private System.Windows.Forms.Button bttn_0;
        private System.Windows.Forms.Button bttn_recalFull;
        private System.Windows.Forms.TextBox txt_previewFull;
    }
}

