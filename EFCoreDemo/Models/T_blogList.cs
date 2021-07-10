using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreDemo.Models
{
    class T_blogList
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public DateTime creationDateTime { get; set; }
        [Required]
        [MaxLength(100)]
        public string author { get; set; }
    }
}
