using AplicattionAPI.DTOS.Response;
using DomainAPI.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.DTOS.Request.Comand
{
    public record CreateCampeonHandlerCommand(string nombre, string titulo, Rol rolprincipal, double vidabase, double ataquebase, double armadurabase, int dificultad, string region) : IRequest<LolResponse>;
    
}
