﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Atomiv.Core.Domain
{
    public abstract class Rule<T> : IRule<T>
        where T : IValidatable
    {
        public Rule(bool continueOnError = false)
        {
            ContinueOnError = false;
        }

        public bool ContinueOnError { get; }

        public abstract Task<RuleValidationResult> ValidateAsync(T obj);
    }
}
