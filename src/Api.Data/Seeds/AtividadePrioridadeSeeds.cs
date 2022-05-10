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
                    Id = new Guid(),
                    nome = "BAIXA",
                    descricao = "De prioridade baixa.",
                    CreateAt = DateTime.UtcNow
                },
               new AtividadePrioridadeEntity()
               {
                   Id = new Guid(),
                   nome = "MEDIA",
                   descricao = "De prioridade média.",
                   CreateAt = DateTime.UtcNow
               },
                new AtividadePrioridadeEntity()
                {
                    Id = new Guid(),
                    nome = "ALTA",
                    descricao = "De prioridade alta",
                    CreateAt = DateTime.UtcNow
                },
                new AtividadePrioridadeEntity()
                {
                    Id = new Guid(),
                    nome = "MUITO ALTA",
                    descricao = "De prioridade mais alta",
                    CreateAt = DateTime.UtcNow
                }


            );
        }
    }
}
