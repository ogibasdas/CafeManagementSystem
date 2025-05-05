using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Dto.CntctDto
{
    public class GetCntctDto
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string FooterDescription { get; set; }
    }
}
