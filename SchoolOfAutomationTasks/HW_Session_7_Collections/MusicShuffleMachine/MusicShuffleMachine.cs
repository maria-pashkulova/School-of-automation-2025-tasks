using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShuffleMachine
{
    public class MusicShuffleMachine
    {
        //stores the full song list - List of tuples with field names (Name, DurationSeconds)
        private List<(string Name, int DurationSeconds)> songs;

        public MusicShuffleMachine()
        {
            songs = new List<(string, int)>();
        }


        //Save songs from user input
        public void AddSongs()
        {
            while (true)
            {
                Console.Write("Song: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "end") break;

                // Expected: name - 4:15
                string[] parts = input.Split('-');
                if (parts.Length != 2)
                {
                    Console.WriteLine("Invalid format! Use: song name - mm:ss");
                    continue;
                }

                string name = parts[0].Trim();
                string time = parts[1].Trim();

                // Parse duration
                string[] timeParts = time.Split(':');

                /* both formats 04:05 and 4:5 are acceptable
                 
                 *  int.TryParse("04", out minutes) -> minutes = 4
                    int.TryParse("4", out minutes) -> minutes = 4

                    int.TryParse("05", out seconds) -> seconds = 5
                    int.TryParse("5", out seconds) -> seconds = 5
                 */

                if (timeParts.Length != 2 ||
                    !int.TryParse(timeParts[0], out int minutes) ||
                    !int.TryParse(timeParts[1], out int seconds) ||
                     minutes < 0 ||
                     seconds < 0 || seconds > 59)
                {
                    Console.WriteLine("Invalid time format! Use mm:ss (seconds must be 00–59)");
                    continue;
                }

                int totalSeconds = minutes * 60 + seconds;

                songs.Add((name, totalSeconds));
            }
        }

        /*Fisher-Yates algorithm
         * The idea is to start from the last element 
         * and swap it with a randomly selected element from the whole array 
         * (including the last - every element must have a chance to stay where it is)
         
         */
        public void Shuffle()
        {
            Random random = new Random();

            if (songs.Count <= 1)
            { 
                return; //nothing to shuffle
            } 

            for (int i = songs.Count - 1; i > 0; i--)
            {
                //exclusive upper bound
                int j = random.Next(0, i + 1);

                // Swap list[i] and list[j]
                var temp = songs[i];
                songs[i] = songs[j];
                songs[j] = temp;
            }
        }

        // Print all songs (in mm:ss format)
        public void PrintAllSongsInPlaylist()
        {
            foreach (var song in songs)
            {
                Console.WriteLine($"{song.Name} - {FormatDuration(song.DurationSeconds)}");
            }
        }

        // Convert seconds into "mm:ss"
        private string FormatDuration(int totalSeconds)
        {
            int m = totalSeconds / 60;
            int s = totalSeconds % 60;

            return $"{m}:{s:D2}"; //seconds - padded to 2 digits (D2 - for integer type values); ex: 4:05
        }


        // Create create a playlist of fixed length (in minutes)
        private List<(string Name, int DurationSeconds)> GetCustomPlaylistByDesiredLength(int minutes)
        {
            int targetSeconds = minutes * 60;
            int currentSum = 0;

            List<(string Name, int DurationSeconds)> customPlaylist = new List<(string, int)>();

            // songs selection for custom playlist:
            // add songs in the order they are stored (after shuffle)
            // until the target length is reached

            foreach (var song in songs)
            {
                if (currentSum + song.DurationSeconds <= targetSeconds)
                {
                    customPlaylist.Add(song);
                    currentSum += song.DurationSeconds;
                }
            }

            return customPlaylist;

        }
        
      
        public void GenerateCustomPlaylist()
        {

            int minutes;

            Console.Write($"{Environment.NewLine}To create a custom playlist with a desired length, enter length in minutes: ");

            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out minutes) && minutes > 0)
                {
                    break; // valid input, exit loop

                }

                Console.Write("Invalid input! Please enter a positive number of minutes: ");
            }


            var playlist = GetCustomPlaylistByDesiredLength(minutes);

            Console.WriteLine($"{Environment.NewLine}Custom Playlist ({minutes} min):");

            foreach (var song in playlist)
            {
                Console.WriteLine($"{song.Name} - {FormatDuration(song.DurationSeconds)}");
            }

        }

        // Group songs by first letter of their name
        private Dictionary<char, List<string>> GroupSongsByFirstLetter()
        {
            Dictionary<char, List<string>> groups = new Dictionary<char, List<string>>();

            foreach (var song in songs)
            {
                char firstLetter = char.ToUpper(song.Name[0]);

                if (!groups.ContainsKey(firstLetter))
                {
                    groups[firstLetter] = new List<string>();
                }

                groups[firstLetter].Add(song.Name);
            }

            return groups;
        }

        // Print groups
        public void PrintSongGroups()
        {
            var groupedSongs = GroupSongsByFirstLetter();

            Console.WriteLine($"{Environment.NewLine}All songs in playlist grouped by first letter of their name and sorted lexicographically:");
            //it depends on the shuffle result

            // Order keys alphabetically, otherwise the order depends on the shuffle result
            //OrderBy does not modify the original collection, it returns a new ordered one
            //The lambda expression tells what value to use for ordering (in this case, the key itself which is the first letter of a song in the playlist)

            foreach (var key in groupedSongs.Keys.OrderBy(k => k))
            {

                //sort songs in each group alphabetically

                //StringComparer.OrdinalIgnoreCase - when sorting songs in current group
                // - ignores case
                // - compares all characters in songs names (i.e. sorts lexicographically) 

                var songsInCurrentGroup = groupedSongs[key].OrderBy(songName => songName, StringComparer.OrdinalIgnoreCase);
                Console.WriteLine($"{key}: {string.Join(", ", songsInCurrentGroup)}");
            }
        }
    }
}
