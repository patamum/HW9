using System.Xml.Serialization;

namespace Task9_1
{
    internal class Program
    {
        static double Calc(int a, int b, int c)
        {
            switch(c)
            {
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a * b;
                case 4: return (double) a / b;
            }            
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            int choice = 0;
            try
            {
                Console.Write("Введите целое число. X = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y = ");
                int y = Convert.ToInt32(Console.ReadLine());                
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("     1 - сложение");
                Console.WriteLine("     2 - вычитание");
                Console.WriteLine("     3 - произведение");
                Console.WriteLine("     4 - частное");
                Console.Write("Ваш выбор: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 4)
                {                    
                    throw new Exception("Нет операции с указанным номером");
                }
                double res = Calc(x, y, choice);
                Console.WriteLine("Результат = {0}", res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}