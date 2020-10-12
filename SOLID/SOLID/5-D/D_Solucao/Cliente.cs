﻿using SOLID._5_D.D_Solucao.Interfaces;
using System;

namespace SOLID._5_D.D_Solucao
{
    public class Cliente
    {
        private readonly ICPFServices _cpfServices;
        private readonly IEmailServices _emailServices;

        public Cliente(
            ICPFServices cpfServices,
            IEmailServices emailServices)
        {
            _cpfServices = cpfServices;
            _emailServices = emailServices;
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid()
        {
            return _emailServices.IsValid(Email) && _cpfServices.IsValid(CPF);
        }
    }
}