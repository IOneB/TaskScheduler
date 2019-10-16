namespace TaskScheduler.Models
{
    static class IdMaker
    {
        static int _id = 0;
        public static int MakeId() => _id++;
    }
}
