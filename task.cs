/******************************************************************************

*******************************************************************************/

using System;
class task {
  static void Main() {
    Console.Write("Введите количество элементов массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    string [] stringArray = new string [m];
    InputStrArray(stringArray);
  }
  
  static void InputStrArray(string [] stringArray)
  {
    for (int i = 0;i<stringArray.Length;i++)
    {
        Console.WriteLine("Введите {0} элемент массива", i+1);
        stringArray[i] = Console.ReadLine();
    }
  }   
  
}
