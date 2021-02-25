using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Db
{
    public class Reserve
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }


    }
}
