using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<string> Song { get; set; }


        public CD(string name, string artist, List<string> song)
        {
            Name = name;
            Artist = artist;
            Song = song;
        }

        public override string ToString()
        {
            //var ListSongs = new List<string>();

            foreach (string a in Song)
            {
                return a;
            }
            return Name + Artist;
        }


    }
}
