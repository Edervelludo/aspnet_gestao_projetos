using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.Projeto;

namespace Api.Domain.Dtos.CartaoTempo
{
    public class CartaoTempoDtoUpdate
    {

        [Required(ErrorMessage = "Id é campo Obrigatorio")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Id do Projeto é campo Obrigatorio")]
        public Guid projetoid { get; set; }
        public ProjetoDtoCompleto projeto { get; set; }
        [Required(ErrorMessage = "Id do Recurso é campo Obrigatorio")]
        public Guid recursoid { get; set; }
        public RecursoDtoCompleto recurso { get; set; }
        public DateTime semanaini { get; set; }
        public int hdom { get; set; }
        public int hseg { get; set; }
        public int hter { get; set; }
        public int hqua { get; set; }
        public int hqui { get; set; }
        public int hsex { get; set; }
        public int hsab { get; set; }


    }
}
