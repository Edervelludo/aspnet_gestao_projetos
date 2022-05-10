using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class projetos_v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6494e4dc-2fa7-4a1d-bff3-816f62d775fc"));

            migrationBuilder.InsertData(
                table: "AtividadePrioridade",
                columns: new[] { "Id", "CreateAt", "UpdateAt", "descricao", "nome" },
                values: new object[,]
                {
                    { new Guid("a867caad-b25f-43ed-9a6d-4c8861687d30"), new DateTime(2022, 5, 10, 17, 25, 6, 130, DateTimeKind.Utc).AddTicks(1221), null, "De prioridade baixa.", "BAIXA" },
                    { new Guid("e8cfca45-1dbe-421b-ad28-e1fbcc03d86a"), new DateTime(2022, 5, 10, 17, 25, 6, 130, DateTimeKind.Utc).AddTicks(1311), null, "De prioridade média.", "MEDIA" },
                    { new Guid("e5e900b9-742d-4c1c-9ddf-b9f2c77506db"), new DateTime(2022, 5, 10, 17, 25, 6, 130, DateTimeKind.Utc).AddTicks(1315), null, "De prioridade alta", "ALTA" },
                    { new Guid("017db0c7-b1da-426c-bdcd-04ebbadc2516"), new DateTime(2022, 5, 10, 17, 25, 6, 130, DateTimeKind.Utc).AddTicks(1339), null, "De prioridade mais alta", "MUITO ALTA" }
                });

            migrationBuilder.InsertData(
                table: "AtividadeStatus",
                columns: new[] { "Id", "CreateAt", "UpdateAt", "descricao", "nome" },
                values: new object[,]
                {
                    { new Guid("3f017fa7-abff-4875-a523-be070ca8a183"), new DateTime(2022, 5, 10, 17, 25, 6, 130, DateTimeKind.Utc).AddTicks(9987), null, "Atividade não iniciada", "NÃO-INICIADA" },
                    { new Guid("29fe3813-c4a4-4232-a30c-07df3f68c0fc"), new DateTime(2022, 5, 10, 17, 25, 6, 130, DateTimeKind.Utc).AddTicks(9984), null, "Atividade em progresso", "EM-PROGRESSO" },
                    { new Guid("3042a696-bc65-4b6c-82bf-f4ad663a963d"), new DateTime(2022, 5, 10, 17, 25, 6, 130, DateTimeKind.Utc).AddTicks(9990), null, "Atividade em espera.", "EM-ESPERA" },
                    { new Guid("a8a0fec9-4fbb-4b8c-8dfb-b684ecce0002"), new DateTime(2022, 5, 10, 17, 25, 6, 130, DateTimeKind.Utc).AddTicks(9870), null, "Atividade Completa.", "COMPLETA" },
                    { new Guid("fbc4c359-c3ea-408c-ad43-b2f2fd0fada7"), new DateTime(2022, 5, 10, 17, 25, 6, 130, DateTimeKind.Utc).AddTicks(9979), null, "Atividade Incompleta.", "INCOMPLETA" }
                });

            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "Id", "CreateAt", "UpdateAt", "descricao", "nome" },
                values: new object[,]
                {
                    { new Guid("7be4665b-e72f-4a8e-b371-61cc8514c47a"), new DateTime(2022, 5, 10, 17, 25, 6, 131, DateTimeKind.Utc).AddTicks(9749), null, "Operações", "Operação" },
                    { new Guid("003ad2d7-b34c-4e84-9c56-02ef535941da"), new DateTime(2022, 5, 10, 17, 25, 6, 131, DateTimeKind.Utc).AddTicks(9853), null, "Financeiro", "Financeiro" },
                    { new Guid("95cc2696-28ee-45a7-8b7c-2ac7082d47be"), new DateTime(2022, 5, 10, 17, 25, 6, 131, DateTimeKind.Utc).AddTicks(9876), null, "Engenharia", "Engenharia" },
                    { new Guid("2b3d5122-3eff-4aa8-a820-25c0f99d3176"), new DateTime(2022, 5, 10, 17, 25, 6, 131, DateTimeKind.Utc).AddTicks(9881), null, "Tecnologia da Informação", "Tecnologia da Informação" },
                    { new Guid("bec0f472-8610-4e6e-b86a-bcb089cf66f8"), new DateTime(2022, 5, 10, 17, 25, 6, 131, DateTimeKind.Utc).AddTicks(9885), null, "Qualidade", "Qualidade" },
                    { new Guid("b14781c0-6fa3-4fe8-a7fd-972504d533f6"), new DateTime(2022, 5, 10, 17, 25, 6, 131, DateTimeKind.Utc).AddTicks(9888), null, "Gestão", "Gestão" },
                    { new Guid("59aedd05-599f-4b76-bf9a-f67a84bf5f9e"), new DateTime(2022, 5, 10, 17, 25, 6, 131, DateTimeKind.Utc).AddTicks(9892), null, "Marketing", "Marketing" }
                });

            migrationBuilder.InsertData(
                table: "FaseProjeto",
                columns: new[] { "Id", "CreateAt", "UpdateAt", "descricao", "nome" },
                values: new object[,]
                {
                    { new Guid("902be417-9965-45b8-8899-77c484af7238"), new DateTime(2022, 5, 10, 17, 25, 6, 132, DateTimeKind.Utc).AddTicks(8115), null, "Fase de Produção", "PRODUÇÃO" },
                    { new Guid("ff417a5d-77b1-4188-835b-61553e03b761"), new DateTime(2022, 5, 10, 17, 25, 6, 132, DateTimeKind.Utc).AddTicks(8111), null, "Fase de Teste", "TESTE" },
                    { new Guid("c04e1456-599d-4f12-b887-1b2882bef82a"), new DateTime(2022, 5, 10, 17, 25, 6, 132, DateTimeKind.Utc).AddTicks(8083), null, "fFase de Ptojeto.", "PROJETO" },
                    { new Guid("dd015770-2b92-4b10-ba9e-2bce2164be74"), new DateTime(2022, 5, 10, 17, 25, 6, 132, DateTimeKind.Utc).AddTicks(7964), null, "Fase de PLanejamento", "PLANEJAMENTO" },
                    { new Guid("8cba4356-9a28-48c1-a65e-72bd1167a496"), new DateTime(2022, 5, 10, 17, 25, 6, 132, DateTimeKind.Utc).AddTicks(8087), null, "Fase de Desenvolvimento.", "DESENVOLVIMENTO" }
                });

            migrationBuilder.InsertData(
                table: "ProjetoPrioridade",
                columns: new[] { "Id", "CreateAt", "UpdateAt", "descricao", "nome" },
                values: new object[,]
                {
                    { new Guid("2a1f84e6-a84e-4221-b349-75b9118e0562"), new DateTime(2022, 5, 10, 17, 25, 6, 133, DateTimeKind.Utc).AddTicks(5635), null, "De prioridade baixa.", "BAIXA" },
                    { new Guid("a7dba6e8-fcff-4c3c-ade2-ddb3a92413e8"), new DateTime(2022, 5, 10, 17, 25, 6, 133, DateTimeKind.Utc).AddTicks(5736), null, "De prioridade média.", "MEDIA" },
                    { new Guid("2b81ac70-f92e-4d53-86f9-b51b3fe1dde3"), new DateTime(2022, 5, 10, 17, 25, 6, 133, DateTimeKind.Utc).AddTicks(5743), null, "De prioridade alta", "ALTA" },
                    { new Guid("f48fe1ce-991b-4f85-ab84-6bb6f65f17ed"), new DateTime(2022, 5, 10, 17, 25, 6, 133, DateTimeKind.Utc).AddTicks(5748), null, "De prioridade mais alta", "MUITO ALTA" }
                });

            migrationBuilder.InsertData(
                table: "ProjetoStatus",
                columns: new[] { "Id", "CreateAt", "UpdateAt", "descricao", "nome" },
                values: new object[,]
                {
                    { new Guid("42faeca0-0b11-46a8-92e4-e9852bafc258"), new DateTime(2022, 5, 10, 17, 25, 6, 134, DateTimeKind.Utc).AddTicks(3393), null, "Projeto Completo.", "COMPLETO" },
                    { new Guid("5be415a1-4b44-4f17-b83b-b94909fc73a5"), new DateTime(2022, 5, 10, 17, 25, 6, 134, DateTimeKind.Utc).AddTicks(3477), null, "Projeto ainda em aberto.", "ABERTO" },
                    { new Guid("1796fadb-8974-4bcf-9732-3ac3533af993"), new DateTime(2022, 5, 10, 17, 25, 6, 134, DateTimeKind.Utc).AddTicks(3502), null, "Projeto em progresso", "EM-PROGRESSO" },
                    { new Guid("c77f7cc2-0bc8-477a-a9d5-0397f349487a"), new DateTime(2022, 5, 10, 17, 25, 6, 134, DateTimeKind.Utc).AddTicks(3505), null, "Projeto não iniciado", "NÃO-INICIADO" },
                    { new Guid("75a99c9f-0d1b-4951-8ce0-811dded40a38"), new DateTime(2022, 5, 10, 17, 25, 6, 134, DateTimeKind.Utc).AddTicks(3509), null, "Projeto em espera.", "EM-ESPERA" }
                });

            migrationBuilder.InsertData(
                table: "QuestaoPrioridade",
                columns: new[] { "Id", "CreateAt", "UpdateAt", "descricao", "nome" },
                values: new object[,]
                {
                    { new Guid("b9914482-305c-4d55-9eb3-97f7bbd25231"), new DateTime(2022, 5, 10, 17, 25, 6, 135, DateTimeKind.Utc).AddTicks(5703), null, "De prioridade mais alta", "MUITO ALTA" },
                    { new Guid("800007f0-c40b-4060-a785-21f99b4b53ef"), new DateTime(2022, 5, 10, 17, 25, 6, 135, DateTimeKind.Utc).AddTicks(5589), null, "De prioridade baixa.", "BAIXA" },
                    { new Guid("37a9bf63-acb8-4c1c-a6a2-cb585d4d6005"), new DateTime(2022, 5, 10, 17, 25, 6, 135, DateTimeKind.Utc).AddTicks(5677), null, "De prioridade média.", "MEDIA" },
                    { new Guid("adc372ec-55a2-447a-a34a-6481622e378c"), new DateTime(2022, 5, 10, 17, 25, 6, 135, DateTimeKind.Utc).AddTicks(5681), null, "De prioridade alta", "ALTA" }
                });

            migrationBuilder.InsertData(
                table: "QuestaoStatus",
                columns: new[] { "Id", "CreateAt", "UpdateAt", "descricao", "nome" },
                values: new object[,]
                {
                    { new Guid("67b1a4ca-0696-4441-9cbe-7f7bf4a7816d"), new DateTime(2022, 5, 10, 17, 25, 6, 134, DateTimeKind.Utc).AddTicks(8905), null, "Uestão Aberta.", "ABERTA" },
                    { new Guid("17bbf5ac-71dc-4f47-8425-575a14e07d38"), new DateTime(2022, 5, 10, 17, 25, 6, 134, DateTimeKind.Utc).AddTicks(8771), null, "Questão Fechada.", "FECHADA" }
                });

            migrationBuilder.InsertData(
                table: "TipoArquivo",
                columns: new[] { "Id", "CreateAt", "UpdateAt", "descricao", "nome" },
                values: new object[,]
                {
                    { new Guid("2290b8cb-762b-403f-865e-86711cf7d79e"), new DateTime(2022, 5, 10, 17, 25, 6, 136, DateTimeKind.Utc).AddTicks(3233), null, "Fase de PLanejamento", "PLANEJAMENTO" },
                    { new Guid("8eed5cb6-2fae-4ce0-90ba-43dd30e12f97"), new DateTime(2022, 5, 10, 17, 25, 6, 136, DateTimeKind.Utc).AddTicks(3314), null, "fFase de Ptojeto.", "PROJETO" },
                    { new Guid("2cbf199f-890d-4f9a-a284-c5cb05c4d3d8"), new DateTime(2022, 5, 10, 17, 25, 6, 136, DateTimeKind.Utc).AddTicks(3318), null, "Fase de Desenvolvimento.", "DESENVOLVIMENTO" },
                    { new Guid("7185cee5-d8ae-447a-a93d-0b340a22f3fe"), new DateTime(2022, 5, 10, 17, 25, 6, 136, DateTimeKind.Utc).AddTicks(3322), null, "Fase de Teste", "TESTE" },
                    { new Guid("fa33955d-09ca-486f-b6a4-86e866d5aa4d"), new DateTime(2022, 5, 10, 17, 25, 6, 136, DateTimeKind.Utc).AddTicks(3326), null, "Fase de Produção", "PRODUÇÃO" }
                });

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 25, 6, 129, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("f0bc8933-d455-435b-9bfc-ec88cc35dfd6"), new DateTime(2022, 5, 10, 14, 25, 6, 123, DateTimeKind.Local).AddTicks(5756), "edervelludo@mail.com", "Administrador", new DateTime(2022, 5, 10, 14, 25, 6, 125, DateTimeKind.Local).AddTicks(1053) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AtividadePrioridade",
                keyColumn: "Id",
                keyValue: new Guid("017db0c7-b1da-426c-bdcd-04ebbadc2516"));

            migrationBuilder.DeleteData(
                table: "AtividadePrioridade",
                keyColumn: "Id",
                keyValue: new Guid("a867caad-b25f-43ed-9a6d-4c8861687d30"));

            migrationBuilder.DeleteData(
                table: "AtividadePrioridade",
                keyColumn: "Id",
                keyValue: new Guid("e5e900b9-742d-4c1c-9ddf-b9f2c77506db"));

            migrationBuilder.DeleteData(
                table: "AtividadePrioridade",
                keyColumn: "Id",
                keyValue: new Guid("e8cfca45-1dbe-421b-ad28-e1fbcc03d86a"));

            migrationBuilder.DeleteData(
                table: "AtividadeStatus",
                keyColumn: "Id",
                keyValue: new Guid("29fe3813-c4a4-4232-a30c-07df3f68c0fc"));

            migrationBuilder.DeleteData(
                table: "AtividadeStatus",
                keyColumn: "Id",
                keyValue: new Guid("3042a696-bc65-4b6c-82bf-f4ad663a963d"));

            migrationBuilder.DeleteData(
                table: "AtividadeStatus",
                keyColumn: "Id",
                keyValue: new Guid("3f017fa7-abff-4875-a523-be070ca8a183"));

            migrationBuilder.DeleteData(
                table: "AtividadeStatus",
                keyColumn: "Id",
                keyValue: new Guid("a8a0fec9-4fbb-4b8c-8dfb-b684ecce0002"));

            migrationBuilder.DeleteData(
                table: "AtividadeStatus",
                keyColumn: "Id",
                keyValue: new Guid("fbc4c359-c3ea-408c-ad43-b2f2fd0fada7"));

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: new Guid("003ad2d7-b34c-4e84-9c56-02ef535941da"));

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: new Guid("2b3d5122-3eff-4aa8-a820-25c0f99d3176"));

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: new Guid("59aedd05-599f-4b76-bf9a-f67a84bf5f9e"));

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: new Guid("7be4665b-e72f-4a8e-b371-61cc8514c47a"));

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: new Guid("95cc2696-28ee-45a7-8b7c-2ac7082d47be"));

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: new Guid("b14781c0-6fa3-4fe8-a7fd-972504d533f6"));

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: new Guid("bec0f472-8610-4e6e-b86a-bcb089cf66f8"));

            migrationBuilder.DeleteData(
                table: "FaseProjeto",
                keyColumn: "Id",
                keyValue: new Guid("8cba4356-9a28-48c1-a65e-72bd1167a496"));

            migrationBuilder.DeleteData(
                table: "FaseProjeto",
                keyColumn: "Id",
                keyValue: new Guid("902be417-9965-45b8-8899-77c484af7238"));

            migrationBuilder.DeleteData(
                table: "FaseProjeto",
                keyColumn: "Id",
                keyValue: new Guid("c04e1456-599d-4f12-b887-1b2882bef82a"));

            migrationBuilder.DeleteData(
                table: "FaseProjeto",
                keyColumn: "Id",
                keyValue: new Guid("dd015770-2b92-4b10-ba9e-2bce2164be74"));

            migrationBuilder.DeleteData(
                table: "FaseProjeto",
                keyColumn: "Id",
                keyValue: new Guid("ff417a5d-77b1-4188-835b-61553e03b761"));

            migrationBuilder.DeleteData(
                table: "ProjetoPrioridade",
                keyColumn: "Id",
                keyValue: new Guid("2a1f84e6-a84e-4221-b349-75b9118e0562"));

            migrationBuilder.DeleteData(
                table: "ProjetoPrioridade",
                keyColumn: "Id",
                keyValue: new Guid("2b81ac70-f92e-4d53-86f9-b51b3fe1dde3"));

            migrationBuilder.DeleteData(
                table: "ProjetoPrioridade",
                keyColumn: "Id",
                keyValue: new Guid("a7dba6e8-fcff-4c3c-ade2-ddb3a92413e8"));

            migrationBuilder.DeleteData(
                table: "ProjetoPrioridade",
                keyColumn: "Id",
                keyValue: new Guid("f48fe1ce-991b-4f85-ab84-6bb6f65f17ed"));

            migrationBuilder.DeleteData(
                table: "ProjetoStatus",
                keyColumn: "Id",
                keyValue: new Guid("1796fadb-8974-4bcf-9732-3ac3533af993"));

            migrationBuilder.DeleteData(
                table: "ProjetoStatus",
                keyColumn: "Id",
                keyValue: new Guid("42faeca0-0b11-46a8-92e4-e9852bafc258"));

            migrationBuilder.DeleteData(
                table: "ProjetoStatus",
                keyColumn: "Id",
                keyValue: new Guid("5be415a1-4b44-4f17-b83b-b94909fc73a5"));

            migrationBuilder.DeleteData(
                table: "ProjetoStatus",
                keyColumn: "Id",
                keyValue: new Guid("75a99c9f-0d1b-4951-8ce0-811dded40a38"));

            migrationBuilder.DeleteData(
                table: "ProjetoStatus",
                keyColumn: "Id",
                keyValue: new Guid("c77f7cc2-0bc8-477a-a9d5-0397f349487a"));

            migrationBuilder.DeleteData(
                table: "QuestaoPrioridade",
                keyColumn: "Id",
                keyValue: new Guid("37a9bf63-acb8-4c1c-a6a2-cb585d4d6005"));

            migrationBuilder.DeleteData(
                table: "QuestaoPrioridade",
                keyColumn: "Id",
                keyValue: new Guid("800007f0-c40b-4060-a785-21f99b4b53ef"));

            migrationBuilder.DeleteData(
                table: "QuestaoPrioridade",
                keyColumn: "Id",
                keyValue: new Guid("adc372ec-55a2-447a-a34a-6481622e378c"));

            migrationBuilder.DeleteData(
                table: "QuestaoPrioridade",
                keyColumn: "Id",
                keyValue: new Guid("b9914482-305c-4d55-9eb3-97f7bbd25231"));

            migrationBuilder.DeleteData(
                table: "QuestaoStatus",
                keyColumn: "Id",
                keyValue: new Guid("17bbf5ac-71dc-4f47-8425-575a14e07d38"));

            migrationBuilder.DeleteData(
                table: "QuestaoStatus",
                keyColumn: "Id",
                keyValue: new Guid("67b1a4ca-0696-4441-9cbe-7f7bf4a7816d"));

            migrationBuilder.DeleteData(
                table: "TipoArquivo",
                keyColumn: "Id",
                keyValue: new Guid("2290b8cb-762b-403f-865e-86711cf7d79e"));

            migrationBuilder.DeleteData(
                table: "TipoArquivo",
                keyColumn: "Id",
                keyValue: new Guid("2cbf199f-890d-4f9a-a284-c5cb05c4d3d8"));

            migrationBuilder.DeleteData(
                table: "TipoArquivo",
                keyColumn: "Id",
                keyValue: new Guid("7185cee5-d8ae-447a-a93d-0b340a22f3fe"));

            migrationBuilder.DeleteData(
                table: "TipoArquivo",
                keyColumn: "Id",
                keyValue: new Guid("8eed5cb6-2fae-4ce0-90ba-43dd30e12f97"));

            migrationBuilder.DeleteData(
                table: "TipoArquivo",
                keyColumn: "Id",
                keyValue: new Guid("fa33955d-09ca-486f-b6a4-86e866d5aa4d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f0bc8933-d455-435b-9bfc-ec88cc35dfd6"));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2022, 5, 10, 17, 4, 3, 713, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("6494e4dc-2fa7-4a1d-bff3-816f62d775fc"), new DateTime(2022, 5, 10, 14, 4, 3, 708, DateTimeKind.Local).AddTicks(219), "edervelludo@mail.com", "Administrador", new DateTime(2022, 5, 10, 14, 4, 3, 709, DateTimeKind.Local).AddTicks(5616) });
        }
    }
}
