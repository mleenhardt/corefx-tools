﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace stress.execution
{
    public interface IWorkerStrategy
    {
        void SpawnWorker(ITestPattern pattern, CancellationToken cancelToken);
    }
}
