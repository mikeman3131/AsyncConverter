﻿using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public Task TestAsync()
        {
            {caret}Method();
            return Task.CompletedTask;
        }

        public Class Method()
        {
            return 5;
        }

        public Task<Class> MethodAsync()
        {
            return Task.FromResult<Class>(null);
        }
    }
}