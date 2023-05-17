using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_zarzadzanie_studentami.Data;
using Project_zarzadzanie_studentami.Models;

namespace Project_zarzadzanie_studentami.Pages.PresenceList
{
    public class ChoosePresenceModel : PageModel
    {
        private readonly Project_zarzadzanie_studentami.Data.Project_zarzadzanie_studentamiContext _context;

        public ChoosePresenceModel(Project_zarzadzanie_studentami.Data.Project_zarzadzanie_studentamiContext context)
        {
            _context = context;
        }
        public IList<Subject> Subject { get; set; } = new List<Subject>();
        public IList<Presence> Presence { get; set; } = default!;
        public Presence presences { get; set; } = default!;
        [BindProperty]
        public string SelectedSubjectName { get; set; }
        [BindProperty]
        public DateTime Date { get; set; }

        public async Task OnGetAsync()
        {
            if( _context.Subject != null)
            {
                Subject = await _context.Subject.ToListAsync();
            }
        }
       
        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid || Subject == null )
            {
                return Page();
            }
            if (SelectedSubjectName != null)
            {
                Presence = await _context.Presence.Where(x => x.SubjectName == SelectedSubjectName && x.PresenceData == Date).ToListAsync();
            }
            return Page();
        }
    }
}
