
namespace webView2B
{
    partial class Form1
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
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.requestButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressLabel2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressLabel3 = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(1, 64);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(802, 388);
            this.webView.Source = new System.Uri("https://www.bing.com", System.UriKind.Absolute);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // addressBar
            // 
            this.addressBar.Location = new System.Drawing.Point(311, 0);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(425, 20);
            this.addressBar.TabIndex = 1;
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(742, 0);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(61, 20);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // requestButton
            // 
            this.requestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.requestButton.Location = new System.Drawing.Point(742, 26);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(61, 23);
            this.requestButton.TabIndex = 3;
            this.requestButton.Text = "Request";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 18);
            this.progressBar1.Maximum = 40;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(82, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // progressLabel1
            // 
            this.progressLabel1.AutoSize = true;
            this.progressLabel1.Location = new System.Drawing.Point(16, 45);
            this.progressLabel1.Name = "progressLabel1";
            this.progressLabel1.Size = new System.Drawing.Size(71, 13);
            this.progressLabel1.TabIndex = 6;
            this.progressLabel1.Text = "Progress: 0/0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // progressLabel2
            // 
            this.progressLabel2.AutoSize = true;
            this.progressLabel2.Location = new System.Drawing.Point(107, 44);
            this.progressLabel2.Name = "progressLabel2";
            this.progressLabel2.Size = new System.Drawing.Size(71, 13);
            this.progressLabel2.TabIndex = 8;
            this.progressLabel2.Text = "Progress: 0/0";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(102, 18);
            this.progressBar2.Maximum = 40;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(83, 23);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 9;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(192, 18);
            this.progressBar3.Maximum = 40;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(77, 23);
            this.progressBar3.Step = 1;
            this.progressBar3.TabIndex = 10;
            this.progressBar3.Click += new System.EventHandler(this.progressBar3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // progressLabel3
            // 
            this.progressLabel3.AutoSize = true;
            this.progressLabel3.Location = new System.Drawing.Point(195, 45);
            this.progressLabel3.Name = "progressLabel3";
            this.progressLabel3.Size = new System.Drawing.Size(71, 13);
            this.progressLabel3.TabIndex = 12;
            this.progressLabel3.Text = "Progress: 0/0";
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(668, 26);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(61, 23);
            this.loadButton.TabIndex = 13;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Location = new System.Drawing.Point(593, 26);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(61, 23);
            this.runButton.TabIndex = 14;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Location = new System.Drawing.Point(518, 26);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(61, 23);
            this.stopButton.TabIndex = 15;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.progressLabel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.requestButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.webView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label progressLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label progressLabel2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label progressLabel3;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button stopButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

