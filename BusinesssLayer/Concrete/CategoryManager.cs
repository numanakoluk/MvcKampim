﻿using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesssLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public List<Category> GetAllBL()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName=="" || p.CategoryName.Length<=3)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
