﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sep3Blazor.Data
{
    public interface IGroupService
    {
        public IList<String> AdultsList { get; }

        public Task<IList<string>> Connect(String s);
        
        public Task<IList<string>> Post(String s);
    }
}