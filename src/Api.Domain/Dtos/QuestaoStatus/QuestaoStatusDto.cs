using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.QuestaoStatus
{
    public class QuestaoStatusDto
    {
        public Guid Id { get; set; }
        public string nome { get; set; }

        public string descricao { get; set; }
        //public IEnumerable<QuestaoEntity> questoes { get; set; }
    }
}
