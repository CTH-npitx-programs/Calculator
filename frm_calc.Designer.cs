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
            this.txt_debug.Location = new System.Drawing.Point(846, 1);
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
            // 
            // bttn_2
            // 
            this.bttn_2.Location = new System.Drawing.Point(230, 249);
            this.bttn_2.Name = "bttn_2";
            this.bttn_2.Size = new System.Drawing.Size(75, 23);
            this.bttn_2.TabIndex = 3;
            this.bttn_2.Text = "2";
            this.bttn_2.UseVisualStyleBackColor = true;
            // 
            // bttn_3
            // 
            this.bttn_3.Location = new System.Drawing.Point(311, 249);
            this.bttn_3.Name = "bttn_3";
            this.bttn_3.Size = new System.Drawing.Size(75, 23);
            this.bttn_3.TabIndex = 4;
            this.bttn_3.Text = "3";
            this.bttn_3.UseVisualStyleBackColor = true;
            // 
            // bttn_6
            // 
            this.bttn_6.Location = new System.Drawing.Point(311, 220);
            this.bttn_6.Name = "bttn_6";
            this.bttn_6.Size = new System.Drawing.Size(75, 23);
            this.bttn_6.TabIndex = 7;
            this.bttn_6.Text = "6";
            this.bttn_6.UseVisualStyleBackColor = true;
            // 
            // bttn_5
            // 
            this.bttn_5.Location = new System.Drawing.Point(230, 220);
            this.bttn_5.Name = "bttn_5";
            this.bttn_5.Size = new System.Drawing.Size(75, 23);
            this.bttn_5.TabIndex = 6;
            this.bttn_5.Text = "5";
            this.bttn_5.UseVisualStyleBackColor = true;
            // 
            // bttn_4
            // 
            this.bttn_4.Location = new System.Drawing.Point(149, 220);
            this.bttn_4.Name = "bttn_4";
            this.bttn_4.Size = new System.Drawing.Size(75, 23);
            this.bttn_4.TabIndex = 5;
            this.bttn_4.Text = "4";
            this.bttn_4.UseVisualStyleBackColor = true;
            // 
            // bttn_9
            // 
            this.bttn_9.Location = new System.Drawing.Point(311, 191);
            this.bttn_9.Name = "bttn_9";
            this.bttn_9.Size = new System.Drawing.Size(75, 23);
            this.bttn_9.TabIndex = 10;
            this.bttn_9.Text = "9";
            this.bttn_9.UseVisualStyleBackColor = false;
            // 
            // bttn_8
            // 
            this.bttn_8.Location = new System.Drawing.Point(230, 191);
            this.bttn_8.Name = "bttn_8";
            this.bttn_8.Size = new System.Drawing.Size(75, 23);
            this.bttn_8.TabIndex = 9;
            this.bttn_8.Text = "8";
            this.bttn_8.UseVisualStyleBackColor = false;
            // 
            // bttn_7
            // 
            this.bttn_7.Location = new System.Drawing.Point(149, 191);
            this.bttn_7.Name = "bttn_7";
            this.bttn_7.Size = new System.Drawing.Size(75, 23);
            this.bttn_7.TabIndex = 8;
            this.bttn_7.Text = "7";
            this.bttn_7.UseVisualStyleBackColor = false;
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.bttnClose;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.ControlBox = false;
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
    }
}

