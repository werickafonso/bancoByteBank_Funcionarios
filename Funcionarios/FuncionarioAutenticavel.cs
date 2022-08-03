using ByteBankF.Sistemas;

namespace ByteBankF.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf) : base (salario, cpf)
        {
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}