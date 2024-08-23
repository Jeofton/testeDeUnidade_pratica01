using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
    {
    public class BeneficioService
        {
        public decimal CalcularBeneficios(Funcionario funcionario)
            {           
            return funcionario.Beneficios;
            }
        }
    }
