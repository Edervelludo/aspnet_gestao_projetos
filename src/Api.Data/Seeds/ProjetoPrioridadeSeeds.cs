using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public static class ProjetoPrioridadeSeeds
    {
        public static void ProjetoPrioridades(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjetoPrioridadeEntity>().HasData(
                new ProjetoPrioridadeEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "BAIXA",
                    descricao = "De prioridade baixa.",
                    CreateAt = DateTime.UtcNow
                },
               new ProjetoPrioridadeEntity()
               {
                   Id = Guid.NewGuid(),
                   nome = "MEDIA",
                   descricao = "De prioridade média.",
                   CreateAt = DateTime.UtcNow
               },
                new ProjetoPrioridadeEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "ALTA",
                    descricao = "De prioridade alta",
                    CreateAt = DateTime.UtcNow
                },
                new ProjetoPrioridadeEntity()
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
