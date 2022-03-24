
namespace webView2B
{
    partial class extraMenu
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
            this.menu2Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menu2Confirm = new System.Windows.Forms.Button();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxE = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // menu2Label
            // 
            this.menu2Label.Font = new System.Drawing.Font("Cooper Black", 12.75F);
            this.menu2Label.Location = new System.Drawing.Point(3, -7);
            this.menu2Label.Name = "menu2Label";
            this.menu2Label.Size = new System.Drawing.Size(279, 77);
            this.menu2Label.TabIndex = 0;
            this.menu2Label.Text = "How many extra steps would you like to do?";
            this.menu2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 1;
            // 
            // menu2Confirm
            // 
            this.menu2Confirm.Location = new System.Drawing.Point(110, 82);
            this.menu2Confirm.Name = "menu2Confirm";
            this.menu2Confirm.Size = new System.Drawing.Size(75, 23);
            this.menu2Confirm.TabIndex = 2;
            this.menu2Confirm.Text = "Confirm";
            this.menu2Confirm.UseVisualStyleBackColor = true;
            this.menu2Confirm.Click += new System.EventHandler(this.menu2Confirm_Click);
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(223, 50);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(81, 17);
            this.checkBoxB.TabIndex = 3;
            this.checkBoxB.Text = "checkBoxB";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(223, 73);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(81, 17);
            this.checkBoxC.TabIndex = 4;
            this.checkBoxC.Text = "checkBoxC";
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // checkBoxE
            // 
            this.checkBoxE.AutoSize = true;
            this.checkBoxE.Location = new System.Drawing.Point(223, 96);
            this.checkBoxE.Name = "checkBoxE";
            this.checkBoxE.Size = new System.Drawing.Size(81, 17);
            this.checkBoxE.TabIndex = 5;
            this.checkBoxE.Text = "checkBoxE";
            this.checkBoxE.UseVisualStyleBackColor = true;
            // 
            // extraMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 117);
            this.Controls.Add(this.checkBoxE);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.menu2Confirm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menu2Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "extraMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu2Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button menu2Confirm;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxE;
    }
}