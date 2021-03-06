using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public static class TipoArquivoSeeds
    {
        public static void TipoArquivo(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoArquivoEntity>().HasData(
                new TipoArquivoEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "PLANEJAMENTO",
                    descricao = "Fase de PLanejamento",
                    CreateAt = DateTime.UtcNow
                },
                new TipoArquivoEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "PROJETO",
                    descricao = "fFase de Ptojeto.",
                    CreateAt = DateTime.UtcNow
                },
                new TipoArquivoEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "DESENVOLVIMENTO",
                    descricao = "Fase de Desenvolvimento.",
                    CreateAt = DateTime.UtcNow
                },
                new TipoArquivoEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "TESTE",
                    descricao = "Fase de Teste",
                    CreateAt = DateTime.UtcNow
                },
                new TipoArquivoEntity()
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
