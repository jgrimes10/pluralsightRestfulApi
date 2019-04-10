using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PluralsightRESTfulAPI.Entities
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        
        [MaxLength(50)]
        public string Description { get; set; }
        
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        
        public Guid AuthorId { get; set; }
    }
}