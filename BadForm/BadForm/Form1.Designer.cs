namespace BadForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generateDino = new System.Windows.Forms.Button();
            this.dinosaurImage = new System.Windows.Forms.PictureBox();
            this.codeLanguage = new System.Windows.Forms.GroupBox();
            this.htmlradioButton = new System.Windows.Forms.RadioButton();
            this.pythonradioButton = new System.Windows.Forms.RadioButton();
            this.javascriptradioButton = new System.Windows.Forms.RadioButton();
            this.csharpRadioButton = new System.Windows.Forms.RadioButton();
            this.dinosaurText = new System.Windows.Forms.Label();
            this.goodCoder = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.specialButton = new System.Windows.Forms.Button();
            this.selectList = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.penguinImage = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dinosaurImage)).BeginInit();
            this.codeLanguage.SuspendLayout();
            this.goodCoder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penguinImage)).BeginInit();
            this.SuspendLayout();
            // 
            // generateDino
            // 
            this.generateDino.Location = new System.Drawing.Point(74, 48);
            this.generateDino.Name = "generateDino";
            this.generateDino.Size = new System.Drawing.Size(291, 113);
            this.generateDino.TabIndex = 0;
            this.generateDino.Text = "Generate Dinosaur";
            this.generateDino.UseVisualStyleBackColor = true;
            this.generateDino.Click += new System.EventHandler(this.generateDino_Click);
            // 
            // dinosaurImage
            // 
            this.dinosaurImage.Location = new System.Drawing.Point(1033, 12);
            this.dinosaurImage.Name = "dinosaurImage";
            this.dinosaurImage.Size = new System.Drawing.Size(782, 634);
            this.dinosaurImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dinosaurImage.TabIndex = 1;
            this.dinosaurImage.TabStop = false;
            // 
            // codeLanguage
            // 
            this.codeLanguage.Controls.Add(this.htmlradioButton);
            this.codeLanguage.Controls.Add(this.pythonradioButton);
            this.codeLanguage.Controls.Add(this.javascriptradioButton);
            this.codeLanguage.Controls.Add(this.csharpRadioButton);
            this.codeLanguage.Location = new System.Drawing.Point(69, 368);
            this.codeLanguage.Name = "codeLanguage";
            this.codeLanguage.Size = new System.Drawing.Size(296, 353);
            this.codeLanguage.TabIndex = 2;
            this.codeLanguage.TabStop = false;
            this.codeLanguage.Text = "Coding Language";
            this.codeLanguage.Enter += new System.EventHandler(this.codeLanguage_Enter);
            // 
            // htmlradioButton
            // 
            this.htmlradioButton.AutoSize = true;
            this.htmlradioButton.Location = new System.Drawing.Point(7, 275);
            this.htmlradioButton.Name = "htmlradioButton";
            this.htmlradioButton.Size = new System.Drawing.Size(127, 36);
            this.htmlradioButton.TabIndex = 3;
            this.htmlradioButton.TabStop = true;
            this.htmlradioButton.Text = "HTML";
            this.htmlradioButton.UseVisualStyleBackColor = true;
            // 
            // pythonradioButton
            // 
            this.pythonradioButton.AutoSize = true;
            this.pythonradioButton.Location = new System.Drawing.Point(7, 209);
            this.pythonradioButton.Name = "pythonradioButton";
            this.pythonradioButton.Size = new System.Drawing.Size(140, 36);
            this.pythonradioButton.TabIndex = 2;
            this.pythonradioButton.TabStop = true;
            this.pythonradioButton.Text = "Python";
            this.pythonradioButton.UseVisualStyleBackColor = true;
            // 
            // javascriptradioButton
            // 
            this.javascriptradioButton.AutoSize = true;
            this.javascriptradioButton.Location = new System.Drawing.Point(7, 134);
            this.javascriptradioButton.Name = "javascriptradioButton";
            this.javascriptradioButton.Size = new System.Drawing.Size(179, 36);
            this.javascriptradioButton.TabIndex = 1;
            this.javascriptradioButton.TabStop = true;
            this.javascriptradioButton.Text = "Javascript";
            this.javascriptradioButton.UseVisualStyleBackColor = true;
            // 
            // csharpRadioButton
            // 
            this.csharpRadioButton.AutoSize = true;
            this.csharpRadioButton.Location = new System.Drawing.Point(7, 60);
            this.csharpRadioButton.Name = "csharpRadioButton";
            this.csharpRadioButton.Size = new System.Drawing.Size(87, 36);
            this.csharpRadioButton.TabIndex = 0;
            this.csharpRadioButton.TabStop = true;
            this.csharpRadioButton.Text = "C#";
            this.csharpRadioButton.UseVisualStyleBackColor = true;
            this.csharpRadioButton.CheckedChanged += new System.EventHandler(this.csharpRadioButton_CheckedChanged);
            // 
            // dinosaurText
            // 
            this.dinosaurText.AutoSize = true;
            this.dinosaurText.Location = new System.Drawing.Point(1033, 670);
            this.dinosaurText.Name = "dinosaurText";
            this.dinosaurText.Size = new System.Drawing.Size(0, 32);
            this.dinosaurText.TabIndex = 3;
            // 
            // goodCoder
            // 
            this.goodCoder.Controls.Add(this.noRadioButton);
            this.goodCoder.Controls.Add(this.yesRadioButton);
            this.goodCoder.Location = new System.Drawing.Point(492, 378);
            this.goodCoder.Name = "goodCoder";
            this.goodCoder.Size = new System.Drawing.Size(269, 161);
            this.goodCoder.TabIndex = 4;
            this.goodCoder.TabStop = false;
            this.goodCoder.Text = "Good coder?";
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(20, 119);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(87, 36);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(20, 50);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(100, 36);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // specialButton
            // 
            this.specialButton.Location = new System.Drawing.Point(0, 800);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(163, 51);
            this.specialButton.TabIndex = 5;
            this.specialButton.Text = "secret";
            this.specialButton.UseVisualStyleBackColor = true;
            this.specialButton.Click += new System.EventHandler(this.specialButton_Click_1);
            // 
            // selectList
            // 
            this.selectList.FormattingEnabled = true;
            this.selectList.ItemHeight = 31;
            this.selectList.Location = new System.Drawing.Point(644, 577);
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(268, 345);
            this.selectList.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.progressBar1.ForeColor = System.Drawing.Color.Fuchsia;
            this.progressBar1.Location = new System.Drawing.Point(0, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1856, 40);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // penguinImage
            // 
            this.penguinImage.Image = ((System.Drawing.Image)(resources.GetObject("penguinImage.Image")));
            this.penguinImage.Location = new System.Drawing.Point(1606, 824);
            this.penguinImage.Name = "penguinImage";
            this.penguinImage.Size = new System.Drawing.Size(2343, 1218);
            this.penguinImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.penguinImage.TabIndex = 8;
            this.penguinImage.TabStop = false;
            this.penguinImage.Visible = false;
            this.penguinImage.Click += new System.EventHandler(this.penguinImage_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1853, 1081);
            this.Controls.Add(this.penguinImage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.selectList);
            this.Controls.Add(this.specialButton);
            this.Controls.Add(this.goodCoder);
            this.Controls.Add(this.dinosaurText);
            this.Controls.Add(this.codeLanguage);
            this.Controls.Add(this.dinosaurImage);
            this.Controls.Add(this.generateDino);
            this.Name = "Form1";
            this.Text = "Can Dinosaurs Code?";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dinosaurImage)).EndInit();
            this.codeLanguage.ResumeLayout(false);
            this.codeLanguage.PerformLayout();
            this.goodCoder.ResumeLayout(false);
            this.goodCoder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penguinImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateDino;
        private System.Windows.Forms.PictureBox dinosaurImage;
        private System.Windows.Forms.GroupBox codeLanguage;
        private System.Windows.Forms.RadioButton javascriptradioButton;
        private System.Windows.Forms.RadioButton csharpRadioButton;
        private System.Windows.Forms.Label dinosaurText;
        private System.Windows.Forms.GroupBox goodCoder;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.RadioButton htmlradioButton;
        private System.Windows.Forms.RadioButton pythonradioButton;
        private System.Windows.Forms.Button specialButton;
        private System.Windows.Forms.ListBox selectList;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox penguinImage;
        private System.Windows.Forms.Timer timer2;
    }
}

