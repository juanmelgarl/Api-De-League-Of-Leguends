using AplicattionAPI.Common;
using DomainAPI.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.DTOS.Request.Comand
{
    public record UpdateCampeonCommand(int id, string nombre,Rol roles, string titulo, double armadurabase, double vidabase, double ataquebase, string region, int dificultad) : IRequest<Result<bool>>;
    
}
