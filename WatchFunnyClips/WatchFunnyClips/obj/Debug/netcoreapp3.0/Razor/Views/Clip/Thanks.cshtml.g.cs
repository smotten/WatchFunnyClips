#pragma checksum "/home/magnus/Desktop/NetCore/WatchFunnyClips/WatchFunnyClips/Views/Clip/Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "543d9e633d11ee6b50e74bcfdcfe4b65eb49eee5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clip_Thanks), @"mvc.1.0.view", @"/Views/Clip/Thanks.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/magnus/Desktop/NetCore/WatchFunnyClips/WatchFunnyClips/Views/_ViewImports.cshtml"
using WatchFunnyClips;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/magnus/Desktop/NetCore/WatchFunnyClips/WatchFunnyClips/Views/_ViewImports.cshtml"
using WatchFunnyClips.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"543d9e633d11ee6b50e74bcfdcfe4b65eb49eee5", @"/Views/Clip/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da1cb3dab7a8b82a413e900fe330bc93634323b", @"/Views/_ViewImports.cshtml")]
    public class Views_Clip_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Clip>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\nThanks, for registering ");
#nullable restore
#line 10 "/home/magnus/Desktop/NetCore/WatchFunnyClips/WatchFunnyClips/Views/Clip/Thanks.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\nThanks, ");
#nullable restore
#line 12 "/home/magnus/Desktop/NetCore/WatchFunnyClips/WatchFunnyClips/Views/Clip/Thanks.cshtml"
   Write(ViewBag.Thanks);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\nThanks again ");
#nullable restore
#line 14 "/home/magnus/Desktop/NetCore/WatchFunnyClips/WatchFunnyClips/Views/Clip/Thanks.cshtml"
        Write(ViewBag.Clip.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" who likes ");
#nullable restore
#line 14 "/home/magnus/Desktop/NetCore/WatchFunnyClips/WatchFunnyClips/Views/Clip/Thanks.cshtml"
                                      Write(ViewBag.Clip.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clip> Html { get; private set; }
    }
}
#pragma warning restore 1591
