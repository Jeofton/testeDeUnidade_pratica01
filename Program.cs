using FolhaPagamento;

class Program
    {
    static void Main(string[] args)
        {
        var funcionario = new Funcionario
            {
            Nome = "João",
            SalarioBase = 4000,
            HorasTrabalhadas = 160,
            HorasExtras = 10,
            Beneficios = 500,
            DescontosAdicionais = 200
            };

        var impostoService = new ImpostoService();
        var beneficioService = new BeneficioService();
        var descontoService = new DescontoService();
        var calculadoraFolha = new CalculadoraFolhaPagamento(impostoService, beneficioService, descontoService);
        var folhaPagamento = calculadoraFolha.Calcular(funcionario);

        Console.WriteLine($"Salário Bruto: {folhaPagamento.SalarioBruto:C}");
        Console.WriteLine($"Benefícios: {folhaPagamento.TotalBeneficios:C}");
        Console.WriteLine($"Descontos Adicionais: {folhaPagamento.TotalDescontos:C}");
        Console.WriteLine($"Imposto: {folhaPagamento.Imposto:C}");
        Console.WriteLine($"Salário Líquido: {folhaPagamento.SalarioLiquido:C}");
        }
    }
