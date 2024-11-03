using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT4NET.Domain.DTOs
{
    public class AutenticacaoDTO
    {
        public String Token { get; set; }
        public DateTime Expiration { get; set; }

    }
}
