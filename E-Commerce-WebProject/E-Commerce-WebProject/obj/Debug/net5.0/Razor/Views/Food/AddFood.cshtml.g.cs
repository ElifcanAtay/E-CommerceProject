#pragma checksum "C:\Users\elifc\source\repos\E-Commerce-WebProject\E-Commerce-WebProject\Views\Food\AddFood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c4c562203d55bb5537c0056a8dc12676857585"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_AddFood), @"mvc.1.0.view", @"/Views/Food/AddFood.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c4c562203d55bb5537c0056a8dc12676857585", @"/Views/Food/AddFood.cshtml")]
    public class Views_Food_AddFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.UrunEkle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\elifc\source\repos\E-Commerce-WebProject\E-Commerce-WebProject\Views\Food\AddFood.cshtml"
  
    ViewData["Title"] = "AddFood";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Food Add Page</h1>\r\n\r\n<br />\r\n<form class=\"form-group\" action=\"AddFood\" asp-controller=\"Food\" method=\"post\" enctype=\"multipart/form-data\">\r\n\r\n    ");
#nullable restore
#line 12 "C:\Users\elifc\source\repos\E-Commerce-WebProject\E-Commerce-WebProject\Views\Food\AddFood.cshtml"
Write(Html.Label("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\elifc\source\repos\E-Commerce-WebProject\E-Commerce-WebProject\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 16 "C:\Users\elifc\source\repos\E-Commerce-WebProject\E-Commerce-WebProject\Views\Food\AddFood.cshtml"
Write(Html.Label("Stock"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\elifc\source\repos\E-Commerce-WebProject\E-Commerce-WebProject\Views\Food\AddFood.cshtml"
Write(Html.TextAreaFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 20 "C:\Users\elifc\source\repos\E-Commerce-WebProject\E-Commerce-WebProject\Views\Food\AddFood.cshtml"
Write(Html.Label("Price"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 21 "C:\Users\elifc\source\repos\E-Commerce-WebProject\E-Commerce-WebProject\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 24 "C:\Users\elifc\source\repos\E-Commerce-WebProject\E-Commerce-WebProject\Views\Food\AddFood.cshtml"
Write(Html.Label("Choose ImageURL"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <input type=\"file\" name=\"ImageURL\" />\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 28 "C:\Users\elifc\source\repos\E-Commerce-WebProject\E-Commerce-WebProject\Views\Food\AddFood.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 29 "C:\Users\elifc\source\repos\E-Commerce-WebProject\E-Commerce-WebProject\Views\Food\AddFood.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.v1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <button class=\"btn btn-primary\">Save</button>\r\n</form>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.UrunEkle> Html { get; private set; }
    }
}
#pragma warning restore 1591
