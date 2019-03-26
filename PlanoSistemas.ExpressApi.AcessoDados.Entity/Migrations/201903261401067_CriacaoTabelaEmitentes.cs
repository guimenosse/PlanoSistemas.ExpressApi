namespace PlanoSistemas.ExpressApi.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoTabelaEmitentes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emitentes",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        TipoPessoa = c.String(),
                        Nome = c.String(),
                        Cep = c.String(),
                        Endereco = c.String(),
                        NrEndereco = c.Int(nullable: false),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        Estado = c.String(),
                        Cidade = c.String(),
                        CnpjCpf = c.String(),
                        RgInscEstadual = c.String(),
                        Telefone = c.String(),
                        TelefoneAdicional = c.String(),
                        Email = c.String(),
                        Observacao = c.String(),
                        NomeFantasia = c.String(),
                        EmailProcNfe = c.String(),
                        DtNascimento = c.DateTime(nullable: false),
                        DtCadastro = c.DateTime(nullable: false),
                        DtUltAlteracao = c.DateTime(nullable: false),
                        FgAtivo = c.String(),
                        FgCliente = c.String(),
                        FgVendedor = c.String(),
                        FgFornecedor = c.String(),
                        FgTransportadora = c.String(),
                        FgFilial = c.String(),
                        FgContribuinte = c.String(),
                        FgConsumidorFinal = c.String(),
                        FgCalculaDifal = c.String(),
                        FgSincronizado = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emitentes");
        }
    }
}
