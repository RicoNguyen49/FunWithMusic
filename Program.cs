using System;

namespace FunWithMusic
{
    // Music genre enum
    public enum MusicGenre
    {
        Rock,
        Pop,
        HipHop,
        Jazz,
        Electronic
    }

    // Music structure
    public struct Music
    {
        // Variables
        public string Title;
        public string Artist;
        public string Album;
        public TimeSpan Length;
        public MusicGenre Genre;

        // Constructor
        public Music(string title, string artist, string album, TimeSpan length, MusicGenre genre)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Length = length;
            Genre = genre;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Album: {Album}");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Genre: {Genre}");
        }
        // Set method for Title
        public void SetTitle(string title)
        {
            Title = title;
        }

        // Set method for Length
        public void SetLength(TimeSpan length)
        {
            Length = length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompting user for music information
            Console.WriteLine("Enter music information:");

            Console.Write("Title: ");
            string tempTitle = Console.ReadLine();

            Console.Write("Artist: ");
            string tempArtist = Console.ReadLine();

            Console.Write("Album: ");
            string tempAlbum = Console.ReadLine();

            Console.Write("Length (hh:mm:ss): ");
            TimeSpan length;
            TimeSpan.TryParse(Console.ReadLine(), out length);

            Console.WriteLine("Choose genre:");
            Console.WriteLine("R - Rock\nP - Pop\nH - HipHop\nJ - Jazz\nE - Electrionic");
            MusicGenre tempGenre = MusicGenre.Rock;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'R':
                    tempGenre = MusicGenre.Rock;
                    break;
                case 'P':
                    tempGenre = MusicGenre.Pop;
                    break;
                case 'H':
                    tempGenre = MusicGenre.HipHop;
                    break;
                case 'J':
                    tempGenre = MusicGenre.Jazz;
                    break;
                case 'E':
                    tempGenre = MusicGenre.Electronic;
                    break;
            }

            // Creating and displaying music
            Music music = new Music(tempTitle, tempArtist, tempAlbum, length, tempGenre);
            Console.WriteLine("\nMusic Information:");
            music.Display();

            // Step 3: Creating moreMusic structure variable
            Music moreMusic = music;

            //changing values in the new structure variable
            moreMusic.SetLength(TimeSpan.FromMinutes(2));
            moreMusic.SetTitle("In my life");
            //Printing the new movie
            Console.WriteLine("Here's song #2");
            moreMusic.Display();
            Console.WriteLine();
        }
    }
}

