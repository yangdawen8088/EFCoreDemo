using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreDemo.Models
{
    class T_blogContent
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength]
        public string Content { get; set; }
        [ForeignKey("T_blogListId")]
        public Guid blogListId { get; set; }
    }
}