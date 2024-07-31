using System.Configuration.Assemblies;
using System.Security.Cryptography.X509Certificates;
using System.Threading; 

namespace Timer;

class Program
{
    static void Main(string[] args)
    {

        Menu();

    }

    static void Start(int time, string tipo)
    {
       int currentTime = 0;
       

       while(currentTime != time)
       {
            

            Console.Clear();
            currentTime++;
            Console.WriteLine($"{currentTime} being counted in {tipo}");
            Thread.Sleep(1000); //Aguarda 1 seg para incrementação.
       }

       Console.Clear();
       Console.WriteLine("Stopwatch finalizado");
       Thread.Sleep(2000);
    }  

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos");
        Console.WriteLine("M = Minuto");
        Console.WriteLine("O - Sair"); //System.Enviroment.Exit;
        Console.WriteLine("How much time to count: ");
            
            string option = "M";
            switch(option)
            {
              case "S":
                   CountSeg();
                   Console.WriteLine(option);
              break;

              case "M":
                   CountMin();
              break;

              case "O":

              break;
            }
    }

    static void CountSeg()
    {
       Console.WriteLine($"Type how many seconds: ");
       int segs = int.Parse(Console.ReadLine());
       string tipo = "seg";
       Start(segs, tipo);



    }

    static void CountMin()
    {
      Console.WriteLine($"Type how many minutes: ");
      int mins = int.Parse(Console.ReadLine());
      string tipo = "min";
      Start(mins, tipo);
    }

    static void Exit()
    {
        System.Environment.Exit(0);
    }
}