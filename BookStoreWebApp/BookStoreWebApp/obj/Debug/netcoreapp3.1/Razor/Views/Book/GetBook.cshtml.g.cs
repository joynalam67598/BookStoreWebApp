#pragma checksum "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4216405a3df1c05f25b5e683dc4fd1c99ff97ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetBook), @"mvc.1.0.view", @"/Views/Book/GetBook.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\_ViewImports.cshtml"
using BookStoreWebApp.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
using Microsoft.AspNetCore.Razor.Language.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4216405a3df1c05f25b5e683dc4fd1c99ff97ee", @"/Views/Book/GetBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"580a2176eb7661edb7d929b8aaf9d465b8a79e93", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        private global::AspNetCore.Views_Book_GetBook.__Generated__TopBooksViewComponentTagHelper __TopBooksViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
  
    ViewData["Title"] = "Book Details - " + Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h3 class=""display-4"">Book Details</h3>
    <div class=""row"">
        <div class=""col-sm-6"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-bs-ride=""carousel"">
                <div class=""carousel-indicators"">
");
#nullable restore
#line 14 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"button\" data-bs-target=\"#carouselExampleIndicators\" data-bs-slide-to=\"");
#nullable restore
#line 16 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class= \"", 663, "\"", 695, 1);
#nullable restore
#line 16 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 672, i==0 ? "active" : "", 672, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-current=\"true\" aria-label=\"Slide 1\"></button>\r\n");
#nullable restore
#line 17 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n                <div class=\"carousel-inner\">\r\n                    \r\n");
#nullable restore
#line 22 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 987, "\"", 1032, 2);
            WriteAttributeValue("", 995, "carousel-item", 995, 13, true);
#nullable restore
#line 24 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
WriteAttributeValue(" ", 1008, i==0 ? "active" : "", 1009, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4216405a3df1c05f25b5e683dc4fd1c99ff97ee6683", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                          WriteLiteral(Model.Gallery[i].Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
AddHtmlAttributeValue("", 1156, Model.Gallery[i].Name, 1156, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 27 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Previous</span>
                </button>
                <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Next</span>
                </button>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h1>");
#nullable restore
#line 43 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 text-primary\">\r\n                    <span class=\"label label-primary\">By: </span>\r\n                    <span class=\"monospaced\">");
#nullable restore
#line 50 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                                        Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p class=\"description\">\r\n                        ");
#nullable restore
#line 57 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-4"">
                    <button type=""button"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"" class=""btn btn-outline-primary"">
                        Read now
                    </button>
                </div>
            </div>

            <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog modal-lg"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""exampleModalLabel"">");
#nullable restore
#line 74 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                                                                      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button>\r\n                        </div>\r\n                        <div class=\"modal-body\">\r\n");
            WriteLiteral("                            <iframe");
            BeginWriteAttribute("src", " src=\"", 3642, "\"", 3665, 1);
#nullable restore
#line 79 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 3648, Model.BookPdfUrl, 3648, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""w-100"" height=""300""></iframe>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                            <button type=""button"" class=""btn btn-primary"">Save changes</button>
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Category - </span> ");
#nullable restore
#line 92 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                                                                                         Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Total pages - </span> ");
#nullable restore
#line 93 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                                                                                            Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Language Id - </span> ");
#nullable restore
#line 94 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
                                                                                            Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ul>
        </div>
    </div>

   
    

    <div class=""container px-4 px-lg-5 mt-5"" id=""similarBook"">
        <h1>Similar Books</h1>
        <hr />
        <div class=""row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center"">
            
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:top-books", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4216405a3df1c05f25b5e683dc4fd1c99ff97ee15770", async() => {
            }
            );
            __TopBooksViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Book_GetBook.__Generated__TopBooksViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__TopBooksViewComponentTagHelper);
#nullable restore
#line 107 "C:\Users\DELL\Desktop\DOT NET\dot net core 04-07-2021\BookStoreWebApp\BookStoreWebApp\Views\Book\GetBook.cshtml"
__TopBooksViewComponentTagHelper.count = 4;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("count", __TopBooksViewComponentTagHelper.count, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:top-books")]
        public class __Generated__TopBooksViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__TopBooksViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int32 count { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("TopBooks", new { count });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591