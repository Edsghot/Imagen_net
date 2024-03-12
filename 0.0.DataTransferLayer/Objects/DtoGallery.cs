using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0._0.DataTransferLayer.Generic;

namespace _0._0.DataTransferLayer.Objects
{
    public class DtoGallery
    {
        public string idGallery { get; set; }
        public string imageValue { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string extension { get; set; }
    }
}
