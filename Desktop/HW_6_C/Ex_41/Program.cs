// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//Ввод чисел останавливается при помощи ввода стоп-слова "stop" 
//и производится при помощи нажатия Enter
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите числа с отступом друг от друга: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for(int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество элементов > 0: {count}");

//List<string> list = new List<string>();
//       
//       Console.WriteLine("Words by one per line:");
//       while ( true ) {
//            Console.Write("> ");
//            string s = Console.ReadLine();
//            if ( s == "СТОП" ) 
//                break;
//            list.Add(s);
//        }
//        
//        if ( list.Count == 0 ) {
//            Console.WriteLine("No words given");
//            System.Environment.Exit(1);
//        }
