using System;

namespace Interface
{
    interface IPlayable {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecordable {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IRecordable, IPlayable {

        public void Play() { Console.WriteLine("Play"); }
        public void Record() { Console.WriteLine("Record"); }
        public void Pause() { Console.WriteLine("Pause"); }
        public void Stop() { Console.WriteLine("Stop"); }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            player.Record();
            player.Pause();
            player.Stop();
            Console.ReadKey();
        }
    }
}
