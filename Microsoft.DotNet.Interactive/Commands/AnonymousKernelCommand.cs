﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.Interactive.Commands
{
    internal class AnonymousKernelCommand : KernelCommandBase
    {
        public AnonymousKernelCommand(
            KernelCommandInvocation handler, 
            string targetKernelName = null)
            : base(targetKernelName)
        {
            Handler = handler;
        }
    }
}