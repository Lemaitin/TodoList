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

        [Required]
        [ForeignKey("StatusID")]
        public Status Status { get; set; }

        [ForeignKey("DeadlineID")]
        public Deadline Deadline { get; set; }
    }
}