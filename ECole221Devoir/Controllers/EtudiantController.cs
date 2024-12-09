using Microsoft.AspNetCore.Mvc;

namespace ECole221Devoir.Controllers
{
    public class EtudiantController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EtudiantController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Lister les cours d'un étudiant
        public IActionResult ListerCours(int id)
        {
            var etudiant = _context.Etudiants
                                   .Include(e => e.Absences)
                                   .FirstOrDefault(e => e.Id == id);
            if (etudiant == null)
                return NotFound();

            return View(etudiant);
        }

        // Lister les absences d'un étudiant
        public IActionResult ListerAbsences(int id)
        {
            var absences = _context.Absences
                                   .Where(a => a.EtudiantId == id)
                                   .ToList();
            return View(absences);
        }
    }
}
