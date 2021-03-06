using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public static class FaseProjetosSeeds
    {
        public static void FaseProjetos(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FaseProjetoEntity>().HasData(
                new FaseProjetoEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "PLANEJAMENTO",
                    descricao = "Fase de PLanejamento",
                    CreateAt = DateTime.UtcNow
                },
                new FaseProjetoEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "PROJETO",
                    descricao = "fFase de Ptojeto.",
                    CreateAt = DateTime.UtcNow
                },
                new FaseProjetoEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "DESENVOLVIMENTO",
                    descricao = "Fase de Desenvolvimento.",
                    CreateAt = DateTime.UtcNow
                },
                new FaseProjetoEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "TESTE",
                    descricao = "Fase de Teste",
                    CreateAt = DateTime.UtcNow
                },
                new FaseProjetoEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "PRODUÇÃO",
                    descricao = "Fase de Produção",
                    CreateAt = DateTime.UtcNow
                }


            );
        }
    }
}
