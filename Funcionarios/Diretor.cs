namespace ByteBankF.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public Diretor(string cpf) : base (5000, cpf)
        {
        }
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}