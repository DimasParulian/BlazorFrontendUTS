using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFrontendUTS.Models;

namespace BlazorFrontendUTS.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAll();
        Task<Department> GetById(int id);
    }
}