using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.CartaoTempo
{
    public class CartaoTempoDto
    {

        public Guid id { get; set; }
        public Guid projetoid { get; set; }
        public Guid recursoid { get; set; }
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
