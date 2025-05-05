using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Dto.BkngDto
{
   public class ResBkngDto  //ismini RsltBkngDto yapmam lazımdı ama üsendim.. karismasin 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public int PerCount { get; set; }
        public DateTime Date { get; set; }
    }
}
