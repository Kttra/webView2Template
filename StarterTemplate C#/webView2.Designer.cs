namespace webView2_Starter_Template
{
    partial class webView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // myWebView
            // 
            this.myWebView.AllowExternalDrop = true;
            this.myWebView.CreationProperties = null;
            this.myWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.myWebView.Location = new System.Drawing.Point(0, 41);
            this.myWebView.Name = "myWebView";
            this.myWebView.Size = new System.Drawing.Size(800, 409);
            this.myWebView.Source = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.myWebView.TabIndex = 0;
            this.myWebView.ZoomFactor = 1D;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(12, 12);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(695, 23);
            this.AddressBox.TabIndex = 1;
            this.AddressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressBox_KeyDown);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(713, 12);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 2;
            this.BtnConfirm.Text = "Go";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // webView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.myWebView);
            this.Name = "webView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebView2 Starter Sample";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.myWebView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 myWebView;
        private TextBox AddressBox;
        private Button BtnConfirm;
    }
}