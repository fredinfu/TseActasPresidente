using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TseHn2017Application.Dto
{
    public class ActaDto
    {
        public int CodActa { get; set; }
        public int NumNivel { get; set; }
        public string NomNivel { get; set; }
        public int CodMER { get; set; }
        public int CodDepartamento { get; set; }
        public int CodMunicipio { get; set; }
        public string NomDepartamento { get; set; }
        public string NomMunicipio { get; set; }
        public int CodCentroVotacion { get; set; }
        public string NomCentroVotacion { get; set; }
        public int CodEstado { get; set; }
        public string NomEstado { get; set; }
        public int NumVotosValidos { get; set; }
        public int NumVotosBlancos { get; set; }
        public int NumVotosNulos { get; set; }
        public int NumVotosTotal { get; set; }
        public int NumPapeletasRecibidas { get; set; }
        public int NumPapeletasSobrantes { get; set; }
        public int NumPapeletasUtilizadas { get; set; }
        public string CodBarra { get; set; }
        public string Url { get; set; }
        public List<VotoDto> Votos { get; set; }
    }
}
