using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NET5.Models.Entities
{
    public class Function
    {
        public long Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public int Order { get; set; }
        public bool Delete { get; set; } = false;
        public DateTime? InsertAt { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set; }

        public ICollection<Page> Pages { get; set; }
    }
}
