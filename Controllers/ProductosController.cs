using Microsoft.AspNetCore.Mvc;
using TiendaApi.DTOs;
using TiendaApi.Interfaces;

namespace TiendaApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductosController : ControllerBase
{
    private readonly IProductoService _productoService;
    public ProductosController(IProductoService productoService)
    {
        _productoService = productoService;
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_productoService.GetAll());
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var producto = _productoService.GetById(id);
        if (producto == null)
        {
            return NotFound();
        }
        return Ok(producto);
    }
    [HttpPost]
    public IActionResult Create(CrearProductoDto request)
    {
        var producto = _productoService.Create(request);
        return CreatedAtAction(nameof(GetById), new { id = producto.Id }, producto);
    }
    [HttpPut("{id}")]
    public IActionResult Update(int id, ActualizarProductoDto request)
    {
        var producto = _productoService.GetById(id);
        if (producto == null)
        {
            return NotFound();
        }
        _productoService.Update(id, request);
        return Ok(producto);
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var producto = _productoService.GetById(id);
        if (producto == null)
        {
            return NotFound();
        }
        _productoService.Delete(id);
        return Ok(producto);
    }
}
