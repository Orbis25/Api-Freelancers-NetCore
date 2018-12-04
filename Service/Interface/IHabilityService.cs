﻿using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IHabilityService : IRepository<Hability>
    {
        IEnumerable<Hability> GetByCategoryId(int id);
    }
}
