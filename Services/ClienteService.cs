using TiendaApi.Models;
using TiendaApi.DTOs;
using TiendaApi.Interfaces;

namespace TiendaApi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly List<Cliente> _clientes = new();

        public ClienteService()
        {
            _clientes.Add(new Cliente { Id = 1, Nombre = "Juan", Email = "[EMAIL_ADDRESS]" });
            _clientes.Add(new Cliente { Id = 2, Nombre = "Maria", Email = "[EMAIL_ADDRESS]" });
            _clientes.Add(new Cliente { Id = 3, Nombre = "Pedro", Email = "[EMAIL_ADDRESS]" });
        }

        public List<Cliente> GetAll()
        {
            return _clientes;
        }

        public Cliente? GetById(int id)
        {
            return _clientes.FirstOrDefault(x => x.Id == id);
        }

        public Cliente Create(CrearClienteDto request)
        {
            var nuevoCliente = new Cliente
            {
                Id = _clientes.Any() ? _clientes.Max(c => c.Id) + 1 : 1,
                Nombre = request.Nombre ?? string.Empty,
                Email = request.Email ?? string.Empty
            };
            _clientes.Add(nuevoCliente);
            return nuevoCliente;
        }   
    }
}