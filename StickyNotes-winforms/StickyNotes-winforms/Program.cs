namespace StickyNotes_winforms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StickyNote mainForm = new StickyNote();
            mainForm.Show();

            //  keep the application running without a main form
            Application.Run();
        }
    }
}