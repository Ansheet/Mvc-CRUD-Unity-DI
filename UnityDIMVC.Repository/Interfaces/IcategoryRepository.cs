﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityDIMVC.Model;

namespace UnityDIMVC.Repository.Interfaces
{
    public interface IcategoryRepository
    {
        Task<IEnumerable<CategoryVM>> Get();
        Task<bool> Add(CategoryVM category);
        Task<bool> Update(CategoryVM categoryd);
        Task<bool> Detete(int ID);
        Task<CategoryVM> GetByID(int ID);

    }
}