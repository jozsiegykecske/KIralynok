using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KIralynok
{
  class Program
  {
    static Tabla tabla = new Tabla('#');
    static void Main(string[] args)
    {
      
      HatodikFeladat();
      KilencesFeladat();
      TizedikFeladat();
      Console.ReadKey();
    }

    private static void TizedikFeladat()
    {
      List<Tabla> tablak = new List<Tabla>();
      for (int i = 0; i < 64; i++)
      {
        tablak.Add(new Tabla('*'));
        tablak[i].Elhelyez(i+1);
      }
      if (File.Exists("tablak64.txt"))
      {
        File.Delete("tablak64.txt");
      }
      else
      {
        StreamWriter ki = new StreamWriter("tablak64.txt");
        for (int i = 0; i < tablak.Count; i++)
        {
          for (int k = 0; k < 8; k++)
          {
            ki.WriteLine(tablak[i].Egysor(k));
            
          }
          ki.WriteLine();
        }
        ki.Close();
      }
      
    }

    private static void KilencesFeladat()
    {
      Console.WriteLine("9.feladat: Üres oszlopok és sorok száma:");
      Console.WriteLine($"\tOszlopok:{tabla.UresOszlopokSzama}");
      Console.WriteLine($"\tSorok:{tabla.UresSorokSzama}");
    }

    private static void HatodikFeladat()
    {
      tabla.Elhelyez(5);
      tabla.Megjelenit();
    }
  }
}
