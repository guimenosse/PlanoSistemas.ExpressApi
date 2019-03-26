using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanoSistemas.ExpressApi.Dominio
{
    [Table ("Emitentes")]
    public class CL_Emitente
    {
        [Key]
        public int Codigo { get; set; }
        public string TipoPessoa { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public int NrEndereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string CnpjCpf { get; set; }
        public string RgInscEstadual { get; set; }
        public string Telefone { get; set; }
        public string TelefoneAdicional { get; set; }
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
