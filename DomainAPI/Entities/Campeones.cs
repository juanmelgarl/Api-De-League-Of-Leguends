using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace DomainAPI.Entities
{
    public class Campeones
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public string Titulo { get; set; } 

        
        public  Rol? RolPrincipal { get; set; } 
        
        
        public double VidaBase { get; set; }
        public double AtaqueBase { get; set; }
        public double ArmaduraBase { get; set; }

    
        public string Region { get; set; } 
        public int Dificultad { get; set; }
        public Campeones() { }

        public Campeones(string nombre,string titulo, Rol rolprincipal,double vidabase,double ataquebase,double armadurabase,string region,int dificultad)
        {
            Nombre = nombre;
            Titulo = titulo;
            RolPrincipal = rolprincipal;
            VidaBase = vidabase;
            AtaqueBase = ataquebase;
            ArmaduraBase = armadurabase;
            Region = region;
            Dificultad = dificultad;
        }

        public void Vidabasevalidar(double vidabase)
        {
            if (vidabase < 0)
                {
                throw new ArgumentException("El total no puede ser menor a cero");
            }
            VidaBase = vidabase;
        }

        public void Armadura(double armadura)
        {
            if (armadura < 0)
            {
                throw new ArgumentException("El nivel de armadura no puede ser menor a cero");
            }
            ArmaduraBase = armadura;
        }
        
    }



}

