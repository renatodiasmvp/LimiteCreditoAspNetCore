#pragma checksum "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0304925662bec21bc91b2d53c26eb4f77e38eb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LIMITES_CREDITO_LIC_Index), @"mvc.1.0.view", @"/Views/LIMITES_CREDITO_LIC/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LIMITES_CREDITO_LIC/Index.cshtml", typeof(AspNetCore.Views_LIMITES_CREDITO_LIC_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0304925662bec21bc91b2d53c26eb4f77e38eb4", @"/Views/LIMITES_CREDITO_LIC/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b0d8ae483c6732bc443e511384719b9b50e684", @"/Views/_ViewImports.cshtml")]
    public class Views_LIMITES_CREDITO_LIC_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LimiteCreditoAspNetCore.Models.LIMITES_CREDITO_LIC>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(115, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(144, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0304925662bec21bc91b2d53c26eb4f77e38eb44955", async() => {
                BeginContext(167, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(181, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(274, 57, false);
#line 16 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDE_CONTRATO_TERCEIRO));

#line default
#line hidden
            EndContext();
            BeginContext(331, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(387, 53, false);
#line 19 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DAT_EXPIRA_LIMITE));

#line default
#line hidden
            EndContext();
            BeginContext(440, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(496, 50, false);
#line 22 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DES_OBSERVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(546, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(602, 58, false);
#line 25 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QTD_PARCELAS_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(660, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(716, 55, false);
#line 28 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VLR_TOTAL_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(771, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(827, 53, false);
#line 31 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PER_TAXA_OPERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(880, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(936, 55, false);
#line 34 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VLR_TARIFA_OPERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(991, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1047, 55, false);
#line 37 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VLR_TOTAL_DESCONTOS));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1158, 57, false);
#line 40 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VLR_LIQUIDO_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1271, 55, false);
#line 43 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NUM_PARCELA_INICIAL));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1382, 46, false);
#line 46 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDE_MOTIVO));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1484, 48, false);
#line 49 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LIS_SITUACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1588, 55, false);
#line 52 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NOM_LOGIN_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1699, 49, false);
#line 55 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DAT_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1748, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1804, 49, false);
#line 58 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DES_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(1853, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1909, 46, false);
#line 61 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.STS_LIMITE));

#line default
#line hidden
            EndContext();
            BeginContext(1955, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2011, 48, false);
#line 64 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DAT_INCLUSAO));

#line default
#line hidden
            EndContext();
            BeginContext(2059, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2115, 54, false);
#line 67 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NOM_LOGIN_INCLUSAO));

#line default
#line hidden
            EndContext();
            BeginContext(2169, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2225, 51, false);
#line 70 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NUM_IP_INCLUSAO));

#line default
#line hidden
            EndContext();
            BeginContext(2276, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2332, 49, false);
#line 73 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DAT_ALTERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(2381, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2437, 55, false);
#line 76 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NOM_LOGIN_ALTERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(2492, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 82 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2610, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2659, 56, false);
#line 85 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IDE_CONTRATO_TERCEIRO));

#line default
#line hidden
            EndContext();
            BeginContext(2715, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2771, 66, false);
#line 88 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Convert.ToDateTime(@item.DAT_EXPIRA_LIMITE).ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2837, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2893, 49, false);
#line 91 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DES_OBSERVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(2942, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2998, 57, false);
#line 94 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QTD_PARCELAS_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3055, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3111, 54, false);
#line 97 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VLR_TOTAL_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3165, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3221, 52, false);
#line 100 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PER_TAXA_OPERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3273, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3329, 54, false);
#line 103 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VLR_TARIFA_OPERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3383, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3439, 54, false);
#line 106 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VLR_TOTAL_DESCONTOS));

#line default
#line hidden
            EndContext();
            BeginContext(3493, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3549, 56, false);
#line 109 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VLR_LIQUIDO_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3605, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3661, 54, false);
#line 112 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NUM_PARCELA_INICIAL));

#line default
#line hidden
            EndContext();
            BeginContext(3715, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3771, 45, false);
#line 115 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IDE_MOTIVO));

#line default
#line hidden
            EndContext();
            BeginContext(3816, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3872, 47, false);
#line 118 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LIS_SITUACAO));

#line default
#line hidden
            EndContext();
            BeginContext(3919, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3975, 54, false);
#line 121 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NOM_LOGIN_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(4029, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4085, 62, false);
#line 124 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Convert.ToDateTime(@item.DAT_APROVACAO).ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4147, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4203, 48, false);
#line 127 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DES_APROVACAO));

#line default
#line hidden
            EndContext();
            BeginContext(4251, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4307, 45, false);
#line 130 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.STS_LIMITE));

#line default
#line hidden
            EndContext();
            BeginContext(4352, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4408, 61, false);
#line 133 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Convert.ToDateTime(@item.DAT_INCLUSAO).ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4469, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4525, 53, false);
#line 136 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NOM_LOGIN_INCLUSAO));

#line default
#line hidden
            EndContext();
            BeginContext(4578, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4634, 50, false);
#line 139 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NUM_IP_INCLUSAO));

#line default
#line hidden
            EndContext();
            BeginContext(4684, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4740, 62, false);
#line 142 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Convert.ToDateTime(@item.DAT_ALTERACAO).ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4802, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4858, 54, false);
#line 145 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NOM_LOGIN_ALTERACAO));

#line default
#line hidden
            EndContext();
            BeginContext(4912, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4967, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0304925662bec21bc91b2d53c26eb4f77e38eb426350", async() => {
                BeginContext(5028, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 148 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
                                       WriteLiteral(item.IDE_LIMITE_CREDITO);

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
            BeginContext(5036, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(5056, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0304925662bec21bc91b2d53c26eb4f77e38eb428748", async() => {
                BeginContext(5120, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 149 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
                                          WriteLiteral(item.IDE_LIMITE_CREDITO);

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
            BeginContext(5131, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(5151, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0304925662bec21bc91b2d53c26eb4f77e38eb431152", async() => {
                BeginContext(5214, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 150 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
                                         WriteLiteral(item.IDE_LIMITE_CREDITO);

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
            BeginContext(5224, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 153 "C:\Users\j_ren\source\repos\LimiteCreditoAspNetCore\LimiteCreditoAspNetCore\Views\LIMITES_CREDITO_LIC\Index.cshtml"
}

#line default
#line hidden
            BeginContext(5263, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LimiteCreditoAspNetCore.Models.LIMITES_CREDITO_LIC>> Html { get; private set; }
    }
}
#pragma warning restore 1591
