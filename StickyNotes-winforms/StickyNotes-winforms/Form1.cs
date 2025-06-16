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
    }
}