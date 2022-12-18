using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.WindowsForms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread translationThread = new Thread(() =>
            {

                Action action = () =>
                {


                    Application.Run(new TranslationsForm());
                };
                action();

            }
         );
            translationThread.SetApartmentState(ApartmentState.STA);
            translationThread.Start();

            
              Application.Run(new Login());



        }
    }
}
