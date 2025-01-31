namespace Assignment002
{
    public class Dayes
    {
        public DayWeek DayWeek { get; set; }
    }
    public enum DayWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }
    public struct Information
    {
        public int age { get; set; }
        public string name { get; set; }
    }
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public enum Crud : byte
    {
        delete = 1,
        execute = 2,
        read = 4,
        write = 8,
    }
    public enum Color
    {
        Read,
        Green,
        Blue,
    }

    public struct Distance
    {
        public decimal Point01 { get; set; }
        public decimal Point02 { get; set; }

        public Distance(decimal _Point01, decimal _Point02)
        {
            Point01 = _Point01;
            Point02 = _Point02;
        }
        public override string ToString()  // it summary the struct it control the output
        {
            return $"one is  : {Point01}, two is: {Point02} ";
        }

        public static double CalculateDistance(Distance d1, Distance d2)
        {
            return Math.Sqrt(Math.Pow((double)(d2.Point01 - d1.Point01), 2) +
                             Math.Pow((double)(d2.Point02 - d1.Point02), 2));
        }
    }

    public struct Person
    {
        public string Name { get; set; }
        public int age { get; set; }

        public Person(string _name, int _age)
        {
            Name = _name;
            age = _age;
        }

        public override string ToString()  // it summary the struct it control the output
        {
            return $"name is : {Name}, age is : {age} ";
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            #region Part01
            #region Q1
            //int enumLength = Enum.GetValues(typeof(DayWeek)).Length;
            //Dayes Dayes = new Dayes();
            //for (int i = 1; i < enumLength; i++)
            //{
            //    Dayes.DayWeek = (DayWeek)i;
            //    Console.WriteLine(Dayes.DayWeek);
            //}
            #endregion
            #region Q2
            //Information Information = new Information();
            //Information[] Collection = new Information[3];
            //Collection[0] = new Information { age = 15, name = "mohamed" };
            //Collection[1] = new Information { age = 15, name = "mohamed" };
            //Collection[2] = new Information { age = 15, name = "mohamed" };
            //for (int i = 0; i < Collection.Length; i++)
            //{
            //    Console.WriteLine($"{Collection[i].name} {Collection[i].age}");
            //}

            #endregion
            #region Q3
            bool valied;
            Season SeasonUser;
            do
            {
                Console.WriteLine("enter the name of season");
                valied = Enum.TryParse(Console.ReadLine(), out SeasonUser);

            }
            while (!valied);

            if (SeasonUser == Season.Spring)
            {
                Console.WriteLine("Spring: March to May");
            }
            else if (SeasonUser == Season.Summer)
            {
                Console.WriteLine("Summer: June to August");
            }
            else if (SeasonUser == Season.Autumn)
            {
                Console.WriteLine("Autumn: September to November");
            }
            else if (SeasonUser == Season.Winter)
            {
                Console.WriteLine("Winter: December to February");
            }
            #endregion
            #region Q4
            //Crud operations = Crud.write;
            ////operations = operations ^ Crud.delete;

            //bool HaveDelete = operations.HasFlag(Crud.delete);
            //if (HaveDelete)
            //    Console.WriteLine("it have operation of delete");
            //else
            //    operations = operations ^ Crud.delete;
            //Console.WriteLine("the operation of delete has been added");

            //Console.WriteLine(operations);
            //operations = operations | Crud.execute;
            //Console.WriteLine(operations);
            #endregion
            #region Q5
            Color Color = Color.Blue;

            Color BasicColor;
            Console.WriteLine("Enter The Name Of The color ");
            bool ValiedColor = Enum.TryParse(Console.ReadLine(), out BasicColor);
            if (ValiedColor)
                Console.WriteLine("Basic color");
            else
                Console.WriteLine("Basic color");
            #endregion
            #region Q6
            Distance distance01 = new(5, 5);
            Distance distance02 = new(10, 10);
            Console.WriteLine(distance01);
            Console.WriteLine(distance02);
            double result = Distance.CalculateDistance(distance01, distance02);
            Console.WriteLine($"Distance between {distance01} and {distance02} is: {result}");
            //

            #endregion
            #region Q7
            Person[] people = new Person[3];
            people[0] = new("Ahmed", 25);
            people[1] = new("Mohamed", 23);
            people[2] = new("Mostafa", 18);
            Console.WriteLine(people[0].age);
            Console.WriteLine(people[1].age);
            Console.WriteLine(people[2].age);

            int MaxAge = people[0].age;
            for (int i = 0; i < people.Length; i++)
            {
                if (MaxAge < people[i].age)
                    MaxAge = people[i].age;
            }
            Console.WriteLine($"the max age is {MaxAge}");

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].age == MaxAge)
                {
                    Console.WriteLine($"the data of people who have max age : {people[i]}");
                }

            }
            #endregion
            #endregion


        }
    }
}