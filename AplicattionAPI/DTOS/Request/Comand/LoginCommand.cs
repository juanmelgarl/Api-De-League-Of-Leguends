using AplicattionAPI.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicattionAPI.DTOS.Request.Comand
{
    public class LoginCommand : IRequest<Result<string>>
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}