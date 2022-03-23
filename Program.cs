using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoDeProg
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
           
            String me;
            Byte _me;
            String an;
            UInt16 v = 1;


            do
            {
                Console.WriteLine("Digite o MÊS desejado: ");
                me = Console.ReadLine();
                _me = Convert.ToByte(me);

                if (_me > 0 && _me < 13)
                {
                    v = 3;
                }
                else
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("O MÊS deve seguir o formato numérico,\ntal como '10' para Outubro,\ne, portanto, deve ser de 1 a 12.");
                    Console.WriteLine("-----------------------------------------");
                }
            }
            while (v < 2);

            

            




            //Console.WriteLine("\n\nDigite o ANO desejado: ");
            //an = Console.ReadLine();


            //Calendario cal = new Calendario()


        }
    }
}
