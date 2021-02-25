using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Db
{
    public class Cinema
    {
        [Required]
        public int Id { get; set; }
        
        [StringLength(50)]
        [Required]
        public string Type { get; set; }
        
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<ShowTime> ShowTimes { get; set; }

    }
}
