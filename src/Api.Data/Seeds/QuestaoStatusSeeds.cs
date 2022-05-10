using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public static class QuestaoStatusSeeds
    {
        public static void QuestaoStatus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestaoStatusEntity>().HasData(
                new QuestaoStatusEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "FECHADA",
                    descricao = "Questão Fechada.",
                    CreateAt = DateTime.UtcNow
                },
                new QuestaoStatusEntity()
                {
                    Id = Guid.NewGuid(),
                    nome = "ABERTA",
                    descricao = "Uestão Aberta.",
                    CreateAt = DateTime.UtcNow
                }


            );
        }
    }
}
