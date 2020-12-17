using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        DataContext _context;
        public PropertyRepository(DataContext context)
        {
            _context = context;
        }


        public async Task<Property> GetProperty(int id)
        {
            var property = await _context.Properties.FirstOrDefaultAsync(b => b.Id == id);
            return property;
        }
        public async Task<IEnumerable<Property>> GetProperties()
        {
            var properties = await _context.Properties.ToListAsync();
            return properties;
        }

    }
}
