using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using denizdikbiyik_CET322_HW2.Models;

namespace denizdikbiyik_CET322_HW2.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentsContext _context;

        public StudentsController(StudentsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.Include(s=>s.Department)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<Department> departmentlist = new List<Department>();
            departmentlist = (from Department in _context.Department select Department).ToList();
            Student student = new Student();
            student.departments = GetDepartments(departmentlist);
            return View(student);
        }
        private IEnumerable<SelectListItem> GetDepartments(IEnumerable<Department> elements)
        {
            var selectList = new List<SelectListItem>();
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.DepartmentName
                });
            }

            return selectList;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int? id, Student studentmodel)
        {
            if (ModelState.IsValid)
            {
                Student student = new Student();
                student.StudentName = studentmodel.StudentName;
                student.StudentSurname = studentmodel.StudentSurname;
                student.StudentNo = studentmodel.StudentNo;
                student.StudentTelNo = studentmodel.StudentTelNo;
                student.StudentEmail = studentmodel.StudentEmail;
                student.DepartmentId = studentmodel.DepartmentId;
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentmodel);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            List<Department> departmentlist = new List<Department>();
            departmentlist = _context.Department.ToList();
            student.departments = GetDepartments(departmentlist);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,StudentNo,StudentName,StudentSurname,StudentEmail,StudentTelNo,DepartmentId")] Student student)
        {
            if (id != student.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.Include(s => s.Department)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.StudentId == id);
        }
    }
}
