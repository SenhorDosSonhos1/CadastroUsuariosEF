using Microsoft.AspNetCore.Mvc;
using CadastroUsuariosEF.Data;
using CadastroUsuariosEF.Models;

namespace CadastroUsuariosEF.Controllers {
    public class UsuarioController : Controller {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context) {
            _context = context;
        }

        public IActionResult Index() {
            var usuarios = _context.Usuarios.ToList();
            return View(usuarios);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }
    }
}