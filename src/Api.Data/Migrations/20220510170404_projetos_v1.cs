using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class projetos_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AtividadePrioridade",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadePrioridade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AtividadeStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadeStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaseProjeto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaseProjeto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjetoPrioridade",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoPrioridade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjetoStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestaoPrioridade",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestaoPrioridade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestaoStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestaoStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoArquivo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 100, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoArquivo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uf",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Sigla = table.Column<string>(maxLength: 2, nullable: false),
                    Nome = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    telefone = table.Column<string>(nullable: true),
                    habilidades = table.Column<string>(maxLength: 500, nullable: true),
                    observacoes = table.Column<string>(maxLength: 500, nullable: true),
                    valorHora = table.Column<decimal>(nullable: false),
                    cargo = table.Column<string>(maxLength: 100, nullable: true),
                    EmpresaId = table.Column<Guid>(nullable: false),
                    DepartamentoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recurso_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recurso_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projeto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    lider = table.Column<string>(maxLength: 200, nullable: false),
                    dono = table.Column<string>(maxLength: 200, nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: true),
                    EmpresaId = table.Column<Guid>(nullable: false),
                    descricao = table.Column<string>(maxLength: 1000, nullable: true),
                    inicio = table.Column<DateTime>(nullable: false),
                    planejamentofim = table.Column<DateTime>(nullable: false),
                    percentualConclusao = table.Column<decimal>(nullable: false),
                    custoEstimado = table.Column<decimal>(nullable: false),
                    custoAtual = table.Column<decimal>(nullable: false),
                    percentualOrcamento = table.Column<decimal>(nullable: false),
                    estimativaHora = table.Column<int>(nullable: false),
                    horaAtual = table.Column<int>(nullable: false),
                    prioridadeGuid = table.Column<Guid>(nullable: false),
                    prioridadeId = table.Column<Guid>(nullable: true),
                    statusGuid = table.Column<Guid>(nullable: false),
                    statusId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projeto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projeto_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projeto_ProjetoPrioridade_prioridadeId",
                        column: x => x.prioridadeId,
                        principalTable: "ProjetoPrioridade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projeto_ProjetoStatus_statusId",
                        column: x => x.statusId,
                        principalTable: "ProjetoStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    CodIBGE = table.Column<int>(nullable: false),
                    UfId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipio_Uf_UfId",
                        column: x => x.UfId,
                        principalTable: "Uf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Atividade",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    projetoid = table.Column<Guid>(nullable: false),
                    faseprojetoid = table.Column<Guid>(nullable: false),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    marco = table.Column<bool>(nullable: false),
                    duracao = table.Column<int>(nullable: false),
                    inicio = table.Column<DateTime>(nullable: false),
                    fim = table.Column<DateTime>(nullable: false),
                    diasatraso = table.Column<int>(nullable: false),
                    atividadestatusid = table.Column<Guid>(nullable: false),
                    percentualcompleto = table.Column<decimal>(nullable: false),
                    atividadeprioridadeid = table.Column<Guid>(nullable: false),
                    atribuidoarecursoid = table.Column<Guid>(nullable: false),
                    historico = table.Column<string>(nullable: true),
                    atividadeprecedeid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atividade_Atividade_atividadeprecedeid",
                        column: x => x.atividadeprecedeid,
                        principalTable: "Atividade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atividade_AtividadePrioridade_atividadeprioridadeid",
                        column: x => x.atividadeprioridadeid,
                        principalTable: "AtividadePrioridade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atividade_AtividadeStatus_atividadestatusid",
                        column: x => x.atividadestatusid,
                        principalTable: "AtividadeStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atividade_Recurso_atribuidoarecursoid",
                        column: x => x.atribuidoarecursoid,
                        principalTable: "Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atividade_FaseProjeto_faseprojetoid",
                        column: x => x.faseprojetoid,
                        principalTable: "FaseProjeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atividade_Projeto_projetoid",
                        column: x => x.projetoid,
                        principalTable: "Projeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartaoTempo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    projetoid = table.Column<Guid>(nullable: false),
                    recursoid = table.Column<Guid>(nullable: false),
                    semanaini = table.Column<DateTime>(nullable: false),
                    hdom = table.Column<int>(nullable: false),
                    hseg = table.Column<int>(nullable: false),
                    hter = table.Column<int>(nullable: false),
                    hqua = table.Column<int>(nullable: false),
                    hqui = table.Column<int>(nullable: false),
                    hsex = table.Column<int>(nullable: false),
                    hsab = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartaoTempo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartaoTempo_Projeto_projetoid",
                        column: x => x.projetoid,
                        principalTable: "Projeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartaoTempo_Recurso_recursoid",
                        column: x => x.recursoid,
                        principalTable: "Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentoProjeto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    projetoid = table.Column<Guid>(nullable: false),
                    titulo = table.Column<string>(nullable: false),
                    descricao = table.Column<string>(nullable: true),
                    arquivoblob = table.Column<byte[]>(nullable: true),
                    idtipoArquivo = table.Column<Guid>(nullable: false),
                    tipoArquivoId = table.Column<Guid>(nullable: true),
                    formatoArquivo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoProjeto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentoProjeto_Projeto_projetoid",
                        column: x => x.projetoid,
                        principalTable: "Projeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentoProjeto_TipoArquivo_tipoArquivoId",
                        column: x => x.tipoArquivoId,
                        principalTable: "TipoArquivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    descricao = table.Column<string>(nullable: false),
                    recursoCriadorid = table.Column<Guid>(nullable: false),
                    projetoid = table.Column<Guid>(nullable: false),
                    prioridadeid = table.Column<Guid>(nullable: false),
                    statusid = table.Column<Guid>(nullable: false),
                    atualizacoes = table.Column<string>(nullable: true),
                    resolucao = table.Column<string>(nullable: true),
                    dataidentificacao = table.Column<DateTime>(nullable: false),
                    diasresolver = table.Column<int>(nullable: false),
                    dataresolucao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questao_QuestaoPrioridade_prioridadeid",
                        column: x => x.prioridadeid,
                        principalTable: "QuestaoPrioridade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questao_Projeto_projetoid",
                        column: x => x.projetoid,
                        principalTable: "Projeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questao_Recurso_recursoCriadorid",
                        column: x => x.recursoCriadorid,
                        principalTable: "Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questao_QuestaoStatus_statusid",
                        column: x => x.statusid,
                        principalTable: "QuestaoStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cep",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Cep = table.Column<string>(maxLength: 10, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 60, nullable: false),
                    Numero = table.Column<string>(maxLength: 10, nullable: true),
                    MunicipioId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cep_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentoHistorico",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    documentoid = table.Column<Guid>(nullable: false),
                    revisao = table.Column<int>(nullable: false),
                    arquivoblob = table.Column<byte[]>(nullable: true),
                    formatoArquivo = table.Column<string>(nullable: true),
                    atual = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoHistorico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentoHistorico_DocumentoProjeto_documentoid",
                        column: x => x.documentoid,
                        principalTable: "DocumentoProjeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Uf",
                columns: new[] { "Id", "CreateAt", "Nome", "Sigla", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9191), "Acre", "AC", null },
                    { new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9426), "São Paulo", "SP", null },
                    { new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9421), "Sergipe", "SE", null },
                    { new Guid("b81f95e0-f226-4afd-9763-290001637ed4"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9416), "Santa Catarina", "SC", null },
                    { new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9411), "Rio Grande do Sul", "RS", null },
                    { new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9407), "Roraima", "RR", null },
                    { new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9403), "Rondônia", "RO", null },
                    { new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9399), "Rio Grande do Norte", "RN", null },
                    { new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9394), "Rio de Janeiro", "RJ", null },
                    { new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9390), "Paraná", "PR", null },
                    { new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9385), "Piauí", "PI", null },
                    { new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9381), "Pernambuco", "PE", null },
                    { new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9377), "Paraíba", "PB", null },
                    { new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9373), "Pará", "PA", null },
                    { new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9368), "Mato Grosso", "MT", null },
                    { new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9364), "Mato Grosso do Sul", "MS", null },
                    { new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9359), "Minas Gerais", "MG", null },
                    { new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9355), "Maranhão", "MA", null },
                    { new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9351), "Goiás", "GO", null },
                    { new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9346), "Espírito Santo", "ES", null },
                    { new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9342), "Distrito Federal", "DF", null },
                    { new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9337), "Ceará", "CE", null },
                    { new Guid("5abca453-d035-4766-a81b-9f73d683a54b"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9333), "Bahia", "BA", null },
                    { new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9328), "Amapá", "AP", null },
                    { new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9322), "Amazonas", "AM", null },
                    { new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9313), "Alagoas", "AL", null },
                    { new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"), new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9431), "Tocantins", "TO", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("6494e4dc-2fa7-4a1d-bff3-816f62d775fc"), new DateTime(2022, 5, 10, 14, 4, 3, 708, DateTimeKind.Local).AddTicks(219), "edervelludo@mail.com", "Administrador", new DateTime(2022, 5, 10, 14, 4, 3, 709, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_atividadeprecedeid",
                table: "Atividade",
                column: "atividadeprecedeid");

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_atividadeprioridadeid",
                table: "Atividade",
                column: "atividadeprioridadeid");

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_atividadestatusid",
                table: "Atividade",
                column: "atividadestatusid");

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_atribuidoarecursoid",
                table: "Atividade",
                column: "atribuidoarecursoid");

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_faseprojetoid",
                table: "Atividade",
                column: "faseprojetoid");

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_projetoid",
                table: "Atividade",
                column: "projetoid");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadePrioridade_nome",
                table: "AtividadePrioridade",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AtividadeStatus_nome",
                table: "AtividadeStatus",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartaoTempo_projetoid",
                table: "CartaoTempo",
                column: "projetoid");

            migrationBuilder.CreateIndex(
                name: "IX_CartaoTempo_recursoid",
                table: "CartaoTempo",
                column: "recursoid");

            migrationBuilder.CreateIndex(
                name: "IX_Cep_Cep",
                table: "Cep",
                column: "Cep");

            migrationBuilder.CreateIndex(
                name: "IX_Cep_MunicipioId",
                table: "Cep",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_nome",
                table: "Departamento",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoHistorico_documentoid",
                table: "DocumentoHistorico",
                column: "documentoid");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoProjeto_projetoid",
                table: "DocumentoProjeto",
                column: "projetoid");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoProjeto_tipoArquivoId",
                table: "DocumentoProjeto",
                column: "tipoArquivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_nome",
                table: "Empresa",
                column: "nome");

            migrationBuilder.CreateIndex(
                name: "IX_FaseProjeto_nome",
                table: "FaseProjeto",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_CodIBGE",
                table: "Municipio",
                column: "CodIBGE");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_UfId",
                table: "Municipio",
                column: "UfId");

            migrationBuilder.CreateIndex(
                name: "IX_Projeto_EmpresaId",
                table: "Projeto",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Projeto_dono",
                table: "Projeto",
                column: "dono");

            migrationBuilder.CreateIndex(
                name: "IX_Projeto_lider",
                table: "Projeto",
                column: "lider");

            migrationBuilder.CreateIndex(
                name: "IX_Projeto_prioridadeId",
                table: "Projeto",
                column: "prioridadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Projeto_statusId",
                table: "Projeto",
                column: "statusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPrioridade_nome",
                table: "ProjetoPrioridade",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoStatus_nome",
                table: "ProjetoStatus",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questao_prioridadeid",
                table: "Questao",
                column: "prioridadeid");

            migrationBuilder.CreateIndex(
                name: "IX_Questao_projetoid",
                table: "Questao",
                column: "projetoid");

            migrationBuilder.CreateIndex(
                name: "IX_Questao_recursoCriadorid",
                table: "Questao",
                column: "recursoCriadorid");

            migrationBuilder.CreateIndex(
                name: "IX_Questao_statusid",
                table: "Questao",
                column: "statusid");

            migrationBuilder.CreateIndex(
                name: "IX_QuestaoPrioridade_nome",
                table: "QuestaoPrioridade",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestaoStatus_nome",
                table: "QuestaoStatus",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_DepartamentoId",
                table: "Recurso",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_EmpresaId",
                table: "Recurso",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoArquivo_nome",
                table: "TipoArquivo",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uf_Sigla",
                table: "Uf",
                column: "Sigla",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atividade");

            migrationBuilder.DropTable(
                name: "CartaoTempo");

            migrationBuilder.DropTable(
                name: "Cep");

            migrationBuilder.DropTable(
                name: "DocumentoHistorico");

            migrationBuilder.DropTable(
                name: "Questao");

            migrationBuilder.DropTable(
                name: "AtividadePrioridade");

            migrationBuilder.DropTable(
                name: "AtividadeStatus");

            migrationBuilder.DropTable(
                name: "FaseProjeto");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "DocumentoProjeto");

            migrationBuilder.DropTable(
                name: "QuestaoPrioridade");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "QuestaoStatus");

            migrationBuilder.DropTable(
                name: "Uf");

            migrationBuilder.DropTable(
                name: "Projeto");

            migrationBuilder.DropTable(
                name: "TipoArquivo");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "ProjetoPrioridade");

            migrationBuilder.DropTable(
                name: "ProjetoStatus");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6494e4dc-2fa7-4a1d-bff3-816f62d775fc"));
        }
    }
}
