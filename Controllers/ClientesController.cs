using Microsoft.AspNetCore.Mvc;
using TiendaApi.DTOs;
using TiendaApi.Interfaces;

namespace TiendaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly IClienteService _clienteService;
    public ClientesController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_clienteService.GetAll());
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var cliente = _clienteService.GetById(id);
        if (cliente == null)
        {
            return NotFound();
        }
        return Ok(cliente);
    }
    [HttpPost]
    public IActionResult Create(CrearClienteDto request)
    {
        var cliente = _clienteService.Create(request);
        return CreatedAtAction(nameof(GetById), new { id = cliente.Id }, cliente);
    }
    
}