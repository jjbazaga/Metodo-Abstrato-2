namespace Contribuinte.Entidades
{
    class PessoaJuridica : Pessoa
    {
        public int Numero { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numero)
            : base (nome, rendaAnual)
        {
            Numero = numero;
        }

        public override double Imposto()
        {
            if(Numero <= 10)
            {
                return 0.16 * RendaAnual;
            }
            else
            {
                return 0.14 * RendaAnual;
            }
        }
    }
}