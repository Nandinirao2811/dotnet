using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEFCore.Models;
using HandsOnAPIUsingEFCore.Context;

namespace HandsOnAPIUsingEFCore.Repository
{
    public interface IEmployeeRepository
    {
        void Add(Employee item);
        List<Employee> GetAll();
        Employee GetByID(int Id);
        void Update(Employee item);
        void Delete(int id);
    }
}
