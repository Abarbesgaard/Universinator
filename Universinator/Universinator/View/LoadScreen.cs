using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.View
{
    public class LoadScreen
    {
        public void LoadScreenDisplay()
        {
            Hardline();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                .                                            .\r\n");
            Console.WriteLine("     *   .                  .              .        .   *          .");
            Console.WriteLine("  .         .                     .       .           .      .        .");
            Console.WriteLine("        o.                   .");
            Console.WriteLine("         .              .                  .           .");
            Console.WriteLine("          0.");
            Console.WriteLine("                 .          .                 ,                ,    ,");
            Console.WriteLine(" .          \\          .                         .");
            Console.WriteLine("      .      \\   ,");
            Console.WriteLine("   .          o.                 .                   .            .");
            Console.WriteLine("     .         \\                 ,             .                .");
            Console.WriteLine("               #\\##\\#      .                              .        .");
            Console.WriteLine("             #  #O##\\###                .                        .");
            Console.WriteLine("   .        #*#  #\\##\\###                       .                     ,");
            Console.WriteLine("        .   ##*#  #\\##\\##               .                     .");
            Console.WriteLine("      .      ##*#  #o##\\#         .                             ,       .");
            Console.WriteLine("          .     *#  #\\#     .                    .             .          ,");
            Console.WriteLine("                      \\          .                         .");
            Console.WriteLine("____ ^/\\___ ^ --____ /\\____O______________ /\\/\\---/\\___________-- - ______________");
            Console.WriteLine("   /\\^^^^^^^'\\ ^          ^       ---");
            Console.WriteLine("         -- - --- ----__ ^");
            Console.WriteLine("   --__                      ___-- ^ ^--__");
            Console.WriteLine("");

            Hardline();

        }

        public void Hardline()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                       ");
            Console.ResetColor();
        }
    }
}
