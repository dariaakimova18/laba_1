namespace Laba_1
{
    public class laba_1
    {
        long A;
        const string B = "Privet";
        decimal[] C = new decimal[10];
        enum D : int
        {
            first = 0, second = 1, third = 2
        }
        public void dosomething()
        {
            A = 2000000;
            string pricol = B + A.ToString(); 
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            laba_1 laba_1 = new laba_1();
            laba_1.dosomething();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}