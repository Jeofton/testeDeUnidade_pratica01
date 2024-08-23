using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
    {
    public class Funcionario
        {
        public string Nome { get; set; }
        public decimal SalarioBase { get; set; }
        public int HorasTrabalhadas { get; set; }
        public int HorasExtras { get; set; }
        public decimal Beneficios { get; set; }
        public decimal DescontosAdicionais { get; set; }
        }
    }
