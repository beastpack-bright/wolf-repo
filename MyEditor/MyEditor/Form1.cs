using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //Just initializing the components. 
            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem_Click);
            this.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem_Click);
            this.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);

            this.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem_Click);
            this.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem_Click);
            this.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem_Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip_ItemClicked);


            this.Text = "MyEditor"; //Default text. 
        }
        //This creates a new file.
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";
        }
        //This opens an existing file.
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;
                if (openFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.LoadFile(openFileDialog.FileName, richTextBoxStreamType);
                this.Text = "My Editor (" + openFileDialog.FileName + ")";
            }
        }
        //This saves a file.
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = openFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;
                if (saveFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.SaveFile(saveFileDialog.FileName, richTextBoxStreamType);
                this.Text = "My Editor (" + saveFileDialog.FileName + ")";
            }
        }
        //This exits the application. 
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }
        //For the strip on the top that changes the font types.
        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;
            ToolStripButton toolStripButton = null;
            if (e.ClickedItem == this.boldToolStripButton1) //Bold
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton1;
            } else if(e.ClickedItem == this.italicsToolStripButton2) //Italic
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicsToolStripButton2;
            }
            else if (e.ClickedItem == this.underlineToolStripButton) //Underline
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;
            }
            else if (e.ClickedItem == this.colorToolStripButton3) //Color
            {
                if (colorDialog.ShowDialog() == DialogResult.OK) 
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                    colorToolStripButton3.BackColor = colorDialog.Color;
                }
            }
            if (fontStyle != FontStyle.Regular) //Font
            {
                toolStripButton.Checked = !toolStripButton.Checked;
                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }
        }
        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;
            selectionFont = richTextBox.SelectionFont;

            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }
            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            } else
            {
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }
            this.richTextBox.SelectionFont = newFont;
        }

        //Code generated by the program. It breaks without it, so this stays. 
        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
