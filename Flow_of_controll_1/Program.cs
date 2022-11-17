using System.Reflection.Metadata;
using System.Collections.Generic;

string wejscie = Console.ReadLine();
int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);

List <int> moduloList = new List<int>();
if (dane[0] < dane[1]) { 
    while (dane[0] < dane[1]-1)
    {
        dane[0]++;
        if (dane[0] % dane[2] == 0)
        {
            moduloList.Add(dane[0]);
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
        }
   
    }
}

int moduloCount = moduloList.Count;
 
if (moduloCount==0)
{
    Console.WriteLine("empty");
    
}

else
{
    
    if (moduloCount <= 10) { 
    for(int i = 0; i< moduloCount; i++)
    {
        if(i==moduloCount-1)
        {
            Console.Write($"{moduloList[i]}");
        }
        else { 
        Console.Write($"{ moduloList[i]}, ");
            }
    }
    }
    else
    {
        for(int i = 0; i < 3; i++) { 
            Console.Write($"{moduloList[i]}, ");
        }
        Console.Write("..., ");
        Console.Write($"{moduloList[moduloCount-2]}, ");
        Console.Write(moduloList[moduloCount-1]);
    }
}

#if DEBUG
    Console.WriteLine();
    Console.WriteLine("Press enter to close...");
    Console.ReadLine();
#endif
 