using System;
using System.ComponentModel.DataAnnotations;

namespace NET5.Models.Entities
{
    public class Page
    {
        public long Id { get; set; }
        [Required]
        public Function Function { get; set; }
        [Required]
        public string Name { get; set; }
        public string Area { get; set; }
        [Required]
        public string Level1 { get; set; }
        public string Level2 { get; set; }
        public string Level3 { get; set; }
        public string Level4 { get; set; }
        [Required]
        public string LevelView { get; set; }
        [Required]
        public string RootParam { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public int Order { get; set; }
        public bool Delete { get; set; } = false;
        public DateTime? InsertAt { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set; }
    }
}
