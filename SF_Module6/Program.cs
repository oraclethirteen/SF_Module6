using System;

namespace SF_Module6
{
    class Program
    {
        /* (II) [6.3.1]
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
        }

        static Department GetCurrentDepartment()
        {
            if (department?.Company?.Type == "Банк" ?? department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
        }
        */

        static void Main(string[] args)
        {

        }
    }

    /* (I) [6.2.2]
    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Чёрный";
            cost = 100;
        }

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }
    */

    /* (II) [6.3.1]
    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }
    */

    /*  (III) [6.3.2]
    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("Количсетво пассажиров в автобусе: {0}", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }
    */

    /* (IV) [6.5.2]
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;

        public double Per()
        {
            return (a + b + c);
        }

        public double Sq()
        {
            return (0.5 * a * h);
        }

    }

    class Circle
    {
        public const double pi = 3.14;
        public double radius;

        public double Per()
        {
            return (2 * pi * radius);
        }

        public double Sq()
        {
            return (2 * pi * radius * radius);
        }
    }

    class Square
    {
        public double a;

        public double Per()
        {
            return (4 * a);
        }

        public double Sq()
        {
            return (a * a);
        }
    }
    */

    /* (V) [6.6.1]
    class TrafficLight
    {
        private void ChangeColor(string color)
        {

        }

        public void GetColor()
        {

        }
    }
    */

    /* (VI) [6.6.2]
    class User
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        private string login;

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть не менее 3х символов в длину");
                }

                else
                {
                    login = value;
                }
            }
        }

        private string email;

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (!(value.Contains('@')))
                {
                    email = value;
                }
            }
        }
    }
    */
}
