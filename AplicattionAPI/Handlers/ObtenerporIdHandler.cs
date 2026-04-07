using AplicattionAPI.Common;
using AplicattionAPI.DTOS.Request.Query;
using AplicattionAPI.DTOS.Response;
using DomainAPI.Entities;
using DomainAPI.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.Handlers
{
    public class ObtenerporIdHandler : IRequestHandler<ObtenerporIdQuery, Result<LolResponse>>
    {
        private readonly ILolRepository<Campeones> _Repo;


        public ObtenerporIdHandler(ILolRepository<Campeones> repo)
        {
            _Repo = repo;
        }
        public async Task<Result<LolResponse>> Handle(ObtenerporIdQuery query,CancellationToken token)
        {
            var encontrar = await _Repo.Obtenerporid(query.id);
            if (encontrar is null)
            {
                return  Result<LolResponse>.Failure("That ID was not found");
            }
            var resopnse = new LolResponse
            {
                id = encontrar.Id,
                ArmaduraBase = encontrar.ArmaduraBase,
                AtaqueBase = encontrar.AtaqueBase,
                Dificultad = encontrar.Dificultad,
                Nombre = encontrar.Nombre,
                Region = encontrar.Region,
                RolPrincipal = encontrar.RolPrincipal,
                Titulo = encontrar.Titulo,
                VidaBase = encontrar.VidaBase,
            };
            return Result<LolResponse>.Success(resopnse);
        }
    }
}
