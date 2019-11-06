﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTools.SharpGrabber.Media
{
    /// <summary>
    /// <see cref="IGrabbed"/> for media resources
    /// </summary>
    public class GrabbedMedia : IGrabbed
    {
        #region Properties
        public Uri Uri { get; }

        public MediaFormat Format { get; }
        #endregion

        #region Constructors
        public GrabbedMedia(Uri uri, MediaFormat format)
        {
            Uri = uri;
            Format = format;
        }
        #endregion
    }
}
