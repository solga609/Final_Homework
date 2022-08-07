// Написать программу, которая из имеющегос массива строк формирует массив строк,
//  длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. 

class Symbols{
     static void Main(string[] args){
       string[] s = new String[100];
         int n;
          Console.WriteLine("Задайте количество элементов  :");
          n = int.Parse(Console.ReadLine());
          for (int i = 1; i<=n; i++){
              s[i] = Console.ReadLine();
          }
          Console.WriteLine($"Вывод:  ");
          for (int i = 1; i<=3; i++ )
          {
              Console.Write($"[" +  s[i]  + "]");
          }
          Console.ReadKey();
      }
  }



































