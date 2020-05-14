﻿using OrdonnancementsEquitables.Jobs;
using OrdonnancementsEquitables.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdonnancementsEquitables.Algos
{
    public interface IMultipleUsers<TJob> where TJob : Job
    {
        TJob[] Execute(User[] user);
    }
}