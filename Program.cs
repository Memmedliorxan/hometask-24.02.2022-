using System;

namespace homework1_24._02._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qrupunuzu daxil edin");
            string groupno = Console.ReadLine();
            Console.WriteLine("tam adinizi daxil edin");
            string fullname = Console.ReadLine();
            Console.WriteLine("yasinizi daxil edin");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            Student.Fullname = fullname;
            Student.GroupNo = groupno;
            Student.Age = age;
            Student.Info();

        }
    }
}
