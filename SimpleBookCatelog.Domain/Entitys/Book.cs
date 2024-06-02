using SimpleBookCatelog.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookCatelog.Domain.Entitys
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please provite a title")]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required(ErrorMessage ="Please provite the author's name")]
        [StringLength(100)]
        public string? Author { get; set; }
        public DateTime? PublicationDate { get; set; }
        [EnumDataType(typeof(Category), ErrorMessage ="Please select a category")]
        public Category Category { get; set; }
    }
}
