#pragma checksum "H:\ASPDotNetMVC\PartialThemeIntegration&DataTableIntegration\MBSTU.LibrarySystem\MBSTU.LibrarySystem.WEB\Areas\Admin\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd00a1b77d99701d194f0e74dc61cc11906a98ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Books/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Books_Index))]
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
#line 1 "H:\ASPDotNetMVC\PartialThemeIntegration&DataTableIntegration\MBSTU.LibrarySystem\MBSTU.LibrarySystem.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using MBSTU.LibrarySystem.WEB.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd00a1b77d99701d194f0e74dc61cc11906a98ea", @"/Areas/Admin/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2455fc90ce824c30c02bf7520d61f37b6c2c388", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("PageStyles", async() => {
                BeginContext(22, 123, true);
                WriteLiteral("\r\n    <!-- DataTables -->\r\n    <link rel=\"stylesheet\" href=\"/admin/plugins/datatables-bs4/css/dataTables.bootstrap4.css\">\r\n");
                EndContext();
            }
            );
            BeginContext(148, 22437, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>DataTables</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">DataTables</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">DataTable with default features</h3>
                    </div>
                    <!-- /.ca");
            WriteLiteral(@"rd-header -->
                    <div class=""card-body"">
                        <table id=""example1"" class=""table table-bordered table-striped"">
                            <thead>

                                <tr>
                                    <th>Title</th>
                                    <th>Author</th>
                                    <th>Edition</th>
                                    <th>Publish Date</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Trident</td>
                                    <td>
                                        Internet
                                        Explorer 4.0
                                    </td>
                                    <td>Win 95+</td>
                                    <td> 4</td>
                                    <td>X</td>
                                <");
            WriteLiteral(@"/tr>
                                <tr>
                                    <td>Trident</td>
                                    <td>
                                        Internet
                                        Explorer 5.0
                                    </td>
                                    <td>Win 95+</td>
                                    <td>5</td>
                                    <td>C</td>
                                </tr>
                                <tr>
                                    <td>Trident</td>
                                    <td>
                                        Internet
                                        Explorer 5.5
                                    </td>
                                    <td>Win 95+</td>
                                    <td>5.5</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <t");
            WriteLiteral(@"d>Trident</td>
                                    <td>
                                        Internet
                                        Explorer 6
                                    </td>
                                    <td>Win 98+</td>
                                    <td>6</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Trident</td>
                                    <td>Internet Explorer 7</td>
                                    <td>Win XP SP2+</td>
                                    <td>7</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Trident</td>
                                    <td>AOL browser (AOL desktop)</td>
                                    <td>Win XP</td>
                                    <td>6</td>
                ");
            WriteLiteral(@"                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Firefox 1.0</td>
                                    <td>Win 98+ / OSX.2+</td>
                                    <td>1.7</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Firefox 1.5</td>
                                    <td>Win 98+ / OSX.2+</td>
                                    <td>1.8</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Firefox 2.0</td>
                                    <td>Win 98+ / OSX.2+</td>
                                    <td>1.8</t");
            WriteLiteral(@"d>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Firefox 3.0</td>
                                    <td>Win 2k+ / OSX.3+</td>
                                    <td>1.9</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Camino 1.0</td>
                                    <td>OSX.2+</td>
                                    <td>1.8</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Camino 1.5</td>
                                    <td>OSX.3+</td>
                                    <td>1.8</td>");
            WriteLiteral(@"
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Netscape 7.2</td>
                                    <td>Win 95+ / Mac OS 8.6-9.2</td>
                                    <td>1.7</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Netscape Browser 8</td>
                                    <td>Win 98SE+</td>
                                    <td>1.7</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Netscape Navigator 9</td>
                                    <td>Win 98+ / OSX.2+</td>
          ");
            WriteLiteral(@"                          <td>1.8</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Mozilla 1.0</td>
                                    <td>Win 95+ / OSX.1+</td>
                                    <td>1</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Mozilla 1.1</td>
                                    <td>Win 95+ / OSX.1+</td>
                                    <td>1.1</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Mozilla 1.2</td>
                                    <td>Win 95+ / OSX.1");
            WriteLiteral(@"+</td>
                                    <td>1.2</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Mozilla 1.3</td>
                                    <td>Win 95+ / OSX.1+</td>
                                    <td>1.3</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Mozilla 1.4</td>
                                    <td>Win 95+ / OSX.1+</td>
                                    <td>1.4</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Mozilla 1.5</td>
                                   ");
            WriteLiteral(@" <td>Win 95+ / OSX.1+</td>
                                    <td>1.5</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Mozilla 1.6</td>
                                    <td>Win 95+ / OSX.1+</td>
                                    <td>1.6</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Mozilla 1.7</td>
                                    <td>Win 98+ / OSX.1+</td>
                                    <td>1.7</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Mozilla 1.8</td>
               ");
            WriteLiteral(@"                     <td>Win 98+ / OSX.1+</td>
                                    <td>1.8</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Seamonkey 1.1</td>
                                    <td>Win 98+ / OSX.2+</td>
                                    <td>1.8</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Gecko</td>
                                    <td>Epiphany 2.20</td>
                                    <td>Gnome</td>
                                    <td>1.8</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Webkit</td>
                                    <td>Safari 1.2</td>
  ");
            WriteLiteral(@"                                  <td>OSX.3</td>
                                    <td>125.5</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Webkit</td>
                                    <td>Safari 1.3</td>
                                    <td>OSX.3</td>
                                    <td>312.8</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Webkit</td>
                                    <td>Safari 2.0</td>
                                    <td>OSX.4+</td>
                                    <td>419.3</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Webkit</td>
                                    <td>Safari 3.0</td>
        ");
            WriteLiteral(@"                            <td>OSX.4+</td>
                                    <td>522.1</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Webkit</td>
                                    <td>OmniWeb 5.5</td>
                                    <td>OSX.4+</td>
                                    <td>420</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Webkit</td>
                                    <td>iPod Touch / iPhone</td>
                                    <td>iPod</td>
                                    <td>420.1</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Webkit</td>
                                    <td>S60</td>
             ");
            WriteLiteral(@"                       <td>S60</td>
                                    <td>413</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Presto</td>
                                    <td>Opera 7.0</td>
                                    <td>Win 95+ / OSX.1+</td>
                                    <td>-</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Presto</td>
                                    <td>Opera 7.5</td>
                                    <td>Win 95+ / OSX.2+</td>
                                    <td>-</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Presto</td>
                                    <td>Opera 8.0</td>
             ");
            WriteLiteral(@"                       <td>Win 95+ / OSX.2+</td>
                                    <td>-</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Presto</td>
                                    <td>Opera 8.5</td>
                                    <td>Win 95+ / OSX.2+</td>
                                    <td>-</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Presto</td>
                                    <td>Opera 9.0</td>
                                    <td>Win 95+ / OSX.3+</td>
                                    <td>-</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Presto</td>
                                    <td>Opera 9.2</td>
  ");
            WriteLiteral(@"                                  <td>Win 88+ / OSX.3+</td>
                                    <td>-</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Presto</td>
                                    <td>Opera 9.5</td>
                                    <td>Win 88+ / OSX.3+</td>
                                    <td>-</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Presto</td>
                                    <td>Opera for Wii</td>
                                    <td>Wii</td>
                                    <td>-</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Presto</td>
                                    <td>Nokia N800</td>");
            WriteLiteral(@"
                                    <td>N800</td>
                                    <td>-</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Presto</td>
                                    <td>Nintendo DS browser</td>
                                    <td>Nintendo DS</td>
                                    <td>8.5</td>
                                    <td>C/A<sup>1</sup></td>
                                </tr>
                                <tr>
                                    <td>KHTML</td>
                                    <td>Konqureror 3.1</td>
                                    <td>KDE 3.1</td>
                                    <td>3.1</td>
                                    <td>C</td>
                                </tr>
                                <tr>
                                    <td>KHTML</td>
                                    <td");
            WriteLiteral(@">Konqureror 3.3</td>
                                    <td>KDE 3.3</td>
                                    <td>3.3</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>KHTML</td>
                                    <td>Konqureror 3.5</td>
                                    <td>KDE 3.5</td>
                                    <td>3.5</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Tasman</td>
                                    <td>Internet Explorer 4.5</td>
                                    <td>Mac OS 8-9</td>
                                    <td>-</td>
                                    <td>X</td>
                                </tr>
                                <tr>
                                    <td>Tasman</td>
                           ");
            WriteLiteral(@"         <td>Internet Explorer 5.1</td>
                                    <td>Mac OS 7.6-9</td>
                                    <td>1</td>
                                    <td>C</td>
                                </tr>
                                <tr>
                                    <td>Tasman</td>
                                    <td>Internet Explorer 5.2</td>
                                    <td>Mac OS 8-X</td>
                                    <td>1</td>
                                    <td>C</td>
                                </tr>
                                <tr>
                                    <td>Misc</td>
                                    <td>NetFront 3.1</td>
                                    <td>Embedded devices</td>
                                    <td>-</td>
                                    <td>C</td>
                                </tr>
                                <tr>
                                    <td>Misc</td>
   ");
            WriteLiteral(@"                                 <td>NetFront 3.4</td>
                                    <td>Embedded devices</td>
                                    <td>-</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Misc</td>
                                    <td>Dillo 0.8</td>
                                    <td>Embedded devices</td>
                                    <td>-</td>
                                    <td>X</td>
                                </tr>
                                <tr>
                                    <td>Misc</td>
                                    <td>Links</td>
                                    <td>Text only</td>
                                    <td>-</td>
                                    <td>X</td>
                                </tr>
                                <tr>
                                    <td>Misc</td>
      ");
            WriteLiteral(@"                              <td>Lynx</td>
                                    <td>Text only</td>
                                    <td>-</td>
                                    <td>X</td>
                                </tr>
                                <tr>
                                    <td>Misc</td>
                                    <td>IE Mobile</td>
                                    <td>Windows Mobile 6</td>
                                    <td>-</td>
                                    <td>C</td>
                                </tr>
                                <tr>
                                    <td>Misc</td>
                                    <td>PSP browser</td>
                                    <td>PSP</td>
                                    <td>-</td>
                                    <td>C</td>
                                </tr>
                                <tr>
                                    <td>Other browsers</td>
              ");
            WriteLiteral(@"                      <td>All others</td>
                                    <td>-</td>
                                    <td>-</td>
                                    <td>U</td>
                                </tr>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <th>Title</th>
                                    <th>Author</th>
                                    <th>Edition</th>
                                    <th>Publish Date</th>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </section>
    <!-- /.content -->
</div>

");
            EndContext();
            DefineSection("PageScripts", async() => {
                BeginContext(22608, 594, true);
                WriteLiteral(@"
    <!-- DataTables -->
    <script src=""/admin/plugins/datatables/jquery.dataTables.js""></script>
    <script src=""/admin/plugins/datatables-bs4/js/dataTables.bootstrap4.js""></script>
    <!-- page script -->
    <script>
        $(function () {
            $(""#example1"").DataTable();
            $('#example2').DataTable({
                ""paging"": true,
                ""lengthChange"": false,
                ""searching"": false,
                ""ordering"": true,
                ""info"": true,
                ""autoWidth"": false,
            });
        });
    </script>
");
                EndContext();
            }
            );
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
