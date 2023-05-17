using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_zarzadzanie_studentami.Data;
using Project_zarzadzanie_studentami.Models;

namespace Project_zarzadzanie_studentami.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Project_zarzadzanie_studentami.Data.Project_zarzadzanie_studentamiContext _context;

        public IndexModel(Project_zarzadzanie_studentami.Data.Project_zarzadzanie_studentamiContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
