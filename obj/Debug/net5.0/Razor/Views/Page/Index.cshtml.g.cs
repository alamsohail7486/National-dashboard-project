#pragma checksum "C:\Users\md sohail alam\Downloads\Telegram Desktop\DashboardProject\DashboardProject\DashboardProject\Views\Page\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9df4ba5ad457dc34d0d822bb9ca94edc6ab3243b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Index), @"mvc.1.0.view", @"/Views/Page/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df4ba5ad457dc34d0d822bb9ca94edc6ab3243b", @"/Views/Page/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a36b6357daac120b4f164a364cd8f57a5fff2c46", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Dashboard/plugins/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Page", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df4ba5ad457dc34d0d822bb9ca94edc6ab3243b5121", async() => {
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
            WriteLiteral(@"


<!-- Button trigger modal -->
<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalLong"">
    Launch demo modal
</button>

<!-- Modal -->
<div class=""modal fade"" id=""Showdata"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"" style=""max-width: 800px;"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modele"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df4ba5ad457dc34d0d822bb9ca94edc6ab3243b6952", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div>
                        <!-- Content Header (Page header) -->
                        <div class=""content-header"">
                            <div class=""container-fluid"">
                                <div class=""row mb-2"">
                                    <div class=""col-sm-6"">
                                        <h1 class=""m-0"">Pages</h1>
                                    </div><!-- /.col -->
                                    <div class=""col-sm-6"">
                                        <ol class=""breadcrumb float-sm-right"">
                                            <li class=""breadcrumb-item""><a href=""#"">Pages</a></li>
                                            <li class=""breadcrumb-item active"">Add New</li>
                                        </ol>
                                    </div><!-- /.col -->
                                </div><!-- /.row -->
                            </div><!-- /.co");
                WriteLiteral(@"ntainer-fluid -->
                        </div>
                        <!-- /.content-header -->
                        <!-- Main content -->
                        <section class=""content"">
                            <div class=""container-fluid"">
                                <div class=""row"">
                                    <div class=""col-md-8"">
                                        <div class=""card mb-4"">
                                            <div class=""card-header pb-0"">
                                                <div class=""card-body"">
                                                    <input type=""hidden"" class=""form-control"" name=""id"" id=""Id"" />
                                                    <div class=""form-group"">
                                                        <h6>Title</h6>
                                                        <input type=""text"" id=""title"" class=""form-control"" autocomplete=""off"" placeholder=""Enter title"">
                    ");
                WriteLiteral(@"                                </div>
                                                    <div class=""form-group"">
                                                        <h6>Slug</h6>
                                                        <input type=""text"" id=""slug"" class=""form-control"" autocomplete=""off"" placeholder=""Enter slug"">
                                                    </div>
                                                    <div class=""form-group Description"">
                                                        <h6>Description</h6>
                                                        <textarea class=""form-control"" id=""textareas"" placeholder=""Enter Description""></textarea>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""");
                WriteLiteral(@"col-md-4"">
                                        <div class=""card mb-4"">
                                            <div class=""card-header pb-0"">
                                                <div class=""form-group"">
                                                    <h6>Featured Image</h6>
                                                    <div class=""file-upload"">
                                                        <div class=""image-upload-wrap""");
                BeginWriteAttribute("style", " style=\"", 4571, "\"", 4579, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                            <input name=""ImageFile"" id=""images"" class=""file-upload-input"" type=""file"" onchange=""readURL(this);"" accept=""image/*"">
                                                            <div class=""drag-text"">
                                                                <h3>Click to Upload Image</h3>
                                                            </div>
                                                        </div>
                                                        <div class=""file-upload-content"" style=""display: none;"">
                                                            <img class=""file-upload-image"" alt=""your image"">
                                                            <div class=""image-title-wrap"">
                                                                <button type=""button"" onclick=""removeUpload()"" class=""remove-image"">
                                                                    Remove <spa");
                WriteLiteral(@"n class=""image-title"">Uploaded Image</span>
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""Metades"">
                                                    <div class=""form-group"">
                                                        <h6>Meta Description</h6>
                                                        <input type=""text"" class=""form-control"" id=""desc"" placeholder=""Enter meta description"">
                                                    </div>
                                                    <div class=""form-group"">
                                                        <h6>Meta Keyword</h6>
                                                        <input");
                WriteLiteral(@" type=""text"" class=""form-control"" id=""key"" placeholder=""Enter meta keyword"">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""card"">
                                            <div class=""form-group"">
                                                <h6 class=""Publish"">Active</h6>
                                            </div>
                                            <div class=""padd10"">
                                                <input type=""radio"" id=""publish1"" class=""isActive"" name=""isActive"" value=""True"" checked /> True
                                                <input type=""radio"" id=""publish"" class=""isActive"" name=""isActive"" value=""False"" /> False
");
                WriteLiteral("                                                <div class=\"padd10\">\r\n");
                WriteLiteral(@"
                                                    <button id=""resetPage"" type=""button"" class=""btn btn-danger"" onclick=""Reset()"">Reset</button>
                                                    <button id=""insPage"" type=""button"" class=""btn btn-info float-right"" onclick=""InsertPage()""> Add New Page</button>
                                                    <button id=""updPage"" type=""button"" class=""btn btn-info float-right"" onclick=""updatePage()""> update Page</button>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </section>
                        <!-- /.content -->
                    </div>

                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                </div>
</div>
    </div>
</div>

<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Pages</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Pages</a></li>
                        <li class=""breadcrumb-item active"">All Pages</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!--");
            WriteLiteral(@" /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <section class=""content"">
                <div class=""container-fluid"">
                    <div class=""Allpost"">
                        <div class=""flexcreate"">
                            <div>
                                <a href=""/Page/AddNewPage"" class=""btn btn-primary"">Create</a>
                            </div>
                            <div>
                                <input type=""text"" name=""title"" id=""search12"" class=""form-control"" placeholder=""Search"">
                            </div>
                        </div>
                        <div class=""postable TBL"">
                            <table class=""table table-striped table-bordered"">
                                <thead>
                                    <tr>

                                        <th>ID</th>
                    ");
            WriteLiteral(@"                    <th>Title</th>
                                        <th>Slug</th>
                                        <th>Description</th>
                                        <th>Image</th>
                                        <th>Active</th>
                                        <th>Action</th>
                                    </tr>
                                </thead>
                                <tbody class=""page"">
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </section>
    <!-- /.content -->
</div>


<div class=""modal fade"" id=""deletePage1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""edit"" aria-hidden=""true"" data-backdrop=""static"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dism");
            WriteLiteral(@"iss=""modal"" aria-hidden=""true"">
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
            WriteLiteral(@"                <button type=""button"" class=""btn btn-success"" onclick=""deletePage($('#deltId').val())"">
                    <i class=""far fa-thumbs-up""></i> Yes
                </button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">
                    <i class=""far fa-thumbs-down""></i> No
                </button>
            </div>
        </div>
    </div>
</div>

<script>

    $(document).ready(function () {
        console.log(""ready!"");
        PageList();
    });

    //$('#textarea').summernote('code');

    $(function () {

        toastr.success(""page loaded"");
        $('#insPage').show();
        $('#updPage').hide();
        PageList();
        //$('#edit').summernote();


        $(""#title"").keyup(function () {
            var Text = $(this).val();
            Text = Text.toLowerCase();
            Text = Text.replace(/[^a-zA-Z0-9]+/g, '-');
            $(""#slug"").val(Text);
        });

      

    })
    var pageForm ");
            WriteLiteral(@"= function () {
        var content = $('textarea[name=""Description""]').html($('#edit').code());
    }

    function InsertPage() {
        debugger;
        //here we are checking it's validation.//

        if ($(""#title"").val() == """") {
            toastr.error(""Please Enter Title "")
        }
        else if ($(""#slug"").val() == """") {
            toastr.error(""Please Enter Slug "")
        }
        else if ($(""#desc"").val() == """") {
            toastr.error(""Please enter description "")
        }
        else if ($(""#images"").val() == """") {
            toastr.error(""Please select image "")
        }
        else if ($('#key').val() === '') {
            toastr.error(""Please enter key "")
        }
        else if ($(""#isActive"").val() == """") {
            toastr.error(""IsActive is required"")
        }

        else {
            var instobj = {

                Title: $(""#title"").val(),
                Slug: $(""#slug"").val(),
                // Description: $(""#Description"").v");
            WriteLiteral(@"al(),
                Description: $('#textareas').summernote('code'),
                //Image: document.getElementById(""images"").files[0].name ,
                Image: $(""#images"").val(),
                isActive: $('input[name=""isActive""]:checked').val(),
                metaDesc: $('#desc').val(),
                metaKeys: $('#key').val()

            };

            $.ajax({
               
                url: ""/Page/InsertPage"",
                type: ""POST"",
                data: instobj,
                success: function (result) {
                    debugger;
                    toastr.success(""The data is inserted successfully"");
                    PageList();
                    $('#Showdata').modal('hide');
                    Reset();

                },

                error: function (result) {
                    toastr.error(""Error is occurs"");
                }
            });
        }
    }

    function PageList() {
        debugger;
        // alert('he");
            WriteLiteral(@"llo');
        $.ajax({
            url: ""/Page/PageList"",
            type: ""GET"",
            dataType: ""Json"",
            success: function (result) {
                debugger;
                // console.log('here the results showing', result);

                var html = '';
                var sno = 1;
                $.each(result, function (key, item) {
                    // console.log('alam ko item results', item);
                    html += '<tr>';
                    html += '<td>' + sno + '</td>';
                    html += '<td>' + item.title + '</td>';
                    html += '  <td>' + item.slug + '</td>';
                    html += ' <td>' + item.description + '</td>';
                    html += ' <td><img src=""../Images/' + item.image + '"" height=""50"" width=""50""/></td>';
                    html += ' <td>' + item.isActive + '</td>';
                    html += ' <td style= ""Display:flex;""><button type=""button"" class=""btn btn-danger"" style=""margin-right:5%;"" oncli");
            WriteLiteral(@"ck=""deleteconfirm(' + item.id + ')""  class=""deletepag"" data-id=""' + item.Id + ' data-img=' + item.image + '><i class=""far fa-trash-alt""></i></button>';
                    html += '| <button type=""button"" class=""btn btn-primary""  onclick=""Edit(' + item.id + ')""><i class=""fas fa-pencil-alt""></i></button></td>';

                    html += '</tr>';
                    sno++;
                });
                $("".page"").html(html);
            }
        });
    }

    $('.page').on('click', ""#deletePage"", function () {
        var id = $(this).attr(""data-id"");
        var image = $(this).attr(""data-img"");
        DeletePage(id, image);
    });

    function Edit(Id) {
        debugger;
        // console.log(""function called"");

        $.ajax({
            url: ""/Page/GetPageById?Id="" + Id,
            type: ""GET"",
            dataType: ""Json"",
            success: function (result) {
                debugger;
                //console.log('allam result', result);
                ");
            WriteLiteral(@"$('#insPage').hide();
                $('#updPage').show();
                $('#Showdata').modal('show');

                $(""#Id"").val(result.id);
                $(""#title"").val(result.title);
                $(""#slug"").val(result.slug);
                $(""#edit"").summernote(""code"", result.description);
                $(""#Imagedit"").html('<img src=""../Images/' + result.image + '"" height=""50"" width=""50"" />');
                if (result.isActive) {
                    $('#publish1').prop('checked', true);
                }
                else {
                    $('#publish').prop('checked', true);
                }
                $('#desc').val(result.metaDesc);
                $('#key').val(result.metaKeys);
                PageList();
            },

            error: function (result) {
                toastr.error(""Error is occurs"");
            },
        });
    }

    function updatePage() {
        debugger
        var updobj = {
            Id: $(""#Id"").val(),
   ");
            WriteLiteral(@"         Title: $(""#title"").val(),
            Slug: $(""#slug"").val(),
            Description: $(""#textareas"").summernote('code'),
            Image: $(""#images"").val(),
            isActive: $('input[name=""isActive""]:checked').val(),
            metaDesc: $('#desc').val(),
            metaKeys: $('#key').val()

        };
        $.ajax({
            url: ""/Page/UpdatePage"",
            type: ""POST"",
            data: updobj,
            success: function (result) {
                toastr.success(""The data is Updated successfully"");
                PageList();
                Reset();
                $('#insPage').show();
                $('#updPage').hide();
                $('#Showdata').modal('hide');
            },
            error: function (result) {
                toastr.error(""The error is occuring on updating time"");
            }
        });
    }

    function deletePage(Id) {

        $.ajax({
            url: ""/Page/DeletePage"",
            data: { id: Id },
  ");
            WriteLiteral(@"          type: ""Post"",
            success: function (result) {
                toastr.success(""You have deleted successfully"");
                PageList();

            },
            error: function (result) {
                toastr.error(""The error is occuring on Deleting Data"");
            },
        });
    };

    function Reset() {
        $(""#title"").val('');
        $(""#slug"").val('');
        //$(""#edit"").summernote('code', """");
        $(""#images"").val('');
        $(""#Imagedit"").html('');
        $(""#deltId"").val('');
        $('#textareas').summernote('code', """");
        //$('#categoryId').val("""");
        // $('#ImageFile').val("""");
        $('#desc').val("""");
        $('#key').val("""");

    }

    $('.hide input[type=""radio""]').click(function () {
        var value = $(this).val();
        $.ajax({
            url: ""/Page/InsertPage"",
            type: 'post',
            data: { ajax: 1, value: value },
            success: function (response) {
           ");
            WriteLiteral(@"     $('#response').text(value);
            }
        });
    });

    function deleteconfirm(id) {
        //debugger;
        var con = confirm(""Are you sure you want to delete this Record?"");
        if (con === true) {
            $('#deletePage1').modal('show');
            $('#deltId').val(id);
        }
    }

    $("".custom-file-input"").on(""change"", function () {
        //console.log($(this));
        //var filename = $(this).val().split(""\\"").pop();
        //$(this).next("".custom-file-label"").html(filename);custom-file-input

        var filelabel1 = $(this).next("".custom-file-input"");
        var files = $(this)[0].files;
        if (files.length > 1) {
            filelabel1.html(files.length + 'files selected');

        }
        else if (files.length == 1) {
            filelabel1.html(files[0].name);
        }
    })

    //$(document).ready(function (){

    //    submitHandler: function (form) {
    //        alert('valid form submission'); // for demo
   ");
            WriteLiteral(@" //        $.ajax({
    //            type: ""POST"",
    //            url: ""Page/button"",
    //            data: $(form).serialize(),
    //            success: function () {
    //                $(form).html(""<div id='message'></div>"");
    //                $('#message').html(""<h2>Your request is on the way!</h2>"")
    //                    .append(""<p>someone</p>"")
    //                    .hide()
    //                    .fadeIn(1500, function () {
    //                        $('#message').append(""<img id='checkmark' src='images/ok.png' />"");
    //                    });
    //            }
    //        });
    //        return false; // required to block normal submit since you used ajax
    //    }
    //});

</script>");
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