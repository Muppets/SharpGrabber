﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTools.SharpGrabber
{
    /// <summary>
    /// Simple abstract implementation for <see cref="IGrabber"/>.
    /// </summary>
    public abstract class BaseGrabber : IGrabber
    {
        public GrabOptions DefaultGrabOptions { get; } = new GrabOptions();

        public WorkStatus Status { get; } = new WorkStatus();

        protected virtual string[] SupportedSchemes { get; }

        public string[] GetSupportedSchemes() => SupportedSchemes;

        public Task<IEnumerable<IGrabbed>> Grab(Uri uri)
        {
            Status.Update(null, "Initializing...", WorkStatusType.Initiating);
            return Grab(uri, DefaultGrabOptions);
        }

        public abstract Task<IEnumerable<IGrabbed>> Grab(Uri uri, GrabOptions options);
    }
}
