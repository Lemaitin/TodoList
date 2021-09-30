using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    [Table("Deadline")]
    public class Deadline
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DeadlineDate { get; set; }

        [Required]
        [ForeignKey("DeadlineTypeID")]
        public DeadlineType DeadlineType { get; set; }
    }
}