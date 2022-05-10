using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public static class ProjetoStatusSeeds
    {
        public static void PreojetoStatus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjetoStatusEntity>().HasData(
                new ProjetoStatusEntity()
                {
                    Id = new Guid(),
                    nome = "COMPLETO",
                    descricao = "Projeto Completo.",
                    CreateAt = DateTime.UtcNow
                },
                new ProjetoStatusEntity()
                {
                    Id = new Guid(),
                    nome = "ABERTO",
                    descricao = "Projeto ainda em aberto.",
                    CreateAt = DateTime.UtcNow
                },
                new ProjetoStatusEntity()
                {
                    Id = new Guid(),
                    nome = "EM-PROGRESSO",
                    descricao = "Projeto em progresso",
                    CreateAt = DateTime.UtcNow
                },
                new ProjetoStatusEntity()
                {
                    Id = new Guid(),
                    nome = "NÃO-INICIADO",
                    descricao = "Projeto não iniciado",
                    CreateAt = DateTime.UtcNow
                },
                new ProjetoStatusEntity()
                {
                    Id = new Guid(),
                    nome = "EM-ESPERA",
                    descricao = "Projeto em espera.",
                    CreateAt = DateTime.UtcNow
                }


            );
        }
    }
}
