#pragma checksum "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78d366d8b052142fde503c4b559420cc2daae9f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LIMITES_CREDITO_LIC_Details), @"mvc.1.0.view", @"/Views/LIMITES_CREDITO_LIC/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LIMITES_CREDITO_LIC/Details.cshtml", typeof(AspNetCore.Views_LIMITES_CREDITO_LIC_Details))]
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
#line 1 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\_ViewImports.cshtml"
using LimiteCreditoAspNetCore;

#line default
#line hidden
#line 2 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\_ViewImports.cshtml"
using LimiteCreditoAspNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78d366d8b052142fde503c4b559420cc2daae9f2", @"/Views/LIMITES_CREDITO_LIC/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b0d8ae483c6732bc443e511384719b9b50e684", @"/Views/_ViewImports.cshtml")]
    public class Views_LIMITES_CREDITO_LIC_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LimiteCreditoAspNetCore.Models.LIMITES_CREDITO_LIC>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(104, 142, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>LIMITES_CREDITO_LIC</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(247, 57, false);
#line 14 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IDE_CONTRATO_TERCEIRO));

#line default
#line hidden
            EndContext();
            BeginContext(304, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(368, 53, false);
#line 17 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.IDE_CONTRATO_TERCEIRO));

#line default
#line hidden
            EndContext();
            BeginContext(421, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(484, 53, false);
#line 20 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DAT_EXPIRA_LIMITE));

#line default
#line hidden
            EndContext();
            BeginContext(537, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(601, 49, false);
#line 23 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.DAT_EXPIRA_LIMITE));

#line default
#line hidden
            EndContext();
            BeginContext(650, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(713, 50, false);
#line 26 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DES_OBSERVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(763, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(827, 46, false);
#line 29 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.DES_OBSERVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(873, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(936, 58, false);
#line 32 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QTD_PARCELAS_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(994, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1058, 54, false);
#line 35 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.QTD_PARCELAS_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1175, 55, false);
#line 38 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VLR_TOTAL_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1294, 51, false);
#line 41 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.VLR_TOTAL_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1408, 53, false);
#line 44 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PER_TAXA_OPERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1525, 49, false);
#line 47 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.PER_TAXA_OPERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1574, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1637, 55, false);
#line 50 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VLR_TARIFA_OPERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1692, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1756, 51, false);
#line 53 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.VLR_TARIFA_OPERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1870, 55, false);
#line 56 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VLR_TOTAL_DESCONTOS));

#line default
#line hidden
            EndContext();
            BeginContext(1925, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1989, 51, false);
#line 59 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.VLR_TOTAL_DESCONTOS));

#line default
#line hidden
            EndContext();
            BeginContext(2040, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2103, 57, false);
#line 62 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VLR_LIQUIDO_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(2160, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2224, 53, false);
#line 65 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.VLR_LIQUIDO_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(2277, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2340, 55, false);
#line 68 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NUM_PARCELA_INICIAL));

#line default
#line hidden
            EndContext();
            BeginContext(2395, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2459, 51, false);
#line 71 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.NUM_PARCELA_INICIAL));

#line default
#line hidden
            EndContext();
            BeginContext(2510, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2573, 46, false);
#line 74 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IDE_MOTIVO));

#line default
#line hidden
            EndContext();
            BeginContext(2619, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2683, 42, false);
#line 77 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.IDE_MOTIVO));

#line default
#line hidden
            EndContext();
            BeginContext(2725, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2788, 48, false);
#line 80 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LIS_SITUACAO));

#line default
#line hidden
            EndContext();
            BeginContext(2836, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2900, 44, false);
#line 83 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.LIS_SITUACAO));

#line default
#line hidden
            EndContext();
            BeginContext(2944, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3007, 55, false);
#line 86 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NOM_LOGIN_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3062, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3126, 51, false);
#line 89 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.NOM_LOGIN_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3177, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3240, 49, false);
#line 92 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DAT_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3289, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3353, 45, false);
#line 95 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.DAT_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3398, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3461, 49, false);
#line 98 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DES_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3510, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3574, 45, false);
#line 101 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.DES_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3619, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3682, 46, false);
#line 104 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.STS_LIMITE));

#line default
#line hidden
            EndContext();
            BeginContext(3728, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3792, 42, false);
#line 107 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.STS_LIMITE));

#line default
#line hidden
            EndContext();
            BeginContext(3834, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3897, 48, false);
#line 110 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DAT_INCLUSAO));

#line default
#line hidden
            EndContext();
            BeginContext(3945, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4009, 44, false);
#line 113 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.DAT_INCLUSAO));

#line default
#line hidden
            EndContext();
            BeginContext(4053, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4116, 54, false);
#line 116 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NOM_LOGIN_INCLUSAO));

#line default
#line hidden
            EndContext();
            BeginContext(4170, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4234, 50, false);
#line 119 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.NOM_LOGIN_INCLUSAO));

#line default
#line hidden
            EndContext();
            BeginContext(4284, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4347, 51, false);
#line 122 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NUM_IP_INCLUSAO));

#line default
#line hidden
            EndContext();
            BeginContext(4398, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4462, 47, false);
#line 125 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.NUM_IP_INCLUSAO));

#line default
#line hidden
            EndContext();
            BeginContext(4509, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4572, 49, false);
#line 128 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DAT_ALTERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(4621, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4685, 45, false);
#line 131 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.DAT_ALTERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(4730, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4793, 55, false);
#line 134 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NOM_LOGIN_ALTERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(4848, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4912, 51, false);
#line 137 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
       Write(Html.DisplayFor(model => model.NOM_LOGIN_ALTERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(4963, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(5010, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78d366d8b052142fde503c4b559420cc2daae9f224200", async() => {
                BeginContext(5072, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 142 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Details.cshtml"
                           WriteLiteral(Model.IDE_LIMITE_CREDITO);

#line default
#line hidden
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
            EndContext();
            BeginContext(5080, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(5088, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78d366d8b052142fde503c4b559420cc2daae9f226576", async() => {
                BeginContext(5110, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5126, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LimiteCreditoAspNetCore.Models.LIMITES_CREDITO_LIC> Html { get; private set; }
    }
}
#pragma warning restore 1591