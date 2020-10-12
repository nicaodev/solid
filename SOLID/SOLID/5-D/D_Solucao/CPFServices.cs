using SOLID._5_D.D_Solucao.Interfaces;

namespace SOLID._5_D.D_Solucao
{
    public class CPFServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}