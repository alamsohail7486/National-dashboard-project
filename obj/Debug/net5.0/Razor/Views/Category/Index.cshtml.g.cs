#pragma checksum "C:\Users\md sohail alam\Downloads\Telegram Desktop\DashboardProject\DashboardProject\DashboardProject\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "548078b0eeb77f663a33c6c3f2911270d2a2f742"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\md sohail alam\Downloads\Telegram Desktop\DashboardProject\DashboardProject\DashboardProject\Views\_ViewImports.cshtml"
using DashboardProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\md sohail alam\Downloads\Telegram Desktop\DashboardProject\DashboardProject\DashboardProject\Views\_ViewImports.cshtml"
using DashboardProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"548078b0eeb77f663a33c6c3f2911270d2a2f742", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a36b6357daac120b4f164a364cd8f57a5fff2c46", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Dashboard/plugins/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("insert"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\md sohail alam\Downloads\Telegram Desktop\DashboardProject\DashboardProject\DashboardProject\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "548078b0eeb77f663a33c6c3f2911270d2a2f7424900", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"


<div class=""modal fade"" id=""deleteCateg1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""edit"" aria-hidden=""true"" data-backdrop=""static"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                    <span class=""glyphicon glyphicon-remove"" aria-hidden=""true""></span>
                </button>
                <h4 class=""modal-title custom_align"" id=""Heading"" style=""text-align:center;"">Delete Role</h4>
            </div>
            <div class=""modal-body"">
                <div class=""alert alert-danger"">
                    <input type=""hidden"" class=""form-control"" id=""deltId"" />
                    <i class=""far fa-trash-alt""></i> Are you sure you want to delete this Record?
                </div>
            </div>
            <div class=""modal-footer "">
