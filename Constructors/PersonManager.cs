﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
}
