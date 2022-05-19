﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }

        public Pessoa Clone()
        {
            return new Pessoa()
            {
                Documento = this.Documento,
                Nome = this.Nome,
                Idade = this.Idade
            };
        }

    }
}
