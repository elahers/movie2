using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Db
{
    public class ShowTime
    {
        public DateTime Time { get; set; }
        public int CinemaId { get; set; }
        public virtual Cinema Cinema { get; set;}
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
