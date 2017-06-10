﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace EifelMono.KaOS.Extensions
{
    public static class TasksExtensions
    {
        public static Task AsTask(this CancellationTokenSource cancellationTokenSource)
        {
            return Task.Delay(-1, cancellationTokenSource.Token);
        }
    }
}
