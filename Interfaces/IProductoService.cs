using TiendaApi.DTOs;
using TiendaApi.Models;

namespace TiendaApi.Interfaces
{
    public interface IProductoService
    {
        List<Producto> GetAll();
        Producto? GetById(int id);
        Producto Create(CrearProductoDto request);
        void Update(int id, ActualizarProductoDto request);
        void Delete(int id);
    }
}   