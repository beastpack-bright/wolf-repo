namespace GifFinder
{
    partial class SearchForm
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
            this.SearchTermTextBox = new System.Windows.Forms.TextBox();
            this.maxItemsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchTermTextBox
            // 
            this.SearchTermTextBox.Location = new System.Drawing.Point(221, 52);
            this.SearchTermTextBox.Name = "SearchTermTextBox";
            this.SearchTermTextBox.Size = new System.Drawing.Size(143, 38);
            this.SearchTermTextBox.TabIndex = 0;
            // 
            // maxItemsTextBox
            // 
            this.maxItemsTextBox.Location = new System.Drawing.Point(221, 122);
            this.maxItemsTextBox.Name = "maxItemsTextBox";
            this.maxItemsTextBox.Size = new System.Drawing.Size(143, 38);
            this.maxItemsTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search term: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max items:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(121, 190);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(143, 52);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(270, 194);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 48);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxItemsTextBox);
            this.Controls.Add(this.SearchTermTextBox);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTermTextBox;
        private System.Windows.Forms.TextBox maxItemsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}