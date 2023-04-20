namespace CorrectivoOPreventivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static double dias = 0;
        public static double desde = -1;
        public static double hasta = -1;
        public static bool mostrar = false;
        public static double[] probabilidades = { 0.25, 0.7, 0.9, 1 };



        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new IngresoDatos());
        }
    }
}