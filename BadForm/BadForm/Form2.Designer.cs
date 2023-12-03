namespace BadForm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.penguinImage = new System.Windows.Forms.PictureBox();
            this.penguinMove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.penguinImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penguinMove)).BeginInit();
            this.SuspendLayout();
            // 
            // penguinImage
            // 
            this.penguinImage.Image = ((System.Drawing.Image)(resources.GetObject("penguinImage.Image")));
            this.penguinImage.Location = new System.Drawing.Point(-401, 12);
            this.penguinImage.Name = "penguinImage";
            this.penguinImage.Size = new System.Drawing.Size(1544, 753);
            this.penguinImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.penguinImage.TabIndex = 9;
            this.penguinImage.TabStop = false;
            // 
            // penguinMove
            // 
            this.penguinMove.BackColor = System.Drawing.Color.Transparent;
            this.penguinMove.Image = ((System.Drawing.Image)(resources.GetObject("penguinMove.Image")));
            this.penguinMove.InitialImage = ((System.Drawing.Image)(resources.GetObject("penguinMove.InitialImage")));
            this.penguinMove.Location = new System.Drawing.Point(94, 81);
            this.penguinMove.Name = "penguinMove";
            this.penguinMove.Size = new System.Drawing.Size(188, 194);
            this.penguinMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.penguinMove.TabIndex = 10;
            this.penguinMove.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.penguinMove);
            this.Controls.Add(this.penguinImage);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.penguinImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penguinMove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox penguinImage;
        private System.Windows.Forms.PictureBox penguinMove;
    }
}