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
                    Id = new Guid(),
                    nome = "FECHADA",
                    descricao = "Questão Fechada.",
                    CreateAt = DateTime.UtcNow
                },
                new QuestaoStatusEntity()
                {
                    Id = new Guid(),
                    nome = "ABERTA",
                    descricao = "Uestão Aberta.",
                    CreateAt = DateTime.UtcNow
                }


            );
        }
    }
}
