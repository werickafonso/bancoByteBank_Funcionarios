namespace ByteBankF
{
    public class ParceiroComercial
    {
        public string Senha { get; set; }   
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}