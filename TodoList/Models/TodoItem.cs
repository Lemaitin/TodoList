using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    [Table("TodoItem")]
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        
        public Status Status { get; set; }
        
        public Deadline Deadline { get; set; }

        [ForeignKey("DeadlineID")]
        public int? DeadlineId { get; set; }

        [Required]
        [ForeignKey("StatusID")]
        public int StatusId { get; set; }
    }
}