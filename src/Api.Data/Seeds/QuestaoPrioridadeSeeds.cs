using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public static class QuestaorioridadeSeeds
    {
        public static void QuestaoPrioridades(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestaoPrioridadeEntity>().HasData(
                new QuestaoPrioridadeEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "BAIXA",
                    descricao = "De prioridade baixa.",
                    CreateAt = DateTime.UtcNow
                },
               new QuestaoPrioridadeEntity()
               {
                   Id = Guid.NewGuid(),
                   nome = "MEDIA",
                   descricao = "De prioridade média.",
                   CreateAt = DateTime.UtcNow
               },
                new QuestaoPrioridadeEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "ALTA",
                    descricao = "De prioridade alta",
                    CreateAt = DateTime.UtcNow
                },
                new QuestaoPrioridadeEntity()
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
