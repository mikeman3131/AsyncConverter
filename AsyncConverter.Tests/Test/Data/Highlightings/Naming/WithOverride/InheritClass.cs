﻿using System.Threading.Tasks;
using LibraryToOverride;

namespace AsyncConverter.Tests
{
    public class Class1 : ClassToOverride
    {
        protected override Task Method()
        {
            return Task.CompletedTask;
        }
    }

    public class Class2 : Class1
    {
        protected override Task Method()
        {
            return Task.CompletedTask;
        }
    }
}