using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
    {
    public class CalculadoraFolhaPagamento
        {
        private readonly ImpostoService _impostoService;
        private readonly BeneficioService _beneficioService;
        private readonly DescontoService _descontoService;

        public CalculadoraFolhaPagamento(ImpostoService impostoService, BeneficioService beneficioService, DescontoService descontoService)
            {
            _impostoService = impostoService;
            _beneficioService = beneficioService;
            _descontoService = descontoService;
            }

        public FolhaPagamento Calcular(Funcionario funcionario)
            {
            var folhaPagamento = new FolhaPagamento();

            folhaPagamento.SalarioBruto = CalcularSalarioBruto(funcionario);
            
            folhaPagamento.TotalBeneficios = _beneficioService.CalcularBeneficios(funcionario);

            folhaPagamento.TotalDescontos = _descontoService.CalcularDescontos(funcionario);

            folhaPagamento.Imposto = _impostoService.CalcularImposto(folhaPagamento.SalarioBruto);

            folhaPagamento.SalarioLiquido = folhaPagamento.SalarioBruto + folhaPagamento.TotalBeneficios - folhaPagamento.Imposto - folhaPagamento.TotalDescontos;

            return folhaPagamento;
            }

        private decimal CalcularSalarioBruto(Funcionario funcionario)
            {
            var salarioBruto = funcionario.SalarioBase;
            
            if(funcionario.HorasExtras > 0)
                {
                var valorHoraExtra = funcionario.SalarioBase / 160 * 1.5m;
                salarioBruto += funcionario.HorasExtras * valorHoraExtra;
                }

            return salarioBruto;
            }
        }
    }
