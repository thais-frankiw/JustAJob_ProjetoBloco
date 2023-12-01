using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JustAJob.Models
{
	class Agenda
    {
		public int[] DiaDaSemanaDeTrabalho { get; set; } = { 1, 2, 3, 4, 5, 6, 7 };
        public Funcionario Funcionario { get; set; }	

        public void VerificarDatasDisponiveis() { }
		public void VerificarSeDataEstaDisponivel(DateTime data) { }
		public void VerificarCompromissos(DateTime periodo) { }
		public void VisualizarFuncionario() { }



    }
}
