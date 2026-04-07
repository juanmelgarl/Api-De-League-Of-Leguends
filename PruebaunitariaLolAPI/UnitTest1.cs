using AplicattionAPI;
using AplicattionAPI.DTOS.Request.Comand;
using AplicattionAPI.DTOS.Request.Query;
using AplicattionAPI.Handlers;
using DomainAPI;
using DomainAPI.Entities;
using DomainAPI.Interfaces;
using InfrastructureAPI;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebApplication1;
using WebApplication1.Controllers;
namespace PruebaunitariaLolAPI
{
    public class UnitTest1
    {
        private readonly Mock<ILolRepository<Campeones>> _Repo;
        private readonly Mock<CreateCampeonHandler> _Handler;
        private readonly Mock<IMediator> _Mediator;

        private readonly CampeonesController _controller;

        public UnitTest1()
            {
            _Repo = new Mock<ILolRepository<Campeones>>();
            _Handler = new Mock<CreateCampeonHandler>();
            _Mediator = new Mock<IMediator>();
            _controller = new CampeonesController(_Mediator.Object);
        }
        [Fact]
        public async Task CreateCampeonNull()
        {
            var result = await _controller.Crear(null); 
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task DeleteError()
        {
            var instanciar = new DeleteCampeonCommand (0);
            var result = await _controller.Delete(instanciar.id);
            Assert.IsType<NotFoundResult>(result);
        }
        [Fact]
        public async Task ActualizarError()
        {

            var Actualizar = new UpdateCampeonCommand(0, "nombre", 0, "titulo", 0.0, 0.0, 0.0, "titulo",-2);

            var result = await _controller.Actualizar(Actualizar.id, Actualizar);
            Assert.IsType<NotFoundResult>(result);
        }
        
        [Fact]
        public async Task CreateoK()
        {
            var create = new CreateCampeonHandlerCommand( "marino", "asd", 0, 31.2, 50.2, 11.2, 3, "a");
            var result = await _controller.Crear(create);
            Assert.IsType<NoContentResult>(result);
        }
        [Fact]
        public async Task Obtener()
        {
            var result = await _controller.Obtenerporid(0);
            Assert.IsType<OkObjectResult>(result);

        }

    }
    


}
