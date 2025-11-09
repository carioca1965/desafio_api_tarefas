using CamadaNetApiDesafio.Data;
using CamadaNetApiDesafio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CamadaNetApiDesafio.Controllers
{
    [ApiController]
    [Route("tarefa")]
    public class TarefasController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TarefasController(AppDbContext context) => _context = context;

        [HttpGet("ObterTodos")]
        public async Task<IActionResult> ObterTodos() =>
            Ok(await _context.Tarefas.ToListAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var t = await _context.Tarefas.FindAsync(id);
            return t == null ? NotFound() : Ok(t);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(Tarefa t)
        {
            _context.Tarefas.Add(t);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(ObterPorId), new { id = t.Id }, t);
        }
    }
}
