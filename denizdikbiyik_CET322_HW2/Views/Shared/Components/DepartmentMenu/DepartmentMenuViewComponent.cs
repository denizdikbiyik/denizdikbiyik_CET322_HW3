using denizdikbiyik_CET322_HW2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace denizdikbiyik_CET322_HW2.Views.Shared.Components.DepartmentMenu
{
    public class DepartmentMenuViewComponent : ViewComponent
    {
        private readonly StudentsContext dbContext;

        public DepartmentMenuViewComponent(StudentsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var departments = await dbContext.Department.ToListAsync();
            return View(departments);
        }
    }
}
