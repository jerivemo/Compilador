using Runtime;
using Analizador_Lexico;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace Compilador.Analizador_Lexico
public class Driver {

    public static void main(String[] argv)
    {

    for (int i = 0; i < argv.Length; i++) {
      try {
        Console.WriteLine("Proceso de parsing sobre el archivo ["+argv[i]+"]");
          
        Scanner s = new Scanner(new StreamReader(argv[i]));
        Parser p = new Parser(s);
        //p.parse();
        Console.WriteLine("Compilación Exitosa...");
      }
      catch (Exception e) {
        Console.WriteLine(e.ToString());
        
      }
    }
  }

}
}