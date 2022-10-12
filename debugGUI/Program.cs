namespace debugGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            ApplicationContext appCtx = new ApplicationContext(new Form2());
            Application.Run(appCtx);

            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form2());
            //Application.Run(new Form1());
        }
    }
}