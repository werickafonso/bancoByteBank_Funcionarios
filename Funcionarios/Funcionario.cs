namespace ByteBankF.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }    
        public string CPF { get; private set; }    
        public double Salario { get; protected set; }
        public string Senha { get; set; }

        public abstract void AumentarSalario();
        
        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;
            Salario = salario;
            CPF = cpf;
        }
        public abstract double GetBonificacao();

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }        
    }
}