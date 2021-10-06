using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace KieuVanThang341.Models
{
    public class KVT341
    {
        [Key]
        [Column(TypeName = "nvarchar(20)")]
        public string PersonId { get; set; }
        [Column(TypeName = "nvarchar(50)")]

        public string PersonName { get; set; }
    }
}