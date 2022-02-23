using System;
using System.Collections.Generic;
using System.Text;

namespace homework1_24._02._2022
{
    class Student
    {
        static string _groupNo;
        static string _fullName;
        static int _age;

        public Student(string no, string fulname, int age)
        {
            GroupNo = no;
            Fullname = _fullName;
            Age = age;
        }

        public static int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public static string Fullname
        {
            get
            {
                return _fullName;
            }
            set
            {
                while (!CheckFullName(value))
                {
                    Console.WriteLine("xais olunur, duzgun tam ad daxil edin");
                    value = Console.ReadLine();
                }
                _fullName = value;

            }
        }
        public static bool CheckGroupno(string groupno)
        {
            if (groupno.Length == 4)
            {
                int a = 0;
                for (int i = 0; i < groupno.Length; i++)
                {
                    if (char.IsUpper(groupno[i]) && i == 0)
                    {
                        a++;
                    }

                    else if (char.IsDigit(groupno[i]))
                    {
                        a++;
                    }
                }
                if (a == 4)
                {
                    return true;

                }
                return false;
            }
            return false;
        }
        public static string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                while (!CheckGroupno(value))
                {
                    Console.WriteLine("xais olunur duzgun qrup nomresi daxil edin");
                    value = Console.ReadLine();
                }
                _groupNo = value;
            }
        }

        public static bool CheckFullName(string fullname)
        {
            int a = 0;
            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsUpper(fullname[i]) && i == 0)
                {
                    a++;
                }
                else if (char.IsWhiteSpace(fullname[i]))
                {
                    a++;
                    if (char.IsUpper(fullname[i + 1]))
                    {
                        a++;
                    }
                }
            }
            if (a == 3)
            {
                return true;
            }
            return false;


        }

        public static void Info()
        {
            Console.WriteLine($"Group-{_groupNo}\n Fullname- {_fullName}\n Age- {_age}");
        }
    }
}
         

           
                    
                
                    


