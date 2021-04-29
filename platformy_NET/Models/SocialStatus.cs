using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace platformy_NET.Models
{
    /// <summary>
    /// Klasa przechowująca parametry statusu społecznościowego
    /// Id-idnetyfikator obiektu
    /// DateTime - Data dodania
    /// Status text - string przedstawiający treść statusu
    /// </summary>
    public class SocialStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [MaxLength]
        public string StatusText { get; set; }
    }
}
