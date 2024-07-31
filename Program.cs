using System.Configuration.Assemblies;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading; 

namespace Timer;

class Program
{
    static void Main(string[] args)
    {

        Menu();

    }

    static void Start(int time)
    {
       int currentTime = 0;
       

       while(currentTime != time)
       {
            

            Console.Clear();
            currentTime++;
            Console.WriteLine($"{currentTime} being counted");
            Thread.Sleep(100); //Aguarda 1 seg para incrementação.
       }

       Console.Clear();
       Console.WriteLine("Stopwatch finalizado");
       Thread.Sleep(10);
    }  
    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("GO");

        Start(time);
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos");
        Console.WriteLine("M = Minuto");
        Console.WriteLine("O - Sair"); //System.Enviroment.Exit;

       
         
        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1)); //data.Length - 1 decrementa a posição da string para achar o ultimo caractere.
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1; 
            
            
            if (type == 'm')
            {
                multiplier = 60;
            }
            else if (type == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);


          /*  switch(data)
            {
              case "s":
                   CountSeg();
              break;

              case "m":
                   CountMin();
              break;

              case "o":
                   Exit();
              break;
            }*/
    }

    /*

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

    */
}