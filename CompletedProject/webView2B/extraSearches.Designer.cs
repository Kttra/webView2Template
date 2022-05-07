
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
            this.extraTextbox = new System.Windows.Forms.TextBox();
            this.menu2Confirm = new System.Windows.Forms.Button();
            this.checkBoxM = new System.Windows.Forms.CheckBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.checkBoxE = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // menu2Label
            // 
            this.menu2Label.Font = new System.Drawing.Font("Cooper Black", 12.75F);
            this.menu2Label.Location = new System.Drawing.Point(3, -7);
            this.menu2Label.Name = "menu2Label";
            this.menu2Label.Size = new System.Drawing.Size(331, 77);
            this.menu2Label.TabIndex = 0;
            this.menu2Label.Text = "How many extra searches would you like to do?";
            this.menu2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // extraTextbox
            // 
            this.extraTextbox.Location = new System.Drawing.Point(110, 59);
            this.extraTextbox.Name = "extraTextbox";
            this.extraTextbox.Size = new System.Drawing.Size(73, 20);
            this.extraTextbox.TabIndex = 1;
            this.extraTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.extraTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.extraTextbox_KeyDown);
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
            // checkBoxM
            // 
            this.checkBoxM.AutoSize = true;
            this.checkBoxM.Location = new System.Drawing.Point(223, 50);
            this.checkBoxM.Name = "checkBoxM";
            this.checkBoxM.Size = new System.Drawing.Size(57, 17);
            this.checkBoxM.TabIndex = 3;
            this.checkBoxM.Text = "Mobile";
            this.checkBoxM.UseVisualStyleBackColor = true;
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(223, 73);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(66, 17);
            this.checkBoxD.TabIndex = 4;
            this.checkBoxD.Text = "Desktop";
            this.checkBoxD.UseVisualStyleBackColor = true;
            // 
            // checkBoxE
            // 
            this.checkBoxE.AutoSize = true;
            this.checkBoxE.Location = new System.Drawing.Point(223, 96);
            this.checkBoxE.Name = "checkBoxE";
            this.checkBoxE.Size = new System.Drawing.Size(51, 17);
            this.checkBoxE.TabIndex = 5;
            this.checkBoxE.Text = "Edge";
            this.checkBoxE.UseVisualStyleBackColor = true;
            // 
            // extraMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 117);
            this.Controls.Add(this.checkBoxE);
            this.Controls.Add(this.checkBoxD);
            this.Controls.Add(this.checkBoxM);
            this.Controls.Add(this.menu2Confirm);
            this.Controls.Add(this.extraTextbox);
            this.Controls.Add(this.menu2Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "extraMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu2Label;
        private System.Windows.Forms.TextBox extraTextbox;
        private System.Windows.Forms.Button menu2Confirm;
        private System.Windows.Forms.CheckBox checkBoxM;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.CheckBox checkBoxE;
    }
}