namespace MyFirstWindowsFormsApp
{
    partial class HoudiniForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.houdiniPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.houdiniPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(86, 291);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // houdiniPictureBox
            // 
            this.houdiniPictureBox.Location = new System.Drawing.Point(31, 28);
            this.houdiniPictureBox.Name = "houdiniPictureBox";
            this.houdiniPictureBox.Size = new System.Drawing.Size(180, 228);
            this.houdiniPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.houdiniPictureBox.TabIndex = 1;
            this.houdiniPictureBox.TabStop = false;
            // 
            // HoudiniForm
            // 
            this.ClientSize = new System.Drawing.Size(235, 336);
            this.Controls.Add(this.houdiniPictureBox);
            this.Controls.Add(this.exitButton);
            this.Name = "HoudiniForm";
            this.Text = "Houdini";
            this.Load += new System.EventHandler(this.HoudiniForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.houdiniPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox houdiniPictureBox;
    }
}

