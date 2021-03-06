﻿using Sdl.Web.Common.Configuration;
using Sdl.Web.Common.Interfaces;
using System;

namespace Sdl.Web.Mvc.Statics
{
    /// <summary>
    /// Class to manage static assets such as config and resources. This contains generic methods to serialize assets
    /// based on a root boostrap json file, which recursively loads in more assets. 
    /// Implementations of this class are responsible for implementing the Serialize method
    /// in order to read the static asset from somewhere (eg Broker DB) and serialize it to the file system
    /// </summary>
    [Obsolete("Deprecated in DXA 1.1. We now use IContentProvider.GetStaticContentItem to get static content.")]
    public class BaseStaticFileManager : IStaticFileManager
    {
        [Obsolete("Not supported in DXA 1.1. Static assets are now lazy created/loaded on demand so this method is no longer required", error: true)]
        public virtual string CreateStaticAssets(string applicationRoot)
        {
            return null;
        }

        public string Serialize(string url, Localization loc, bool returnContents = true)
        {
            return SiteConfiguration.ContentProvider.GetStaticContentItem(url, loc).GetText();
        }
    }
}
