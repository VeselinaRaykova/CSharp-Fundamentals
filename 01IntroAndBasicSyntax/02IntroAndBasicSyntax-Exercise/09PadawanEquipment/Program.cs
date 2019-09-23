using System;

namespace _09PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double ownedMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double neededMoney = Math.Ceiling(students * 1.1) * lightsabersPrice +
                students * robesPrice +
                (students - (students / 6)) * beltsPrice;

            if (neededMoney <= ownedMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {neededMoney-ownedMoney:f2}lv more.");
            }
        }
    }
}
