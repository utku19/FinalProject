﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}

//Code Refactoring - Kodun İyileştirilmesi