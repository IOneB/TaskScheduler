namespace TaskScheduler.Models
{
    static class Random
    {
        static readonly System.Random rnd = new System.Random();
        public static int Get(int min = 800, int max = 3000) => rnd.Next(min, max);
    }
}
