﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT4NET.Domain.DTOs
{
    public class URLResponseDTO
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public Dictionary<string, string> Resultados { get; set; }
    }
}