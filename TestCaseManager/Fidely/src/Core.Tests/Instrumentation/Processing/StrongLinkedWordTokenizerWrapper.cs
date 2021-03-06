﻿using Fidely.Framework.Compilation.Operators;
using Fidely.Framework.Processing;
using Fidely.Framework.Tokens;
using System;
using System.Collections.Generic;

namespace Fidely.Framework.Tests.Instrumentation.Processing
{
    internal class StrongLinkedWordTokenizerWrapper : StrongLinkedWordTokenizer
    {
        internal StrongLinkedWordTokenizerWrapper(IEnumerable<FidelyOperator> operators)
            : base(operators)
        {
        }


        internal IEnumerable<IToken> InvokeTokenize(UncategorizedToken token)
        {
            return base.Tokenize(token);
        }
    }
}
