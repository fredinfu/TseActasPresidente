using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TseHn2017Application.Dto
{
    public class VotoDto
    {
        public int CodCandidato { get; set; }
        public string NomCandidato { get; set; }
        public string IdentidadCandidato { get; set; }
        public int CodPartido { get; set; }
        public string NomPartido { get; set; }
        public int NumVotos { get; set; }
        public int NumPosicion { get; set; }
    }
}
