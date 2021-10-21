﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesssLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
    }
}