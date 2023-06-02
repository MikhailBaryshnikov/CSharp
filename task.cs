/******************************************************************************

*******************************************************************************/

using System;
class task {
  static void Main() {
    Console.Write("Введите количество элементов массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    string [] stringArray = new string [m];
    InputStrArray(stringArray);
    
    Search3Сhar(stringArray);
  }
  
  static void InputStrArray(string [] stringArray)
  {
    for (int i = 0;i<stringArray.Length;i++)
    {
        Console.WriteLine("Введите {0} элемент массива", i+1);
        stringArray[i] = Console.ReadLine();
    }
  }   
  
  static string [] Search3Сhar(string [] stringArray)
  {
    int n = 0;
    string [] rez = new string [n];
    
    for (int i = 0;i<stringArray.Length;i++)
    {
        if(stringArray[i].Length <=3) 
        {
            Array.Resize(ref rez, rez.Length + 1);
            rez[rez.Length - 1] = stringArray[i];
        }
    }

    return rez;
  }

}
