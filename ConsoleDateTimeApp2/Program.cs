namespace ConsoleDateTimeApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            System.Diagnostics.Debug.WriteLine(DateTime.Now);
            System.Diagnostics.Debug.WriteLine(DateTime.Now.Kind);
            System.Diagnostics.Debug.WriteLine(DateTime.UtcNow);
            System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.Kind);
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToUniversalTime().ToString("MM/dd/yyyy hh:mm tt"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));
            System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.ToString("MM/dd/yyyy hh:mm tt"));

            DateTime dateTime= new DateTime(2022,1,10);
            System.Diagnostics.Debug.WriteLine(dateTime);
            

            TimeSpan  timeSpan= new TimeSpan(2,8,12);
            System.Diagnostics.Debug.WriteLine(timeSpan.Hours);
            System.Diagnostics.Debug.WriteLine(timeSpan.Minutes);
            System.Diagnostics.Debug.WriteLine(timeSpan.Seconds);





        }
    }
}