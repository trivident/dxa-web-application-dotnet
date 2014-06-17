﻿using Sdl.Web.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Sdl.Web.Mvc.Common
{
    public interface IRenderer
    {
        MvcHtmlString Render(object item, HtmlHelper helper, int containerSize = 0, List<string> excludedItems = null);
        MvcHtmlString Render(Region region, HtmlHelper helper, int containerSize = 0, List<string> excludedItems = null);
    }
}