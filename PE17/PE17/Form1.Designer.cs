namespace PE17
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
            this.startButton = new System.Windows.Forms.Button();
            this.lowendTextBox = new System.Windows.Forms.TextBox();
            this.lowEnd = new System.Windows.Forms.Label();
            this.highendTextBox = new System.Windows.Forms.TextBox();
            this.highEndlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(292, 316);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(156, 71);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // lowendTextBox
            // 
            this.lowendTextBox.Location = new System.Drawing.Point(119, 97);
            this.lowendTextBox.Name = "lowendTextBox";
            this.lowendTextBox.Size = new System.Drawing.Size(100, 38);
            this.lowendTextBox.TabIndex = 1;
            this.lowendTextBox.Text = "1";
            // 
            // lowEnd
            // 
            this.lowEnd.AutoSize = true;
            this.lowEnd.Location = new System.Drawing.Point(113, 51);
            this.lowEnd.Name = "lowEnd";
            this.lowEnd.Size = new System.Drawing.Size(124, 32);
            this.lowEnd.TabIndex = 2;
            this.lowEnd.Text = "Low End";
            this.lowEnd.Click += new System.EventHandler(this.label1_Click);
            // 
            // highendTextBox
            // 
            this.highendTextBox.Location = new System.Drawing.Point(420, 97);
            this.highendTextBox.Name = "highendTextBox";
            this.highendTextBox.Size = new System.Drawing.Size(100, 38);
            this.highendTextBox.TabIndex = 3;
            this.highendTextBox.Text = "100";
            // 
            // highEndlabel
            // 
            this.highEndlabel.AutoSize = true;
            this.highEndlabel.Location = new System.Drawing.Point(414, 51);
            this.highEndlabel.Name = "highEndlabel";
            this.highEndlabel.Size = new System.Drawing.Size(131, 32);
            this.highEndlabel.TabIndex = 4;
            this.highEndlabel.Text = "High End";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highEndlabel);
            this.Controls.Add(this.highendTextBox);
            this.Controls.Add(this.lowEnd);
            this.Controls.Add(this.lowendTextBox);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox lowendTextBox;
        private System.Windows.Forms.Label lowEnd;
        private System.Windows.Forms.TextBox highendTextBox;
        private System.Windows.Forms.Label highEndlabel;
    }
}

