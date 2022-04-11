using KLIN;

namespace MyForms
{
    internal static class Program
    {
        static KLINInstanse kLINInstanse = new();

        [STAThread]
        static void Main()
        {
            if (kLINInstanse.GetValue("StartWithForm", "true") == "false")
            {

            }
            else
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new DirectXWindow());
            }
        }
    }
}