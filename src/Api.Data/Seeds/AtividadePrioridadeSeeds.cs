using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public static class AtividadePrioridadeSeeds
    {
        public static void AtividadePrioridades(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AtividadePrioridadeEntity>().HasData(
                new AtividadePrioridadeEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "BAIXA",
                    descricao = "De prioridade baixa.",
                    CreateAt = DateTime.UtcNow
                },
               new AtividadePrioridadeEntity()
               {
                   Id = Guid.NewGuid(),
                   nome = "MEDIA",
                   descricao = "De prioridade média.",
                   CreateAt = DateTime.UtcNow
               },
                new AtividadePrioridadeEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "ALTA",
                    descricao = "De prioridade alta",
                    CreateAt = DateTime.UtcNow
                },
                new AtividadePrioridadeEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "MUITO ALTA",
                    descricao = "De prioridade mais alta",
                    CreateAt = DateTime.UtcNow
                }


            );
        }
    }
}
