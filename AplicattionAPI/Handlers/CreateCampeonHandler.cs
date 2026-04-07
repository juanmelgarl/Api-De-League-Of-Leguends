using AplicattionAPI.Common;
using AplicattionAPI.DTOS.Request.Comand;
using AplicattionAPI.DTOS.Response;
using DomainAPI.Entities;
using DomainAPI.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.Handlers
{
    public class CreateCampeonHandler : IRequestHandler<CreateCampeonHandlerCommand,LolResponse>
    {
        private readonly ILolRepository<Campeones> _Repo;
        public CreateCampeonHandler(ILolRepository<Campeones> repo)
        {
             _Repo = repo;
        }

        public async Task<LolResponse> Handle(CreateCampeonHandlerCommand command,CancellationToken token)
        {
            var Create = new Campeones
            {
                Nombre = command.nombre,
                 ArmaduraBase = command.armadurabase,
                  AtaqueBase = command.armadurabase,
                   Dificultad = command.dificultad,
                     Region = command.region,
                      RolPrincipal = command.rolprincipal,
                       Titulo = command.titulo,
                   VidaBase = command.vidabase
            };
            await _Repo.Create(Create);

           return  new LolResponse
            {
               id = Create.Id,
                VidaBase = Create.VidaBase,
                Titulo = Create.Titulo,
                ArmaduraBase = Create.ArmaduraBase,
                AtaqueBase = Create.AtaqueBase,
                Dificultad = Create.Dificultad,
                Nombre = Create.Nombre,
                Region = Create.Region,
                RolPrincipal = Create.RolPrincipal
            };
        }
    }
}
