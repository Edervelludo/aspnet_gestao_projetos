using System;
using Api.Data.Mapping;
using Api.Data.Seeds;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);

            modelBuilder.Entity<UfEntity>(new UfMap().Configure);
            modelBuilder.Entity<MunicipioEntity>(new MunicipioMap().Configure);
            modelBuilder.Entity<CepEntity>(new CepMap().Configure);

            modelBuilder.Entity<AtividadeEntity>(new AtividadeMap().Configure);
            modelBuilder.Entity<AtividadeStatusEntity>(new AtividadeStatusMap().Configure);
            modelBuilder.Entity<AtividadePrioridadeEntity>(new AtividadePrioridadeMap().Configure);
            modelBuilder.Entity<DepartamentoEntity>(new DepartamentoMap().Configure);
            modelBuilder.Entity<CartaoTempoEntity>(new CartaoTempoMap().Configure);
            modelBuilder.Entity<EmpresaEntity>(new EmpresaMap().Configure);
            modelBuilder.Entity<FaseProjetoEntity>(new FaseProjetoMap().Configure);
            modelBuilder.Entity<ProjetoPrioridadeEntity>(new ProjetoPrioridadeMap().Configure);
            modelBuilder.Entity<ProjetoStatusEntity>(new ProjetoStatusMap().Configure);
            modelBuilder.Entity<DocumentoProjetoEntity>(new DocumentoProjetoMap().Configure);
            modelBuilder.Entity<DocumentoHistoricoEntity>(new DocumentoHistoricoMap().Configure);
            modelBuilder.Entity<ProjetoEntity>(new ProjetoMap().Configure);
            modelBuilder.Entity<QuestaoEntity>(new QuestaoMap().Configure);
            modelBuilder.Entity<RecursoEntity>(new RecursoMap().Configure);
            modelBuilder.Entity<TipoArquivoEntity>(new TipoArquivoMap().Configure);
            modelBuilder.Entity<QuestaoPrioridadeEntity>(new QuestaoPrioridadeMap().Configure);
            modelBuilder.Entity<QuestaoStatusEntity>(new QuestaoStatusMap().Configure);




            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Administrador",
                    Email = "edervelludo@mail.com",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                }
            );

            UfSeeds.Ufs(modelBuilder);
        }

    }
}
