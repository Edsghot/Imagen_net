using _5._0.DataAccessLayer.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0.DataAccessLayer.Entities
{
    [Table("tgallery")]
    public class Gallery 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string idGallery{ get; set; }
        public string imageValue { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string extension { get; set; }
    }
}
