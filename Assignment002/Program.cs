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
    internal class Program
    {
    
        static void Main(string[] args)
        {
            #region Part01
            #region Q1
            int enumLength = Enum.GetValues(typeof(DayWeek)).Length;
            Dayes Dayes = new Dayes();
            for (int i = 1; i < enumLength; i++)
            {
                Dayes.DayWeek = (DayWeek)i;
                Console.WriteLine(Dayes.DayWeek);
            }
            #endregion
            #endregion

        }
    }
}
