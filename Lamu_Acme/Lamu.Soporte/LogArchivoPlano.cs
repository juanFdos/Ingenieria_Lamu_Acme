using System;
using System.IO;


namespace Lamu.Soporte
{
    public class LogArchivoPlano : ILog
    {
        private string Ruta;

        public LogArchivoPlano()
        {
            string rutacompleta = Directory.GetCurrentDirectory();
            Ruta = Path.Combine(rutacompleta, "LOGS", "log.txt");
        }
        public void GuardarError(Exception ex)
        {
            File.AppendAllText(Ruta, ex.ToString());
           // File.WriteAllText(Ruta, ex.ToString());
        }
        

        public void GuardarAccion(string msg)
        {
            File.AppendAllText(Ruta,msg);
        }
    }
}
