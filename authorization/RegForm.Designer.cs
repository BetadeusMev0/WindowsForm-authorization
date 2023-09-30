namespace authorization
{
    partial class RegForm
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
            this.textBoxLogReg = new System.Windows.Forms.TextBox();
            this.textBoxPassReg = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogReg
            // 
            this.textBoxLogReg.Location = new System.Drawing.Point(12, 43);
            this.textBoxLogReg.Name = "textBoxLogReg";
            this.textBoxLogReg.Size = new System.Drawing.Size(218, 23);
            this.textBoxLogReg.TabIndex = 0;
            // 
            // textBoxPassReg
            // 
            this.textBoxPassReg.Location = new System.Drawing.Point(12, 89);
            this.textBoxPassReg.Name = "textBoxPassReg";
            this.textBoxPassReg.Size = new System.Drawing.Size(218, 23);
            this.textBoxPassReg.TabIndex = 1;
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(84, 118);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(75, 23);
            this.buttonReg.TabIndex = 2;
            this.buttonReg.Text = "sing up";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            this.buttonReg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonReg_MouseDown);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.resultLabel.Location = new System.Drawing.Point(64, 164);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 15);
            this.resultLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxPassReg);
            this.Controls.Add(this.textBoxLogReg);
            this.MaximumSize = new System.Drawing.Size(260, 275);
            this.MinimumSize = new System.Drawing.Size(260, 275);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxLogReg;
        private TextBox textBoxPassReg;
        private Button buttonReg;
        private Label resultLabel;
        private Label label1;
        private Label label2;
    }
}