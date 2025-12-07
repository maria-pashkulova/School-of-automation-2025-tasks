namespace MusicShuffleMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicShuffleMachine machine = new MusicShuffleMachine();

            Console.WriteLine("Enter songs in the format: name - mm:ss");
            machine.AddSongs();

            machine.Shuffle();
            Console.WriteLine($"{Environment.NewLine}Shuffled playlist:");
            machine.PrintAllSongsInPlaylist();

            machine.GenerateCustomPlaylist();

            machine.PrintSongGroups();

        }


        

    }



}
