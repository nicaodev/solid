namespace SOLID._5_D.D_Solucao.Interfaces
{
    public interface IEmailServices
    {
        bool IsValid(string email);

        void Enviar(string de, string para, string assunto, string mensagem);
    }
}