namespace homeLibary
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new logInForm());
        }
    }
}