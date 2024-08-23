using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
    {
    public class ImpostoService
        {
        public decimal CalcularImposto(decimal salarioBruto)
            {
            // Exemplo simples de cálculo de imposto
            if(salarioBruto <= 3000)
                {
                return salarioBruto * 0.1m; // 10% de imposto
                }
            else if(salarioBruto <= 6000)
                {
                return salarioBruto * 0.2m; // 20% de imposto
                }
            else
                {
                return salarioBruto * 0.3m; // 30% de imposto
                }
            }
        }
    }