");
            WriteLiteral(@"                <button type=""button"" class=""btn btn-success"" onclick=""deleteCategory($('#deltId').val())"">
                    <i class=""far fa-thumbs-up""></i> Yes
                </button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">
                    <i class=""far fa-thumbs-down""></i> No
                </button>
            </div>
        </div>
    </div>
</div>
<div>
    <script>

        $(function () {
            $('#instCategory').show();
            $('#updCategory').hide();
            GetAllList();


            $(""#Title"").keyup(function () {      //slug code..
                var Text = $(this).val();
                Text = Text.toLowerCase();
                Text = Text.replace(/[^a-zA-Z0-9]+/g, '-');
                $(""#Slug"").val(Text);
            });

            $('#search12').keyup(function () {

                GetAllList();
            });
        })

        function insertCategory() {
            //debugger;
 ");
            WriteLiteral(@"           //here we are checking it's validation.//

            if ($(""#Title"").val() == """") {
                toastr.error(""Title is required"")
            }
            else if ($(""#Slug"").val() == """") {
                toastr.error(""Slug is required"")
            }
            else if ($(""#isActive"").val() == """") {
                toastr.error(""IsActive is required"")
            }

            else {
                var insobj = {


                    Title: $(""#Title"").val(),
                    Slug: $(""#Slug"").val(),
                    isActive: $('input[name=""isActive""]:checked').val(),
                    entryDate: $(""#entryDate"").val()
                };

                $.ajax({
                    url: ""/Category/insertCategory"",
                    type: ""POST"",
                    data: insobj,
                    success: function (result) {
                        //debugger;
                        toastr.success(""The data is inserted successfully"");
         ");
            WriteLiteral(@"               GetAllList();
                        Reset();

                    },
                    error: function (result) {
                        toastr.error(""Error is occurs"");
                    }

                });
            }
        }

        function GetAllList() {
            // debugger;
            $.ajax({
                url: ""/Category/GetAllList?search="" + $('#search12').val(),
                type: ""get"",
                dataType: ""json"",
                success: function (result) {
                    // debugger;
                    var html = '';
                    var sno = 1;
                    $.each(result, function (key, item) {
                        html += '<tr>';
                        html += '<td>' + sno + '</td>';
                        html += '<td>' + item.title + '</td>';
                        html += ' <td>' + item.slug + '</td>';
                        html += ' <td>' + item.isActive + '</td>';
                        html");
            WriteLiteral(@" += ' <td>' + item.entryDate + '</td>';
                        html += ' <td style= ""Display:flex;""><button type=""button""  class=""btn btn-danger"" style=""margin-right:5%;"" onclick=""deleteconfirm(' + item.id + ')"" class=""deletecat"" data-id=""' + item.id + '""><i class=""far fa-trash-alt""></i></button>';
                        html += ' <button type=""button"" class=""btn btn-primary"" onclick=""Edit(' + item.id + ')"">  <i class=""fas fa-pencil-alt""></i></button></td>';
                        html += '</tr>';
                        sno++;
                    });
                    $("".getCategory"").html(html);
                }
            });
        };



        function Edit(id) {
            //debugger;
            //$('#instCategory').hide();
            //$('#updCategory').show();
            $.ajax({
                url: ""/Category/GetListById?id="" + id,
                type: ""GET"",
                dataType: ""Json"",
                success: function (result) {

                    $('#");
            WriteLiteral(@"instCategory').hide();
                    $('#updCategory').show();

                    $(""#Id"").val(result.id);
                    $(""#Title"").val(result.title);
                    $(""#Slug"").val(result.slug);
                    if (result.isActive) {
                        $('#publish1').prop('checked', true);
                    }
                    else {
                        $('#publish').prop('checked', true);
                    }
                    $(""#entryDate"").val(result.entryDate);
                    GetAllList();
                },
                error: function (result) {
                    toastr.error(""Error is occurs"");
                },
            });
        }

        function updateCategory() {
            //debugger;
            //GetAllList();

            var updobj = {
                Id: $(""#Id"").val(),
                Title: $(""#Title"").val(),
                Slug: $(""#Slug"").val(),
                isActive: $('input[name=""isActive""]:che");
            WriteLiteral(@"cked').val(),
                entryDate: $(""#entryDate"").val()
            }
            $.ajax({
                url: ""/Category/updateCategory"",
                type: ""POST"",
                data: updobj,
                success: function (result) {
                    //debugger;
                    toastr.success(""The data is Updated successfully"");
                    GetAllList();
                    Reset();
                    $('#instCategory').show();
                    $('#updCategory').hide();

                },
                error: function (result) {
                    toastr.error(""The error is occuring on updating time"");
                }
            });
        }

        function deleteCategory(Id) {
            //debugger;

            $.ajax({
                url: ""/Category/deleteCategory"",
                data: { id: Id },
                type: ""Post"",
                success: function (result) {
                    // debugger;
                    to");
            WriteLiteral(@"astr.success(""You have deleted successfully"");
                    GetAllList();
                },
                error: function (result) {
                    toastr.error(""The error is occuring on Deleting Data"");
                },
            });
        };


        function Reset() {
            $(""#Title"").val('');
            $(""#Slug"").val('');
            $(""#entryDate"").val('');
            $(""#deltId"").val('');
        }

        $('.hide input[type=""radio""]').click(function () {
            var value = $(this).val();
            $.ajax({
                url: ""/Category/insertCategory"",
                type: 'post',
                data: { ajax: 1, value: value },
                success: function (response) {
                    $('#response').text(value);
                }
            });
        });

        function deleteconfirm(id) {
            //debugger;
            var con = confirm(""Are you sure you want to delete this Record?"");
            if (con ==");
            WriteLiteral(@"= true) {
                $('#deleteCateg1').modal('show');
                $('#deltId').val(id);
            }
        }
    </script>
</div>

<div class=""content-wrapper"" style=""min-height: 215px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Posts</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Category</a></li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-4"">
 ");
            WriteLiteral("                   <div class=\"card card-default\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "548078b0eeb77f663a33c6c3f2911270d2a2f74215701", async() => {
                WriteLiteral(@"

                            <div class=""card-body"">
                                <input type=""hidden"" class=""form-control"" name=""id"" id=""Id"" />
                                <div class=""form-group"">
                                    <label for=""name"">Title</label>
                                    <input type=""text"" name=""name"" class=""form-control"" id=""Title"" placeholder=""Enter new category name.."" required");
                BeginWriteAttribute("autofocus", " autofocus=\"", 10014, "\"", 10026, 0);
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""off"">
                                    <div class=""invalid-feedback msg-error-name""></div>
                                </div>
                                <div class=""form-group"">
                                    <label for=""name"">Slug</label>
                                    <input type=""text"" name=""name"" class=""form-control"" id=""Slug"" placeholder=""Enter new category name.."" required");
                BeginWriteAttribute("autofocus", " autofocus=\"", 10450, "\"", 10462, 0);
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""off"">
                                    <div class=""invalid-feedback msg-error-name""></div>
                                </div>

                                <div class=""form-group"">
                                    <h4>Enter your IsActive</h4>
                                    <input type=""radio"" id=""publish1"" class=""isActive"" name=""isActive"" value=""True"" checked /> True
                                    <input type=""radio"" id=""publish"" class=""isActive"" name=""isActive"" value=""False"" /> False
                                </div>

                                <div class=""card-footer"">

                                    <button id=""resetCategory"" type=""button"" class=""btn btn-danger"" onclick=""Reset()"">Reset</button>
                                    <button id=""instCategory"" type=""button"" class=""btn btn-info float-right"" onclick=""insertCategory()""> Add New Category</button>
                                    <button id=""updCategory"" type=""button"" class=""btn b");
                WriteLiteral("tn-info float-right\" onclick=\"updateCategory()\"> update Category</button>\r\n\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-md-8"">
                    <div class=""Allpost"">
                        <div class=""flexcreate"">
                            <div>

                            </div>
                            <div>
                                <input type=""text"" name=""title"" id=""search12"" class=""form-control"" placeholder=""Search"">
                            </div>
                        </div>
                        <div class=""postable TBL"">
                            <table class=""table table-striped table-bordered"">
                                <thead>
                                    <tr>
                                        <th>sno</th>
                                        <th>Title</th>
                                        <th>Slug</th>
                                        <th>IsActive</th>
                                        <th>EntryDate</th>
                                        ");
            WriteLiteral(@"<th>Action</th>
                                    </tr>
                                </thead>
                                <tbody class=""getCategory"">
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->
<footer class=""main-footer"">
</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591