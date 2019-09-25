using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityDIMVC.Model;
using UnityDIMVC.Repository.Interfaces;
using UnityDIMVC.Service.Interfaces;

namespace UnityDIMVC.Service
{
    public class CategoryService : IcategoryService
    {
        IcategoryRepository __repo;
        public CategoryService(IcategoryRepository icategoryRepository)
        {
            __repo = icategoryRepository;
        }
        public async Task<bool> Add(CategoryVM category)
        {
            return await __repo.Add(category);
        }

        public async Task<bool> Detete(int ID)
        {
            return await __repo.Detete(ID);
        }

        public async Task<IEnumerable<CategoryVM>> Get()
        {
            return await __repo.Get();
        }

        public async Task<CategoryVM> GetByID(int ID)
        {
            return await __repo.GetByID(ID);
        }

        public async Task<bool> Update(CategoryVM categoryd)
        {
            return await __repo.Update(categoryd);
        }
    }
}
