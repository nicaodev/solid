﻿namespace SOLID._1_S.S_Solucao
{
    public class ClienteService
    {
        // Fortemente acoplado a EmailServices(Classe) será resolvido no D.
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailServices.Enviar("empresa@empresa.com", cliente.Email, $"{cliente.Nome} Seja bem Vindo", "Parabéns está Cadastrado");
            return "Cliente cadastrado com sucesso";
        }
    }
}