﻿using System;

namespace RetryTestAddin
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class RetryTestAttribute : Attribute
    {
        public int RetryCount { get; set; }

        public RetryTestAttribute(int retryCount)
        {
            RetryCount = retryCount;
        }
    }
}
