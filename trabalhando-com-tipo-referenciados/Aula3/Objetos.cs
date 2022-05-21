using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    public ref struct Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public Endereco EnderecoPessoa { get; set; }
    }

    public ref struct Endereco
    {        
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        Span<int> Numero { get; set; }
    }
}
