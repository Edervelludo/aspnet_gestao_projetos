using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public static class AtividadeStatusSeeds
    {
        public static void AtividadeStatus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AtividadeStatusEntity>().HasData(
                new AtividadeStatusEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "COMPLETA",
                    descricao = "Atividade Completa.",
                    CreateAt = DateTime.UtcNow
                },
                new AtividadeStatusEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "INCOMPLETA",
                    descricao = "Atividade Incompleta.",
                    CreateAt = DateTime.UtcNow
                },
                new AtividadeStatusEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "EM-PROGRESSO",
                    descricao = "Atividade em progresso",
                    CreateAt = DateTime.UtcNow
                },
                new AtividadeStatusEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "NÃO-INICIADA",
                    descricao = "Atividade não iniciada",
                    CreateAt = DateTime.UtcNow
                },
                new AtividadeStatusEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "EM-ESPERA",
                    descricao = "Atividade em espera.",
                    CreateAt = DateTime.UtcNow
                }


            );
        }
    }
}
