using DomainAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.DTOS.Response
{
    public class LolResponse
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }


        public Rol? RolPrincipal { get; set; }


        public double VidaBase { get; set; }
        public double AtaqueBase { get; set; }
        public double ArmaduraBase { get; set; }


        public string Region { get; set; }
        public int Dificultad { get; set; }
    }
}
