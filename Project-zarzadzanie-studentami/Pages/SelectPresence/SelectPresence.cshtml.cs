using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using Project_zarzadzanie_studentami.Data;
using Project_zarzadzanie_studentami.Models;

namespace Project_zarzadzanie_studentami.Pages.SelectPresence
{
    public class SelectPresenceModel : PageModel
    {
        private readonly Project_zarzadzanie_studentami.Data.Project_zarzadzanie_studentamiContext _context;

       
        public SelectPresenceModel(Project_zarzadzanie_studentami.Data.Project_zarzadzanie_studentamiContext context)
        {
            _context = context;
        }

        public IList<Student> Students { get; set; } = default!;
        public IList<Subject> Subjects { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Subject != null)
            {
                Students = await _context.Student.ToListAsync();
                Subjects = await _context.Subject.ToListAsync();
            }
        }

        [BindProperty]
        public Presence Presence { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Presence == null || Presence == null)
            {
                return Page();
            }
            _context.Presence.Add(Presence);
            await _context.SaveChangesAsync();
            return RedirectToPage("./SelectPresence");
        }
    }
}
