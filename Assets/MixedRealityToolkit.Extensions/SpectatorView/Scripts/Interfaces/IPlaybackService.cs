﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace Microsoft.MixedReality.Toolkit.Extensions.SpectatorView.Interfaces
{
    public interface IPlaybackService : IDisposable
    {
        void Initialize();
        void Play();
        void Stop();
    }
}