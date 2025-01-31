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
            Crud operations = Crud.write;
            //operations = operations ^ Crud.delete;

            bool HaveDelete = operations.HasFlag(Crud.delete);
            if (HaveDelete)
                Console.WriteLine("it have operation of delete");
            else
                operations = operations ^ Crud.delete;
            Console.WriteLine("the operation of delete has been added");

            Console.WriteLine(operations);
            operations = operations | Crud.execute;
            Console.WriteLine(operations);
            #endregion
            #endregion


        }
    }
}