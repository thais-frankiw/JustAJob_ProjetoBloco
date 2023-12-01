namespace JustAJob.Models
{
	class Imovel
    {
		public Cliente Cliente { get; set; }
		public String Logradouro { get; set; } = "";
        public String Numero { get; set; } = "";
        public String Complemento { get; set; } = "";
        public String Bairro { get; set; } = "";
        public String Cidade { get; set; } = "";
        public String Estado { get; set; } = "";
        public decimal Cep { get; set; }
        public IList<Servico>? Servicos { get; set; }

        public void VisualizarDadosDoImovel() { }
		public void VisualizarDadosDoProprietario() { }
		public void VisualizarHistoricoServicos() { }

    }
}
