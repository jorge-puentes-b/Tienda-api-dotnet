using TiendaApi.DTOs;
using TiendaApi.Interfaces;
using TiendaApi.Models;

namespace TiendaApi.Services
{
    public class ProductoService : IProductoService
    {
        private readonly List<Producto> _productos = new();
        public ProductoService()
        {
            _productos.Add(new Producto { Id = 1, Nombre = "Laptop", Precio = 1000m, Stock = 10 });
            _productos.Add(new Producto { Id = 2, Nombre = "Mouse", Precio = 20m, Stock = 20 });
            _productos.Add(new Producto { Id = 3, Nombre = "Teclado", Precio = 30m, Stock = 30 });
        }
        public List<Producto> GetAll()
        {
            return _productos;
        }
        public Producto? GetById(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }
        public Producto Create(CrearProductoDto request)
        {
            var nuevoProducto = new Producto
            {
                Id = _productos.Any() ? _productos.Max(p => p.Id) + 1 : 1,
                Nombre = request.Nombre ?? string.Empty,
                Precio = request.Precio,
                Stock = request.Stock
            };
            _productos.Add(nuevoProducto);
            return nuevoProducto;
        }
        public void Update(int id, ActualizarProductoDto request)
        {
            var producto = GetById(id);
            if (producto != null)
            {
                producto.Nombre = request.Nombre ?? producto.Nombre;
                producto.Precio = request.Precio;
                producto.Stock = request.Stock;
            }
        }
        public void Delete(int id)
        {
            var producto = GetById(id);
            if (producto != null)
            {
                _productos.Remove(producto);
            }
        }
    }
}