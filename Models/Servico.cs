using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JustAJob.Models
{
    class Servico
    {
		public Servico() { }
        public DateTime DataHoraCotacao { get; set; } = DateTime.Now;
        public double Valor { get; set; }
        public bool Avaliacao { get; set; }
        public Imovel Imovel { get; set; }
        public Gerente Gerente { get; set; }
        public Fatura? Fatura { get; set; }
        public IList<Faxineiro> Equipe { get; set; }

        public void MarcarVisitaParaCotacao(DateTime data, Imovel imovel, Gerente gerente) { }
		public void MarcarRealizacaoDoServico(DateTime data) { }
		public void AdicionarMembroAEquipe(Faxineiro faxineiro) { }
		public void AvaliarServico(int nota) { }

    }
}

