namespace Sistema_Bancario_A.Models
{
    // Classe abstrata aplicando o pilar da abstração
    // Uma classe abstrata não pode ser instanciada
    public abstract class ContaBancaria
    {
        // Pilar encapsulamento: Campos privados protegidos por propriedades públicas
        private string _numeroConta;
        private decimal _saldo;

        public string NumeroConta
        {
            get => _numeroConta;
            protected set => _numeroConta = value;
        }
        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value;
        }
        public string NomeTitular { get; set; }

        public List<string> ExtratoTransacoes { get; set; } = new List<string>();
        //Construtor da classe base

        protected ContaBancaria(string numeroConta, decimal saldoInicial, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
            ExtratoTransacoes.Add($"Conta criada com saldo de R${saldoInicial}"); 
        }


       public virtual void Depositar(decimal Vaalor)
        {
            if (Saldo > 0) 
            {
                Saldo += Saldo;
            }

        }
        public abstract bool Sacar(decimal valor);

    }
}
