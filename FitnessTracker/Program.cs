namespace FitnessTracker
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
            ApplicationConfiguration.Initialize();

            FitnessTracker tracker = new FitnessTracker();

            //Application.Run(new MainForm(tracker));
            Application.Run(new LoginForm(tracker));
            //Application.Run(new GoalSettingForm());
        }
    }
}