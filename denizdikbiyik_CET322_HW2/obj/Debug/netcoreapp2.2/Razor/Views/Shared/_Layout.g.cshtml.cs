#pragma checksum "C:\Users\Deniz\Desktop\322sonödev\denizdikbiyik_CET322_HW2\denizdikbiyik_CET322_HW2\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0803e13fe9bd353364dddb6bc2fc16135e298cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\Deniz\Desktop\322sonödev\denizdikbiyik_CET322_HW2\denizdikbiyik_CET322_HW2\Views\_ViewImports.cshtml"
using denizdikbiyik_CET322_HW2;

#line default
#line hidden
#line 2 "C:\Users\Deniz\Desktop\322sonödev\denizdikbiyik_CET322_HW2\denizdikbiyik_CET322_HW2\Views\_ViewImports.cshtml"
using denizdikbiyik_CET322_HW2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0803e13fe9bd353364dddb6bc2fc16135e298cd", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a424e2aadde9a2992fa45b537eff4607f6189bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 208, true);
            WriteLiteral("<!--Author: W3layouts\r\nAuthor URL: http://w3layouts.com\r\nLicense: Creative Commons Attribution 3.0 Unported\r\nLicense URL: http://creativecommons.org/licenses/by/3.0/\r\n-->\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n");
            EndContext();
            BeginContext(208, 1187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0803e13fe9bd353364dddb6bc2fc16135e298cd3684", async() => {
                BeginContext(214, 1174, true);
                WriteLiteral(@"
    <title>Öğrenci ve Departmanlar</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta charset=""utf-8"" />
    <meta name=""keywords"" content=""öğrenci, departman"" />
    <script>
        addEventListener(""load"", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
    <!-- Custom Theme files -->
    <link href=""css/bootstrap.css"" type=""text/css"" rel=""stylesheet"" media=""all"">
    <!-- shop css -->
    <link href=""css/shop.css"" type=""text/css"" rel=""stylesheet"" media=""all"">
    <!-- Owl Stylesheets -->
    <link href=""css/style.css"" type=""text/css"" rel=""stylesheet"" media=""all"">
    <!-- font-awesome icons -->
    <link href=""css/fontawesome-all.min.css"" rel=""stylesheet"">
    <!-- //Custom Theme files -->
    <!-- online-fonts -->
    <link href=""//fonts.googleapis.com/css?family=Elsie+Swash+Caps:400,900"" rel=""stylesheet"">
    <link href=""//f");
                WriteLiteral("onts.googleapis.com/css?family=Source+Sans+Pro:200,200i,300,300i,400,400i,600,600i,700,700i,900,900i\" rel=\"stylesheet\">\r\n    <!-- //online-fonts -->\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1395, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1397, 6204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0803e13fe9bd353364dddb6bc2fc16135e298cd6129", async() => {
                BeginContext(1403, 1509, true);
                WriteLiteral(@"
    <!-- header -->
    <header>
        <div class=""container"">
            <!-- top nav -->
            <nav class=""top_nav d-flex pt-3 pb-1"">
            </nav>
            <!-- //top nav -->
            <!-- bottom nav -->
            <nav class=""navbar navbar-expand-lg navbar-light justify-content-center"">
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav mx-auto text-center"">
                        <li class=""nav-item dropdown has-mega-menu"" style=""position:static;"">
                            <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""");
                WriteLiteral(@"true"" aria-expanded=""false"">Departmanlar</a>
                            <div class=""dropdown-menu"" style=""width:100%"">
                                <div class=""px-0 container"">
                                    <div class=""row"">
                                        <div class=""col-md-4"">
                                            <a class=""dropdown-item"" href=""#""></a>
                                            <ul>
                                                ");
                EndContext();
                BeginContext(2914, 45, false);
#line 60 "C:\Users\Deniz\Desktop\322sonödev\denizdikbiyik_CET322_HW2\denizdikbiyik_CET322_HW2\Views\Shared\_Layout.cshtml"
                                            Write(await Component.InvokeAsync("DepartmentMenu"));

#line default
#line hidden
                EndContext();
                BeginContext(2960, 766, true);
                WriteLiteral(@"
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
            </nav>
            <!-- //bottom nav -->
        </div>
        <!-- //header container -->
    </header>
    <!-- //header -->
    <!-- inner banner -->
    <div class=""ibanner_w3 pt-sm-5 pt-3"">
        <h4 class=""head_agileinfo text-center text-capitalize text-center pt-5"">
            <span>d</span>eniz
            <span>d</span>ikbıyık
        </h4>
    </div>
    <!-- //inner banner -->
    <!-- breadcrumbs -->
    <br />
    ");
                EndContext();
                BeginContext(3727, 12, false);
#line 85 "C:\Users\Deniz\Desktop\322sonödev\denizdikbiyik_CET322_HW2\denizdikbiyik_CET322_HW2\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3739, 3811, true);
                WriteLiteral(@"
    <!-- //breadcrumbs -->
    <br />
    <footer>
        <div class=""footerv2-w3ls"">
            <div class=""container-fluid py-5 footer-copy_w3ls"">
                <div class=""d-lg-flex justify-content-between"">

                    <div class=""cpy-right align-self-center"">
                        <h2 class=""agile_btxt"">
                            <a href=""#"">
                                <span>d</span>eniz
                                <span>d</span>ikbıyık
                            </a>
                        </h2>
                        <p>
                            © Deniz Dikbıyık'ın 3. ödevidir.
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- //footer -->
    <!-- js -->
    <script src=""js/jquery-2.2.3.min.js""></script>
    <!-- //js -->
    <!-- smooth dropdown -->
    <script>
        $(document).ready(function () {
            $('ul li.dropdown').hover(function () {
");
                WriteLiteral(@"                $(this).find('.dropdown-menu').stop(true, true).delay(200).fadeIn(200);
            }, function () {
                $(this).find('.dropdown-menu').stop(true, true).delay(200).fadeOut(200);
            });
        });
    </script>
    <!-- //smooth dropdown -->
    <!-- script for password match -->
    <script>
        window.onload = function () {
            document.getElementById(""password1"").onchange = validatePassword;
            document.getElementById(""password2"").onchange = validatePassword;
        }

        function validatePassword() {
            var pass2 = document.getElementById(""password2"").value;
            var pass1 = document.getElementById(""password1"").value;
            if (pass1 != pass2)
                document.getElementById(""password2"").setCustomValidity(""Passwords Don't Match"");
            else
                document.getElementById(""password2"").setCustomValidity('');
            //empty string means no validation error
        }
    </");
                WriteLiteral(@"script>
    <!-- script for password match -->
    <!-- cart-js -->
    <script src=""js/minicart.js""></script>
    <script>
        hub.render();

        hub.cart.on('new_checkout', function (evt) {
            var items, len, i;

            if (this.subtotal() > 0) {
                items = this.items();

                for (i = 0, len = items.length; i < len; i++) { }
            }
        });
    </script>
    <!-- //cart-js -->
    <!-- start-smooth-scrolling -->
    <script src=""js/move-top.js""></script>
    <script src=""js/easing.js""></script>
    <script>
        jQuery(document).ready(function ($) {
            $("".scroll"").click(function (event) {
                event.preventDefault();

                $('html,body').animate({
                    scrollTop: $(this.hash).offset().top
                }, 1000);
            });
        });
    </script>
    <!-- //end-smooth-scrolling -->
    <!-- smooth-scrolling-of-move-up -->
    <script>
        $(document).read");
                WriteLiteral(@"y(function () {
            /*
            var defaults = {
                containerID: 'toTop', // fading element id
                containerHoverID: 'toTopHover', // fading element hover id
                scrollSpeed: 1200,
                easingType: 'linear'
            };
            */

            $().UItoTop({
                easingType: 'easeOutQuart'
            });

        });
    </script>
    <script src=""js/SmoothScroll.min.js""></script>
    <!-- //smooth-scrolling-of-move-up -->
    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src=""js/bootstrap.js""></script>
    ");
                EndContext();
                BeginContext(7551, 41, false);
#line 196 "C:\Users\Deniz\Desktop\322sonödev\denizdikbiyik_CET322_HW2\denizdikbiyik_CET322_HW2\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(7592, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7601, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
