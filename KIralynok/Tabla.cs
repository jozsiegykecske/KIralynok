using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KIralynok
{
  class Tabla
  {
    char[,] T;
    char UresCella;
    private int uresoszlopokszama;

    public int UresOszlopokSzama  
    {
      get {
        for (int i = 0; i < 8; i++)
        {
          if (UresOszlop(i))
          {
            uresoszlopokszama++;
          }
        }
        return uresoszlopokszama; }
    }
    private int uressorokszama;

    public int UresSorokSzama
    {
      get {
        for (int i = 0; i < 8; i++)
        {
          if (UresSor(i))
          {
            uressorokszama++;
          }
        }
        return uressorokszama; }
    }

    public Tabla(char karakter)
    {
      T = new char[8, 8];
      UresCella = karakter;
      for (int i = 0; i < 8; i++)
      {
        for (int j = 0; j < 8; j++)
        {
          T[i, j] = UresCella;
        }
      }
    }
    public void Megjelenit()
    {
      for (int i = 0; i < 8; i++)
      {
        for (int j = 0; j < 8; j++)
        {
          Console.Write(T[i,j] + " ");
        }
        Console.WriteLine();
      }
    }
    public void Elhelyez( int n)
    {
      Random random = new Random(Guid.NewGuid().GetHashCode());
      for (int i = 0; i < n; i++)
      {
        int sor, oszlop;
        do
        {
          sor = random.Next(0, 8);
          oszlop = random.Next(0, 8);
        } while (T[sor,oszlop]!= UresCella);
        T[sor, oszlop] = 'K';
        
      }
    }
    public bool UresSor( int melyikSor)
    {
      int szamlalo = 0;
      while (szamlalo<8 && T[melyikSor,szamlalo]==UresCella)
      {
        szamlalo ++;
      }
      if (szamlalo<8)
      {
        return false;
      }
      else
      {
        return true;
      }
    }
    public bool UresOszlop(int melyikOszlop)
    {
      int szamlalo = 0;
      while (szamlalo < 8 && T[szamlalo,melyikOszlop] == UresCella)
      {
        szamlalo++;
      }
      if (szamlalo < 8)
      {
        return false;
      }
      else
      {
        return true;
      }
    }
    public string Egysor(int hanyadikoszlop)
    {
      string sor = "";
      for (int i = 0; i < 8; i++)
      {
        sor += T[hanyadikoszlop,i] + " ";
      }
      return sor;
    }
  }
}
