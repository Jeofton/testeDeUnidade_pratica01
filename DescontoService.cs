using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
    {
    public class DescontoService
        {
        public decimal CalcularDescontos(Funcionario funcionario)
            {            
            return funcionario.DescontosAdicionais;
            }
        }
    }
