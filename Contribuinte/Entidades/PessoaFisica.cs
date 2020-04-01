namespace Contribuinte.Entidades
{
    internal class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude)
            : base (nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            if(RendaAnual <= 20000.00)
            {
                return 0.15 * RendaAnual - (GastoSaude / 2);
            }
            else
            {
                 return 0.25 * RendaAnual - (GastoSaude / 2);
            }
        }
    }
}