﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Marca Marca { get; set; }
    }
}
