using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEFCore.Models;
using HandsOnAPIUsingEFCore.Context;

namespace HandsOnAPIUsingEFCore.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context;
        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }

        public void Add(Employee item)
        {
            _context.Employees.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.Employees.Find(id);
            _context.Employees.Remove(item);
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetByID(int Id)
        {
            return _context.Employees.Find(Id);
        }

        public void Update(Employee item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
