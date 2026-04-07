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
    public class DeleteCampeonHandler : IRequestHandler<DeleteCampeonCommand,Result<bool>>
    {
        private readonly ILolRepository<Campeones> _Repo;

        public DeleteCampeonHandler(ILolRepository<Campeones> repo)
        {
             _Repo = repo;
        }
        public async Task<Result<bool>> Handle(DeleteCampeonCommand command,CancellationToken token)
        {
            var encontrar = await _Repo.Obtenerporid(command.id);
            if (encontrar is null)
            {
                return Result<bool>.Failure("No se encontro el elemento a borrar");
            }
           await  _Repo.Delete(encontrar);
            return Result<bool>.Success(true);
        }
    }
}
