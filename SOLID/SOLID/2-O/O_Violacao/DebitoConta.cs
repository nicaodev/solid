namespace SOLID._2_O.O_Violacao
{
    public class DebitoConta
    {
        /*
         Viola pois a cada novo tipo de conta, teria que modificar esta classe.
        */

        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                // Debita Conta Corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                // Valida Aniversário da Conta
                // Debita Conta Poupança
            }
        }
    }
}