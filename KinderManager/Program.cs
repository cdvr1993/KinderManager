using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace KinderManager
{
    static class Program
    {
        public static StreamWriter log = null;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main () {
            Thread hilo = new Thread ( iniciarLog );
            hilo.Start ();
            new Pruebas ();
            //Application.EnableVisualStyles ();
            //Application.SetCompatibleTextRenderingDefault ( false );
            //Application.Run ( new VentanaPrincipal () );
        }

        static void iniciarLog () {
            try {
                Program.log = new StreamWriter ( "Log del programa.txt", true );
            } catch (FileNotFoundException) {
                Program.log = new StreamWriter ( "Log del programa.txt" );
            }
        }
    }
}
