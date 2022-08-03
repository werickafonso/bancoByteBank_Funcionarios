using ByteBankF.Funcionarios;

namespace ByteBankF.Sistemas
{
    public class SistemaInsterno
    {
        public bool Logar (IAutenticavel funcionario, string senha)
        {
            bool usuarioautenticado = funcionario.Autenticar(senha);

            if (usuarioautenticado)
            {
                System.Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            else
            {
                System.Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}