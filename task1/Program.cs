// 2 задача
// using System;

// class Program {
//   static void Main(string[] args) {
//     Console.WriteLine("Введите первое число:");
//     int number1 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Введите второе число:");
//     int number2 = Convert.ToInt32(Console.ReadLine());

//     if (number1 > number2) {
//       Console.WriteLine($"Максимальное число: {number1}, минимальное: {number2}");
//     } else if (number2 > number1) {
//       Console.WriteLine($"Максимальное число: {number2}, минимальное: {number1}");
//     } else {
//       Console.WriteLine("Числа равны");
//     }
//   }
// }

// 4 задача

// using System;

// class Program {
//     static void Main(string[] args) {
//         Console.Write("Введите первое число: ");
//         int num1 = int.Parse(Console.ReadLine());

//         Console.Write("Введите второе число: ");
//         int num2 = int.Parse(Console.ReadLine());

//         Console.Write("Введите третье число: ");
//         int num3 = int.Parse(Console.ReadLine());

//         int max = num1;
//         if (num2 > max) {
//             max = num2;
//         }
//         if (num3 > max) {
//             max = num3;
//         }

//         Console.WriteLine($"Максимальное число: {max}");
//     }
// }

// 6 задача
// using System;

// class Program {
//     static void Main(string[] args) {
//         Console.Write("Введите число: ");
//         int number = int.Parse(Console.ReadLine());

//         if (number % 2 == 0) {
//             Console.WriteLine("Да");
//         } else {
//             Console.WriteLine("Нет");
//         }
//     }
// }

// 8 задача
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Запрос числа у пользователя
//         Console.Write("Введите число N: ");
//         int n = int.Parse(Console.ReadLine());
 
//         Console.Write("Чётные числа от 1 до N: ");
 
//         // Перебираем числа от 1 до N и выводим только чётные
//         for (int i = 1; i <= n; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 Console.Write(i + " ");
//             }
//         }
 
//         Console.ReadLine(); // Ждём, пока пользователь не нажмёт Enter
//     }
// }
