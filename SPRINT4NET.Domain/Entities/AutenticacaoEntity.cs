using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT4NET.Domain.Entities
{
    public class AutenticacaoEntity
    {
        public String Token { get; set; }
        public DateTime Expiration {  get; set; }

    }
}
