namespace ByteBankF.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public GerenteDeContas(string cpf) : base (4000, cpf)
        {
        }
        public override double GetBonificacao()
        {
            return Salario * 0.4;
        }
    }
}