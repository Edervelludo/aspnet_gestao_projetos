using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public static class DepartamentoSeeds
    {
        public static void Departamentos(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartamentoEntity>().HasData(
                new DepartamentoEntity()
                {
                    Id = new Guid(),
                    nome = "Operação",
                    descricao = "Operações",
                    CreateAt = DateTime.UtcNow
                },
                new DepartamentoEntity()
                {
                    Id = new Guid(),
                    nome = "Financeiro",
                    descricao = "Financeiro",
                    CreateAt = DateTime.UtcNow
                },
                new DepartamentoEntity()
                {
                    Id = new Guid(),
                    nome = "Engenharia",
                    descricao = "Engenharia",
                    CreateAt = DateTime.UtcNow
                },
                new DepartamentoEntity()
                {
                    Id = new Guid(),
                    nome = "Tecnologia da Informação",
                    descricao = "Tecnologia da Informação",
                    CreateAt = DateTime.UtcNow
                },
                new DepartamentoEntity()
                {
                    Id = new Guid(),
                    nome = "Qualidade",
                    descricao = "Qualidade",
                    CreateAt = DateTime.UtcNow
                },
                new DepartamentoEntity()
                {
                    Id = new Guid(),
                    nome = "Gestão",
                    descricao = "Gestão",
                    CreateAt = DateTime.UtcNow
                },
                new DepartamentoEntity()
                {
                    Id = new Guid(),
                    nome = "Marketing",
                    descricao = "Marketing",
                    CreateAt = DateTime.UtcNow
                }


            );
        }
    }
}
