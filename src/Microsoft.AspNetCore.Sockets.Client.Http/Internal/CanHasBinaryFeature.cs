// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Sockets.Client.Http.Internal
{
    public class CanHasBinaryFeature : ICanHasBinaryFeature
    {
        public CanHasBinaryFeature(Mode availableModes)
        {
            AvailableModes = availableModes;
        }

        public Mode AvailableModes { get; }
    }
}
