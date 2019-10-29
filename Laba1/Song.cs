using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Song
    {
       private string name; 
        private string author; 
        private Song prev;

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        internal Song Prev { get => prev; set => prev = value; }
        public Song(String author, String name)
        {
            this.author = author;
            this.name = name;
            this.prev = null; 
        }

        public Song(String author, String name, Song prev)
        {
            this.author = author;
            this.name = name;
            this.prev = prev;
        }

        public Song()
        {

        }
        public void Print()
        {
            Console.WriteLine(this.Title() + " "); 
        }
        
        public String Title()
        {
            return this.name + " " + this.author; 
        }
        
        public override bool Equals(Object obj)
        {
            if(obj is Song)
            {
                Song song = (Song)obj;

                if (name.Equals(song.Name) && author.Equals(song.Author))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}
