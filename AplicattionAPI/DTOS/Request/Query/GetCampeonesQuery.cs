using AplicattionAPI.Common;
using AplicattionAPI.DTOS.Response;
using DomainAPI.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.DTOS.Request.Query
{
    public record GetCampeonesQuery(string? Nombre = null,
    string? Region = null,
    int? Dificultad = null,
    Rol? Rol = null,
    

    string? OrdenarPor = null,
    bool EsAscendente = true,
    int Pagina = 1,
    int TamañoPagina = 10) : IRequest<Result<List<LolResponse>>>;
}
