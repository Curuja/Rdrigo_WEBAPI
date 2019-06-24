using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
              
        public string Cpf { get; set; }

        public Int32 idade { get; set; }


    }
}
