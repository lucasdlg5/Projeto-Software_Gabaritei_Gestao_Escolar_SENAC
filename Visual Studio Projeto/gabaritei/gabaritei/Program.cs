using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//         !!!FOCA NA PROGRAMAÇÃO!!!
//          -+//---:yo-:.                            
//      `.:o.:.-:-.::  /:.                          
//     .``./+--.:-.`..`  +/                         
//    ````. -:-.`.`. ..   d`                        
//        .   :. ` ``  `  :s                        
//        `    +           -/`                      
//            o            `:-`                    
//            ./              .:-`                  
//            +`                ./-                 
//            o                   y/....``          
//           :h                   : .....:/-.       
//          +:o`        `-.``.    `       `.-/-     
//          s `-        o.   ``              `/+`   
//          +` -      `--    -`                ./-  
//          :-  -    :-`     s`                  -o 
//  .::o:---/`  `/` /.     .o-                    ++
//.:+:-.````    :y+sh     .d.   `.` `...````````   y
///://::------:/-` `/-    `--:++:://:.``.-.       .o
// ```               -/:-`    ..+yo/---.    ..`.:/:`
//                       -/:--`..-o/:o//-://..--`   
//                           `----s:   `.`          

namespace gabaritei
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // teste
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            //teste
            Application.Run(new frm_principal());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //padrao
            //throw new NotImplementedException();

            //alterado - MOSTRARÁ MENSAGEM PARA QUALQUER TIPO DE ERRO OCORRIDO EM TODO PROGRAMA
            MessageBox.Show("Erro de sistema, o programa será finalizado");

        }
    }
}
