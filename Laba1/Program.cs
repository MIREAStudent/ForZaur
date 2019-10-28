using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Song> songs = new List<Song>();

            Song song1 = new Song();
            song1.Author = "John Lee Hooker";
            song1.Name = "Strike Blues";

            Song song2 = new Song();
            song2.Author = "Bill Withers";
            song2.Name = "Aint no sunshine";

            Song song3 = new Song();
            song3.Author = "СЛАВА КПСС feat СТАС АЙ КАК ПРОСТО";
            song3.Name = "КАПИТАЛ";

            Song song4 = new Song();
            song4.Author = "John Lee Hooker";
            song4.Name = "Strike Blues";

            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            songs.Add(song4);

            Song prev = null; 
            foreach(Song song in songs)
            {
                song.Prev = prev;
                prev = song;

            }

            foreach (Song song in songs)
            {
                song.Print();
                try
                {
                    Console.WriteLine("предыдущий исполнитель");
                    song.Prev.Print();
                } catch(NullReferenceException e)
                {
                    Console.WriteLine(" Не существует");
                }
            }   

            foreach (Song song in songs)
            {

                Console.WriteLine(song.Equals(song.Prev));


            }
            Console.WriteLine(song1.Equals(song2.Prev));
            Console.WriteLine(song1.Equals(song2));
            Console.WriteLine(song3.Equals(null));
            Console.WriteLine(song3.Equals(song3));
            Console.WriteLine(song1.Equals(song4));
          
            Console.ReadKey();
           

        }
    }
}
