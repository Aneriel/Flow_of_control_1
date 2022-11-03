// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

string wejscie = Console.ReadLine();
int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
int daneZero = dane[0];
int daneJeden = dane[1];
int daneMod = dane[2];
List<int> moduloList = new List<int>();
if (dane[0] < dane[1]) { 
    while (dane[0] < dane[1]-1)
    {
        dane[0]++;
        if (dane[0] % dane[2] == 0)
        {
            moduloList.Add(dane[0]);
            Console.Write($"{dane[0]}, ");
        }
   
    }
}
else if(dane[0] > dane[1]){
       while (dane[1] < dane[0]-1)
        {
        dane[1]++;
        if (dane[1] % dane[2] == 0)
        {
            moduloList.Add(dane[1]);
            Console.Write($"{dane[1]}, ");
        }
   
    }
}
else
{
    Console.WriteLine("empty");
}
int moduloCount = moduloList.Count;
 
if (moduloCount==0)
{
    Console.WriteLine("empty");
    
}

else
































































/*{
    if (dane[1] - dane[0] <= 11&& dane[0] - dane[1] <= 11)
    {

    
        if (dane[0] < dane[1])
        { 
            while (dane[0] < dane[1])
            {
                    dane[0]++;
                    if (dane[0] % dane[2] == 0)
                    {
                        if (dane[0] + dane[2] == dane[1])
                        {
                           Console.Write($"{dane[0]}");
                           break;
                        
                        }
                        Console.Write($"{dane[0]}, ");
                    }

                
            }
        }   
        else if (dane[1] < dane[0])
        {
            while (dane[1] < dane[0])
            {
                dane[1]++;
                if (dane[1] % dane[2] == 0)
                {
                    if (dane[1] + dane[2] == dane[0])
                    {
                        Console.Write($"{dane[1]}");
                        break;
                    }
                    Console.Write($"{dane[1]}, ");
                }   
            }
        }
    }
    else if(dane[0] < dane[1])
    {
        while (dane[0] < daneZero+3)
        {
            dane[0]++;
            Console.Write($"{dane[0]}, ");

        }
        if (dane[0] == daneZero + 3)
        {
            Console.Write("..., ");
            Console.WriteLine($"{dane[1]-2}, {dane[1]-1}");
        }
    }
    else
    {
        while (dane[1] < daneJeden+3)
        {
            dane[1]++;
            Console.Write($"{dane[1]}, ");

        }
        if (dane[1] == daneJeden + 3)
        {
            Console.Write("..., ");
            Console.WriteLine($"{dane[0]-2}, {dane[0]-1}");
           }
        }
    

}*/
#if DEBUG
    Console.WriteLine("Press enter to close...");
    Console.ReadLine();
#endif
 