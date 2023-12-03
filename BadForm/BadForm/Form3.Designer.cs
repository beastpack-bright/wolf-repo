namespace BadForm
{
    partial class Form3
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
            this.dinoBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // dinoBrowser
            // 
            this.dinoBrowser.Location = new System.Drawing.Point(589, 333);
            this.dinoBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.dinoBrowser.Name = "dinoBrowser";
            this.dinoBrowser.Size = new System.Drawing.Size(317, 325);
            this.dinoBrowser.TabIndex = 0;
            this.dinoBrowser.Url = new System.Uri("https://en.wikipedia.org/wiki/Dinosaur", System.UriKind.Absolute);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(1551, 1072);
            this.Controls.Add(this.dinoBrowser);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser dinoBrowser;
    }
}