using TiendaApi.DTOs;
using TiendaApi.Models;

namespace TiendaApi.Interfaces
{
    public interface IClienteService
    {
        List<Cliente> GetAll();
        Cliente? GetById(int id);
        Cliente Create(CrearClienteDto request);
    }
}