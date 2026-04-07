using AplicattionAPI.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.DTOS.Request.Comand
{
    public record DeleteCampeonCommand(int id) : IRequest<Result<bool>>;
    
}
