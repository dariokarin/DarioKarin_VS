#pragma checksum "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6d8389cdf0cbca00f5ef4447d9f4126d57d0ca8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
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
#line 1 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\_ViewImports.cshtml"
using CheapestFlightSearch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\_ViewImports.cshtml"
using CheapestFlightSearch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d8389cdf0cbca00f5ef4447d9f4126d57d0ca8", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f81eddce234528c8d3bcae19cce83363b2c08b10", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CheapestFlightSearch.Entity.ViewModel.SearchResultViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>Departure</th>
                <th>Destination</th>
                <th>Departure date</th>
                <th>Return date</th>
                <th>Transfers to destination</th>
                <th>Return Transfers</th>
                <th>Passengers</th>
                <th>Currency</th>
                <th>Total price</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
                   Write(item.DepartureAirportName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
                   Write(item.ArrivalAirportName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
                   Write(item.DepartureDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
                   Write(item.ReturnDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
                   Write(item.DepartureTransfers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
                   Write(item.ReturnTransfers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
                   Write(item.Passengers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
                   Write(item.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 36 "C:\Users\dario\Downloads\Dario_test_VS\CheapestFlightSearch\CheapestFlightSearch\Views\Home\Results.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CheapestFlightSearch.Entity.ViewModel.SearchResultViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
