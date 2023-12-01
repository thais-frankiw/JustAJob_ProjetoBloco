using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustAJob.Models
{
    class Fatura
    {
        public decimal Valor { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public Servico Servico { get; set; }

        public void atualizarPagamentoParcial(decimal valor) { }

    }
}


