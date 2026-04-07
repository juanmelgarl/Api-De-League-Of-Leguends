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
    public class GetCampeonesHandler : IRequestHandler<GetCampeonesQuery,Result<List<LolResponse>>>
    {
        private readonly ILolRepository<Campeones> _Repo;
        public GetCampeonesHandler(ILolRepository<Campeones> repo)
        {
             _Repo = repo;
        }
        public async Task<Result<List<LolResponse>>> Handle(GetCampeonesQuery request,CancellationToken token)
        {
            int Skip = (request.Pagina - 1) * request.TamañoPagina;

            var spec = new CampeonFilterSpec(
                       request.Nombre,
                       request.Region,
                       request.Dificultad,
                       request.Rol,
                       request.OrdenarPor,
                      Skip,
                       request.TamañoPagina);
          
            var Campeones = await _Repo.ListAsync(spec);
           

            var Response = Campeones.Select(c => new LolResponse
            {
                id = c.Id,
                AtaqueBase = c.AtaqueBase,
                ArmaduraBase = c.ArmaduraBase,
                Dificultad = c.Dificultad,
                Nombre = c.Nombre,
                Region = c.Region,
                RolPrincipal = c.RolPrincipal,
                Titulo = c.Titulo,
                VidaBase = c.VidaBase,
            }).ToList();
            return Result<List<LolResponse>>.Success(Response);
        }
       
    }
}
