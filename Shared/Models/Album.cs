using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumCollage.Shared.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
        public string AlbumArt { get; set; }
        public string WikiURL { get; set; }
    }
}
