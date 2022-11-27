using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumProgram
{
    public class Album
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> ImagePath { get; set; }

        public Album()
        {
            ImagePath= new List<string>();
        }

        public override string ToString()
        {
            return $"{Name} Albümü {ImagePath.Count} Fotoğraf";
        }
    }
}
