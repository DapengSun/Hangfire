using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireClient
{
    public class TestClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        //[Key]
        //public string Id { get; set; }
        [MaxLength(200, ErrorMessage = "")]
        public string Title { get; set; }
        [MaxLength(500, ErrorMessage = "")]
        public string Content { get; set; }
        public DateTime CDate { get; set; }
    }
}
