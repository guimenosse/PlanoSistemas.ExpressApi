using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlanoSistemas.ExpressApi.Api.DTOs
{
    public class CL_EmitenteDTO
    {
        public int Codigo { get; set; }
        public string TipoPessoa { get; set; }
        [Required(ErrorMessage = "O nome é um campo obrigatório")]
        [StringLength(maximumLength:20, MinimumLength =2, ErrorMessage = "O nome do aluno deve conter entre 2 e 20 caracteres")]
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public int NrEndereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O CNPJ ou CPJ é obrigatório")]
        public string CnpjCpf { get; set; }
        public string RgInscEstadual { get; set; }
        public string Telefone { get; set; }
        public string TelefoneAdicional { get; set; }
        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; }
        public string Observacao { get; set; }
        public string NomeFantasia { get; set; }
        public string EmailProcNfe { get; set; }
        public DateTime DtNascimento { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime DtUltAlteracao { get; set; }
        public string FgAtivo { get; set; }
        public string FgCliente { get; set; }
        public string FgVendedor { get; set; }
        public string FgFornecedor { get; set; }
        public string FgTransportadora { get; set; }
        public string FgFilial { get; set; }
        public string FgContribuinte { get; set; }
        public string FgConsumidorFinal { get; set; }
        public string FgCalculaDifal { get; set; }
        public string FgSincronizado { get; set; }
    }
}