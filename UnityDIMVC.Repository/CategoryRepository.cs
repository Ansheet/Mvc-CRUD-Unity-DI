using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityDIMVC.Model;
using UnityDIMVC.Repository.Interfaces;

namespace UnityDIMVC.Repository
{
    public class CategoryRepository : IcategoryRepository
    {
        readonly DbconnContext _context;
        public CategoryRepository(DbconnContext dbconnContext)
        {
            _context = dbconnContext;
        }
        public async Task<bool> Add(CategoryVM category)
        {
            //_context.categoris.Add(category);
            _context.Entry(category).State = EntityState.Added;
            int v = await _context.SaveChangesAsync();
            return v == 0 ? false : true;
        }

        public async Task<bool> Detete(int ID)
        {
            var existing = _context.categoris.Find(ID);
            _context.categoris.Remove(existing);
            int v = await _context.SaveChangesAsync();
            return v == 0 ? false : true;
        }

        public async Task<IEnumerable<CategoryVM>> Get()
        {
            return await _context.categoris.ToListAsync();
        }

        public async Task<CategoryVM> GetByID(int ID)
        {
            return await _context.categoris.FindAsync(ID);
        }

        public async Task<bool> Update(CategoryVM category)
        {
            _context.Entry(category).State = EntityState.Modified;
            int v = await _context.SaveChangesAsync();
            return v == 0 ? false : true;
        }
    }
}
