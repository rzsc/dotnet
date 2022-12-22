// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
    internal sealed class ExprArrayIndex : ExprWithType
    {
        public ExprArrayIndex(CType type, Expr array, Expr index)
            : base(ExpressionKind.ArrayIndex, type)
        {
            Array = array;
            Index = index;
            Flags = EXPRFLAG.EXF_LVALUE | EXPRFLAG.EXF_ASSGOP;
        }

        public Expr Array { get; set; }

        public Expr Index { get; set; }
    }
}
