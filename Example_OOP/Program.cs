using System;

namespace Example_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
           //First iron.
            Iron iron = new Iron();
            iron.Print();
            string steam = "No";
            iron.SetSteam(steam);
            iron.Print();


            //Second iron.
            Console.WriteLine("Second iron:");
            Iron iron1 = new Iron("Sansung", 150, new DateTime(2021, 10, 10));
            iron1.Print();

            //Change condidtional of iron(set "On")
            string power = "On";
            iron1.SetPower(power);
            iron1.Print();
            iron1.SetTemp();
            iron1.Print();

            Console.WriteLine($"{iron1.GetTemp()}");
        }
    }
}
