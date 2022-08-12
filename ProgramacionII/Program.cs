using ProgramacionII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades.capas
{   

   
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static bool validateloggin;
        public static bool salidaMenuPrincipal = true;
        public static bool loggindesdemenuprincipal;
        public static bool entidadagregada;
        public static String username;
        public static String addusername;
        public static String addclave;



        [STAThread]
        static void Main()
        {
           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);

           //Se abre el telon.
           Application.Run(new Splash());
           Application.Run(new loggin());

            while (salidaMenuPrincipal)
            {
               // Application.Run(new loggin());
                if (validateloggin) {

                    validateloggin = false;
                    Application.Run(new MenuPrincipal(username));
                    
                    if (loggindesdemenuprincipal)
                    {
                        loggindesdemenuprincipal = false;
                        Application.Run(new loggin());
                    }//AGREGAR AQUI LA CONDICION SI AGREGA OTRA ENTIDAD.
                }
                else
                {
                    Application.Run(new MantenimientoEntidades(addclave,addusername));
                    if (entidadagregada)
                    {
                        entidadagregada = false;
                        Application.Run(new loggin());
                    }
                    break;

                }
                
            }
           
        }
    }
}
