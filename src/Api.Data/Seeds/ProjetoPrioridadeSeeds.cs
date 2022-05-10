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
                    Id = new Guid(),
                    nome = "BAIXA",
                    descricao = "De prioridade baixa.",
                    CreateAt = DateTime.UtcNow
                },
               new ProjetoPrioridadeEntity()
               {
                   Id = new Guid(),
                   nome = "MEDIA",
                   descricao = "De prioridade média.",
                   CreateAt = DateTime.UtcNow
               },
                new ProjetoPrioridadeEntity()
                {
                    Id = new Guid(),
                    nome = "ALTA",
                    descricao = "De prioridade alta",
                    CreateAt = DateTime.UtcNow
                },
                new ProjetoPrioridadeEntity()
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
