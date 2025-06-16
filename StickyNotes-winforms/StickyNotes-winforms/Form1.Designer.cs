namespace StickyNotes_winforms
{
    partial class StickyNote
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            topmostWindowCheck = new CheckBox();
            newwinbutton = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.EnableAutoDragDrop = true;
            richTextBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(3, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(397, 426);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // topmostWindowCheck
            // 
            topmostWindowCheck.AutoSize = true;
            topmostWindowCheck.Dock = DockStyle.Top;
            topmostWindowCheck.Location = new Point(0, 0);
            topmostWindowCheck.Name = "topmostWindowCheck";
            topmostWindowCheck.Size = new Size(400, 19);
            topmostWindowCheck.TabIndex = 3;
            topmostWindowCheck.Text = "Window On Top";
            topmostWindowCheck.UseVisualStyleBackColor = true;
            topmostWindowCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // newwinbutton
            // 
            newwinbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newwinbutton.Location = new Point(325, 0);
            newwinbutton.Name = "newwinbutton";
            newwinbutton.Size = new Size(75, 23);
            newwinbutton.TabIndex = 4;
            newwinbutton.Text = "New Note";
            newwinbutton.UseVisualStyleBackColor = true;
            newwinbutton.Click += newwinbutton_Click;
            // 
            // StickyNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(newwinbutton);
            Controls.Add(topmostWindowCheck);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "StickyNote";
            Text = "stickynotes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private CheckBox topmostWindowCheck;
        private Button newwinbutton;
    }
}
