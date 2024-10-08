// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace NuGet.VisualStudio.Implementation.Exceptions
{
    internal class ProjectNotRestoredException : InvalidOperationException
    {
        public ProjectNotRestoredException()
            : base()
        {
        }

        public ProjectNotRestoredException(string message)
            : base(message)
        {
        }

        public ProjectNotRestoredException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
