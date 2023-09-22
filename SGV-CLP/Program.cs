using SGV_CLP.Classes;

namespace SGV_CLP
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
            Usuario user = new Usuario();
            user.userName = "DefaultUser";
            user.contrasenia = "P@ssw0rd";
            user.cargo = "Cajero";
            Application.Run(new MainMenu(user));
        }
    }
}