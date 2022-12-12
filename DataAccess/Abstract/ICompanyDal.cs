﻿using Core.DataAccess;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataAccess.Abstract
{
    public interface ICompanyDal:IEntityRepository<Company>
    {

    }
}
