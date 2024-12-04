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
            this.bttnClose.Location = new System.Drawing.Point(9, 7);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(85, 43);
            this.bttnClose.TabIndex = 0;
            this.bttnClose.TabStop = false;
            this.bttnClose.Text = "Close";
            this.bttnClose.UseVisualStyleBackColor = false;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // tmr_ConfirmClose
            // 
            this.tmr_ConfirmClose.Enabled = true;
            this.tmr_ConfirmClose.Interval = 2500;
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bttnClose);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalc";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Inator";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnClose;
        private System.Windows.Forms.Timer tmr_ConfirmClose;
    }
}

