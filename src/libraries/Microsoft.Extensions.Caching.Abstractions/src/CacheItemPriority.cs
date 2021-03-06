// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Extensions.Caching.Memory
{
    // TODO: Granularity?
    /// <summary>
    /// Specifies how items are prioritized for preservation during a memory pressure triggered cleanup.
    /// </summary>
    public enum CacheItemPriority
    {
        Low,
        Normal,
        High,
        NeverRemove,
    }
}
