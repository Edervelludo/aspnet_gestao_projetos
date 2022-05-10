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
                    Id = new Guid(),
                    nome = "BAIXA",
                    descricao = "De prioridade baixa.",
                    CreateAt = DateTime.UtcNow
                },
               new QuestaoPrioridadeEntity()
               {
                   Id = new Guid(),
                   nome = "MEDIA",
                   descricao = "De prioridade média.",
                   CreateAt = DateTime.UtcNow
               },
                new QuestaoPrioridadeEntity()
                {
                    Id = new Guid(),
                    nome = "ALTA",
                    descricao = "De prioridade alta",
                    CreateAt = DateTime.UtcNow
                },
                new QuestaoPrioridadeEntity()
                {
                    Id = new Guid(),
                    nome = "MJUITO ALTA",
                    descricao = "De prioridade mais alta",
                    CreateAt = DateTime.UtcNow
                }


            );
        }
    }
}
