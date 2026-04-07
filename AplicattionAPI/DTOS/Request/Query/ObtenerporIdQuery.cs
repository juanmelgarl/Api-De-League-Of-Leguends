using AplicattionAPI.Common;
using AplicattionAPI.DTOS.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.DTOS.Request.Query
{
    public record ObtenerporIdQuery(int id) : IRequest<Result<LolResponse>>;
  
}
