using ByteBankF.Funcionarios;

namespace ByteBankF
{
    public class GerenciadorBonificacao
    {
     private double _totalDeBonificacao;

     public void Registrar(Funcionario funcionario)
     {
      _totalDeBonificacao +=funcionario.GetBonificacao();
     }
     public double GetTotalDeBonificacao()
     {
      return _totalDeBonificacao;
     }
    }
}