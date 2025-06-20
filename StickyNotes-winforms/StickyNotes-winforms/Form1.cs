using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace StickyNotes_winforms
{
    public partial class StickyNote : Form
    {
        public StickyNote()
        {
            InitializeComponent();

            this.FormClosed += StickyNote_FormClosed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topmostWindowCheck.Checked;
        }

        private void newwinbutton_Click(object sender, EventArgs e)
        {
            StickyNote stickynote = new StickyNote();
            stickynote.Show();

        }


        private void StickyNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Dispose();

            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void bgcolorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog bgcolorDialog = new ColorDialog();
            bgcolorDialog.AllowFullOpen = true;
            bgcolorDialog.AnyColor = true;
            bgcolorDialog.ShowHelp = false;
            bgcolorDialog.Color = this.BackColor;

            if (bgcolorDialog.ShowDialog() == DialogResult.OK)
                this.BackColor = bgcolorDialog.Color;
            richTextBox1.BackColor = bgcolorDialog.Color;
        }

        private void fontBtn_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.Color = richTextBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }

        }

        private void fontDialog1_Apply_1(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save Sticky Note";
            saveFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.AddExtension = false;
            saveFileDialog1.FileName = "MyNote";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var type = saveFileDialog1.FilterIndex == 2 ? RichTextBoxStreamType.PlainText : RichTextBoxStreamType.RichText;
                richTextBox1.SaveFile(saveFileDialog1.FileName, type);
            }
        }

   
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.AddExtension = true;
            openFileDialog1.FileName = "MyNote";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                if (Path.GetExtension(filePath).Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                }

            }

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}