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
            bgcolorBtn = new Button();
            fontBtn = new Button();
            fontDialog1 = new FontDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Cursor = Cursors.IBeam;
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
            topmostWindowCheck.BackColor = Color.Silver;
            topmostWindowCheck.Cursor = Cursors.Hand;
            topmostWindowCheck.FlatStyle = FlatStyle.Popup;
            topmostWindowCheck.Location = new Point(0, 0);
            topmostWindowCheck.Name = "topmostWindowCheck";
            topmostWindowCheck.Size = new Size(109, 19);
            topmostWindowCheck.TabIndex = 3;
            topmostWindowCheck.Text = "Window On Top";
            topmostWindowCheck.UseVisualStyleBackColor = false;
            topmostWindowCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // newwinbutton
            // 
            newwinbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newwinbutton.BackColor = Color.Silver;
            newwinbutton.Cursor = Cursors.Hand;
            newwinbutton.FlatStyle = FlatStyle.Popup;
            newwinbutton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            newwinbutton.Location = new Point(325, 0);
            newwinbutton.Name = "newwinbutton";
            newwinbutton.Size = new Size(75, 19);
            newwinbutton.TabIndex = 4;
            newwinbutton.Text = "New Note";
            newwinbutton.UseVisualStyleBackColor = false;
            newwinbutton.Click += newwinbutton_Click;
            // 
            // bgcolorBtn
            // 
            bgcolorBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bgcolorBtn.BackColor = Color.Silver;
            bgcolorBtn.Cursor = Cursors.Hand;
            bgcolorBtn.FlatStyle = FlatStyle.Popup;
            bgcolorBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            bgcolorBtn.Location = new Point(200, 0);
            bgcolorBtn.Name = "bgcolorBtn";
            bgcolorBtn.Size = new Size(119, 19);
            bgcolorBtn.TabIndex = 5;
            bgcolorBtn.Text = "Background Color";
            bgcolorBtn.UseVisualStyleBackColor = false;
            bgcolorBtn.Click += bgcolorBtn_Click;
            // 
            // fontBtn
            // 
            fontBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fontBtn.BackColor = Color.Silver;
            fontBtn.Cursor = Cursors.Hand;
            fontBtn.FlatStyle = FlatStyle.Popup;
            fontBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            fontBtn.Location = new Point(140, 0);
            fontBtn.Name = "fontBtn";
            fontBtn.Size = new Size(54, 19);
            fontBtn.TabIndex = 6;
            fontBtn.Text = "Fonts";
            fontBtn.UseVisualStyleBackColor = false;
            fontBtn.Click += fontBtn_Click;
            // 
            // fontDialog1
            // 
            fontDialog1.ShowApply = true;
            fontDialog1.ShowColor = true;
            fontDialog1.Apply += fontDialog1_Apply_1;
            // 
            // StickyNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 450);
            Controls.Add(fontBtn);
            Controls.Add(bgcolorBtn);
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
        private Button bgcolorBtn;
        private Button fontBtn;
        private FontDialog fontDialog1;
    }
}
