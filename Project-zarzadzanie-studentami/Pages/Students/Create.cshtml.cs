using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project_zarzadzanie_studentami.Data;
using Project_zarzadzanie_studentami.Models;

namespace Project_zarzadzanie_studentami.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly Project_zarzadzanie_studentami.Data.Project_zarzadzanie_studentamiContext _context;

        public CreateModel(Project_zarzadzanie_studentami.Data.Project_zarzadzanie_studentamiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Student == null || Student == null)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
