#pragma checksum "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b888f1d7f311dff5f438c318e8d15908a88bdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Race_Klassement), @"mvc.1.0.view", @"/Views/Race/Klassement.cshtml")]
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
#line 1 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\_ViewImports.cshtml"
using Testing0._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\_ViewImports.cshtml"
using Testing0._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3b888f1d7f311dff5f438c318e8d15908a88bdb", @"/Views/Race/Klassement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cf133d7dff7d2b172857d790f1efd3b14f77bf8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Race_Klassement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Testing0._1.Models.Uitslag>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Race", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
  
    ViewData["Title"] = "Index";
    int x = 0;
    int raceid = 0;
    List<int> gebruiksidlist = new List<int>();
    List<int> ritidlist = new List<int>();
    int? bergpunten = 0;
    int? puntenpunten = 0;
    int? strijdpunten = 0;
    string naam = "";
    TimeSpan time = new TimeSpan();
    foreach (var item in Model)
    {
        while (x == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>Placeholder</h1>\r\n            <p>Placeholder</p>\r\n            <h2>");
#nullable restore
#line 20 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rit.Race.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 21 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
            x += 1;
            raceid = item.Rit.RaceID;
        }
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
 if (this.User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3b888f1d7f311dff5f438c318e8d15908a88bdb5841", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 33 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3>Tussenstand</h3>\r\n\r\n<table class=\"table\" id=\"id=\"listtable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
           Write(Html.DisplayNameFor(model => model.Gebruiker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
           Write(Html.DisplayNameFor(model => model.Puntenklassement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
           Write(Html.DisplayNameFor(model => model.Bergklassement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
           Write(Html.DisplayNameFor(model => model.Strijdlustklassement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
           Write(Html.DisplayNameFor(model => model.Algemeenklassement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 59 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
         foreach (var item in Model)
        {
            if (!gebruiksidlist.Contains(item.GebruikerID))
            {
                gebruiksidlist.Add(item.GebruikerID);
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
         foreach (int gebrID in gebruiksidlist)
        {
            bergpunten = 0;
            puntenpunten = 0;
            strijdpunten = 0;
            naam = "";
            time = new TimeSpan();
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
             foreach (var item in Model)
            {
                if (item.GebruikerID == gebrID)
                {
                    bergpunten += item.Bergklassement;
                    puntenpunten += item.Puntenklassement;
                    strijdpunten += item.Strijdlustklassement;
                    naam = item.Gebruiker.VolledigeNaam;
                    time += item.Algemeenklassement;
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
               Write(Html.Raw(naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
               Write(Html.Raw(puntenpunten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 92 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
               Write(Html.Raw(bergpunten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 95 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
               Write(Html.Raw(strijdpunten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 98 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
               Write(Html.Raw(time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 102 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3b888f1d7f311dff5f438c318e8d15908a88bdb12275", async() => {
                WriteLiteral("Alle Ritten");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
                              WriteLiteral(raceid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3b888f1d7f311dff5f438c318e8d15908a88bdb14430", async() => {
                WriteLiteral("Naar Races");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n");
#nullable restore
#line 109 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
     if (this.User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3b888f1d7f311dff5f438c318e8d15908a88bdb15842", async() => {
                WriteLiteral("Race overview (admin)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 112 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 115 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
 foreach (var item in Model)
{
    while (x == 1)
    {
        if (item.Rit.Race.Finished)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Deze race is afgelopen.</p>\r\n");
#nullable restore
#line 122 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"
        }
        else
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>*Deze race is nog niet afgelopen. Er zullen nog nieuwe ritten toegevoegd worden.</p>\r\n");
#nullable restore
#line 127 "C:\Users\Gebruiker\Documents\GitHub\ProjectWebapp2020\Views\Race\Klassement.cshtml"

        }

        x += 1;
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Testing0._1.Models.Uitslag>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
