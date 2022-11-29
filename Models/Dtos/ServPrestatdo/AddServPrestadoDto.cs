using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Models.Dtos.ServPrestatdoDto
{
    public class AddServPrestadoDto
    {

        public string Servico { get; set; }


        public double Valor { get; set; }

        public DateTime Data { get; set; }


    }
}