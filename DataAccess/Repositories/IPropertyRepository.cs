using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IPropertyRepository
    {
        Task<Property> GetProperty(int id);
        Task<IEnumerable<Property>> GetProperties();
    }
}
