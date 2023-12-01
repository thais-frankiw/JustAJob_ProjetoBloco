using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustAJob.Models
{
    class Pessoa
    {
        public String Nome { get; set; }
        public decimal Telefone { get; set; }
        public String Email { get; set; }
        public decimal Cpf { get; set; }

        public IList<Imovel> Imoveis { get; set; }

    }
}
    

