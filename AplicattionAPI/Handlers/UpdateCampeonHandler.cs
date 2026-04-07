using AplicattionAPI.Common;
using AplicattionAPI.DTOS.Request.Comand;
using DomainAPI.Entities;
using DomainAPI.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.Handlers
{
    public class UpdateCampeonHandler : IRequestHandler<UpdateCampeonCommand,Result<bool>>
    {
        private readonly ILolRepository<Campeones> _Repo;

        public UpdateCampeonHandler(ILolRepository<Campeones> repo)
        {
            _Repo = repo;
        }
        public async Task<Result<bool>> Handle(UpdateCampeonCommand command, CancellationToken token)
        {
            var buscar = await _Repo.Obtenerporid(command.id);
            if (buscar is null)
            {
                return Result<bool>.Failure("I couldn't find the champion");
            }
            buscar.Nombre = command.nombre;
            buscar.Titulo = command.titulo;
            buscar.RolPrincipal = command.roles;
            buscar.ArmaduraBase = command.armadurabase;
            buscar.AtaqueBase = command.ataquebase;
            buscar.Region = command.region;
            buscar.Dificultad = command.dificultad;

            return Result<bool>.Success(true);
      
        }

    }
}
