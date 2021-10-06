using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace KVT0341.Models
{
    public class KVT0341
    {
        [Key]
        [Column(TypeName = "nvarchar(20)")]
        public string KVTId { get; set; }
        [Column(TypeName = "nvarchar(50)")]

        public string KVTName { get; set; }
    }
}