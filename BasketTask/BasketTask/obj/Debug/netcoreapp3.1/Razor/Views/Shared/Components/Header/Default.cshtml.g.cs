#pragma checksum "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12caaf711e1267e2d39407f4d416ffdee7fee7e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\_ViewImports.cshtml"
using BasketTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\_ViewImports.cshtml"
using BasketTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\Shared\Components\Header\Default.cshtml"
using BasketTask.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12caaf711e1267e2d39407f4d416ffdee7fee7e0", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b783f1837a672d3dd40dd089336ba1aead2db0d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LayoutVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<header>
    <div class=""row"">
        <div class=""col-xl-12 d-sm-none d-xl-block"">
            <div class=""warning-alert"">
                <P>Due to the <strong>COVID 19</strong> epidemic, orders may be processed with a slight delay</P>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""main-menu d-flex"">
            <div class=""links-about"">
                <a href=""./about.html"">About Us</a>
                <a href=""#"">My account</a>
                <a href=""#"">Wishlist</a>
                <a href=""#"">Order Tracking</a>
            </div>
            <div class=""menus-about d-flex justify-content-between"">
                <span>
                    <img src=""https://img.icons8.com/ios/50/000000/hand.png"" /> 100% Secure delivery without
                    contacting the courier
                </span>
                <div class=""vl""></div>
                <span class=""help"">Need help? Call us: <strong><a");
            BeginWriteAttribute("href", " href=\"", 1033, "\"", 1040, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\Shared\Components\Header\Default.cshtml"
                                                                     Write(Model.Settings["Phone"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></strong></span>
                <div class=""vl""></div>
                <div class=""menus-dropdowns"">
                    <div class=""dropdown"">
                        <button class=""dropbtn"">
                            English <img src=""https://img.icons8.com/material-outlined/24/000000/expand-arrow--v1.png"" />
                        </button>
                        <div class=""dropdown-content"">
                            <a href=""#"">English</a>
                            <a href=""#"">Spanish</a>
                            <a href=""#"">German</a>
                        </div>
                    </div>
                    <div class=""dropdown"">
                        <button class=""dropbtn"">
                            USD <img src=""https://img.icons8.com/material-outlined/24/000000/expand-arrow--v1.png"" />
                        </button>
                        <div class=""dropdown-content"">
                            <a href=""#"">USD</a>
                            <a href=");
            WriteLiteral(@"""#"">INR</a>
                            <a href=""#"">GBP</a>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <hr>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-2 col-6"">
                <div class=""logo-wrapper"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 2460, "\"", 2467, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2499, "\"", 2534, 1);
#nullable restore
#line 60 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 2505, Model.Settings["HeaderLogo"], 2505, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 2535, "\"", 2571, 0);
            EndWriteAttribute();
            WriteLiteral(@"><br><span>Online Grocery Shopping Center</span>
                    </a>
                </div>
            </div>
            <div class=""col-xl-2 col-6"">
                <div class=""location-wrapper"">
                    <!-- Button trigger modal -->
                    <button type=""button"" class=""btn-modal btn-primary"" data-bs-toggle=""modal""
                            data-bs-target=""#staticBackdrop"">
                        <span>Your Location</span> <i class=""fa-solid fa-angle-down""></i><br>
                        <strong>Select a location</strong>
                    </button>

                    <!-- Modal -->
                    <div class=""modal fade"" id=""staticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false""
                         tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog modal-dialog-scrollable"">
                            <div class=""modal-content"">
                                <");
            WriteLiteral(@"div class=""modal-header"">

                                    <p id=""staticBackdropLabel"" class=""modal-title"">
                                        <strong>
                                            Choose your Delivery
                                            Location
                                        </strong>
                                        <br>
                                        Enter your address and we will specify the offer for your area.
                                    </p>
                                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""
                                            aria-label=""Close""></button>
                                </div>
                                <div class=""modal-body"">
                                    <div class=""modals-search"">
                                        <i class=""fa-solid fa-magnifying-glass""></i><input class=""search ps-1""
                                             ");
            WriteLiteral(@"                                              style=""width: 95%; margin-bottom: 10px; border: none;""
                                                                                           placeholder=""Search your area"" type=""search"">
                                    </div>
                                    <ul>
                                        <li class=""list-group-item"">Select a Location <span>Clear All</span> </li>
                                        <li class=""list-group-item"">Alabama <span>Min:130$</span> </li>
                                        <li class=""list-group-item"">Albania <span>Min:120$</span></li>
                                        <li class=""list-group-item"">New Zelland <span>Min:90$</span> </li>
                                        <li class=""list-group-item"">Azerbaijan <span>Min:150$</span> </li>
                                        <li class=""list-group-item"">Alabama <span>Min:130$</span> </li>
                                        <li class=""l");
            WriteLiteral(@"ist-group-item"">Albania <span>Min:120$</span></li>
                                        <li class=""list-group-item"">New Zelland <span>Min:90$</span> </li>
                                        <li class=""list-group-item"">Azerbaijan <span>Min:150$</span> </li>
                                        <li class=""list-group-item"">Alabama <span>Min:130$</span> </li>
                                        <li class=""list-group-item"">Albania <span>Min:120$</span></li>
                                        <li class=""list-group-item"">New Zelland <span>Min:90$</span> </li>
                                        <li class=""list-group-item"">Azerbaijan <span>Min:150$</span> </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-6 col-8"">
                <div class=""search-wrapper d-flex justify-content-");
            WriteLiteral(@"between"">
                    <input class=""search"" type=""search"" placeholder=""Search for products..."">
                    <i class=""fa-solid fa-magnifying-glass""></i>
                </div>

            </div>
            <div class=""col-xl-2 col-4"">
                <div class=""profile-busket d-flex"">
                    <div class=""profile""><a href=""./login-register.html""><i class=""fa-solid fa-user""></i></a></div>
                    <div class=""busket-wrapper d-flex"">
                        <span>$0.00</span>
                        <a href=""./cart.html"" style=""text-decoration: none;"">
                            <div class=""busket-dropdown"">
                                <div class=""busket-btn"">
                                    <i class=""fa-solid fa-basket-shopping""></i>
                                </div><sub>
                                    <div class=""sub""><b>0</b></div>
                                </sub>
                                <div class=""busket-content"">
");
            WriteLiteral(@"                                    <img src=""https://img.icons8.com/bubbles/50/000000/shopping-bag.png"" />
                                    <p class=""first"">No products in the cart.</p>
                                    <hr>
                                    <p>We reduce shipping prices to only 2.49€!</p>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-xl-3 col-5"">
                <div class=""all-categories"">
                    <div class=""all-categories-btn-content"">
                        <div class=""all-categories-btn"">
                            <p>☰ ALL CATEGORIES <i class=""fa-solid fa-angle-down""></i></p>
                        </div>
                        <div class=""products-count"">
                            <p>TOTAL 63 PRODUCTS</p>
                        </div>
          ");
            WriteLiteral(@"          </div>
                    <div class=""all-categories-content"">
                        <div class=""fruits-vegetables"">
                            <div class=""fruits-vegetables-btn"">
                                <p>
                                    <i class=""fa-solid fa-apple-whole""></i> Fruits & Vegetables <i class=""fa-solid fa-angle-right""></i>
                                </p>
                            </div>
                            <div class=""fruits-vegetables-content"">
");
#nullable restore
#line 170 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\Shared\Components\Header\Default.cshtml"
                                 foreach (var item in Model.CategoryProducts)
                                {
                                    if (item.CategoriesId == 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>");
#nullable restore
#line 174 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\Shared\Components\Header\Default.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 175 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\Shared\Components\Header\Default.cshtml"
                                    }

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>
                        </div>
                        <div class=""meats-seafood"">
                            <div class=""meats-seafood-btn"">
                                <p><i class=""fa-solid fa-drumstick-bite""></i> Meats & Seafood</p>
                            </div>
                        </div>
                        <div class=""breakfast-dairy"">
                            <div class=""breakfast-dairy-btn"">
                                <p><i class=""fa-solid fa-egg""></i> Breakfast & Dairy</p>
                            </div>
                        </div>
                        <div class=""beverages"">
                            <div class=""beverages-btn"">
                                <p>
                                    <i class=""fa-solid fa-mug-hot""></i> Beverages <i class=""fa-solid fa-angle-right""></i>
                                </p>
                            </div>
                            <div class=""beverages-conte");
            WriteLiteral("nt\">\r\n");
#nullable restore
#line 199 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\Shared\Components\Header\Default.cshtml"
                                 foreach (var item in Model.CategoryProducts)
                                {
                                    if (item.CategoriesId == 4)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>");
#nullable restore
#line 203 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\Shared\Components\Header\Default.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 204 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Services\BasketTask\BasketTask\Views\Shared\Components\Header\Default.cshtml"
                                    }

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""breads-bakery"">
                            <div class=""breads-bakery-btn"">
                                <p><i class=""fa-solid fa-bread-slice""></i> Breads & Bakery</p>
                            </div>
                        </div>
                        <div class=""frozen-foods"">
                            <div class=""frozen-foods-btn"">
                                <p><i class=""fa-solid fa-snowflake""></i> Frozen Foods</p>
                            </div>
                        </div>
                        <div class=""biscuits-snacks"">
                            <div class=""biscuits-snacks-btn"">
                                <p><i class=""fa-solid fa-cookie""></i> Biscuits & Snacks</p>
                            </div>
                        </div>
                        <div class=""grocery-staples"">
                            <div class=""grocery-staples-btn"">
          ");
            WriteLiteral(@"                      <p><i class=""fa-solid fa-leaf""></i> Grocery & Staples</p>
                            </div>
                        </div>
                        <hr>
                        <div class=""value-day-btn"">
                            <p>Value of the Day</p>
                        </div>
                        <div class=""top-offers"">
                            <p>Top 100 Offers</p>
                        </div>
                        <div class=""arrivals"">
                            <p>New Arrivals</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-1 col-2"">
                <div class=""home-page-wrapper"">
                    <div class=""home-page"">
                        <a href=""./home.html"">HOME <i class=""fa-solid fa-angle-down""></i></a>
                    </div>
                    <div class=""home-page-content"">
                        <a href=""./home.html"">Home 1</a><br>");
            WriteLiteral("\n                        <a");
            BeginWriteAttribute("href", " href=\"", 13042, "\"", 13049, 0);
            EndWriteAttribute();
            WriteLiteral(">Home 2</a><br>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 13093, "\"", 13100, 0);
            EndWriteAttribute();
            WriteLiteral(">Home 3</a><br>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 13144, "\"", 13151, 0);
            EndWriteAttribute();
            WriteLiteral(">Home 4</a><br>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 13195, "\"", 13202, 0);
            EndWriteAttribute();
            WriteLiteral(@">Home 5</a>
                    </div>
                </div>
            </div>
            <div class=""col-xl-1 col-2"">
                <div class=""shop-page-wrapper"">
                    <div class=""shop-page"">
                        <a href=""./shop.html"">SHOP <i class=""fa-solid fa-angle-down""></i></a>
                    </div>
                    <div class=""shop-page-content"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-2"">
                                    <div class=""shop-lists"">
                                        <a class=""first""");
            BeginWriteAttribute("href", " href=\"", 13867, "\"", 13874, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Lists</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 13938, "\"", 13945, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Default</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 14011, "\"", 14018, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Right Sidebar</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 14090, "\"", 14097, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Wide</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 14160, "\"", 14167, 0);
            EndWriteAttribute();
            WriteLiteral(">List Left Sidebar</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 14238, "\"", 14245, 0);
            EndWriteAttribute();
            WriteLiteral(">Load More Button</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 14315, "\"", 14322, 0);
            EndWriteAttribute();
            WriteLiteral(@">Infinite Scrolling</a>
                                    </div>
                                </div>
                                <div class=""col-2 ms-5"">
                                    <div class=""product-detail"">
                                        <a class=""first""");
            BeginWriteAttribute("href", " href=\"", 14612, "\"", 14619, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Detail</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 14687, "\"", 14694, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Default</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 14763, "\"", 14770, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Variable</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 14840, "\"", 14847, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Grouped</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 14916, "\"", 14923, 0);
            EndWriteAttribute();
            WriteLiteral(">Product External</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 14993, "\"", 15000, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Downloadable</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 15074, "\"", 15081, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product With Video</a>
                                    </div>
                                </div>
                                <div class=""col-2 ms-5"">
                                    <div class=""product-types"">
                                        <a class=""first""");
            BeginWriteAttribute("href", " href=\"", 15370, "\"", 15377, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 15444, "\"", 15451, 0);
            EndWriteAttribute();
            WriteLiteral(">Single Type 1</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 15518, "\"", 15525, 0);
            EndWriteAttribute();
            WriteLiteral(">Single Type 2</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 15592, "\"", 15599, 0);
            EndWriteAttribute();
            WriteLiteral(">Single Type 3</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 15666, "\"", 15673, 0);
            EndWriteAttribute();
            WriteLiteral(">Single Type 4</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 15740, "\"", 15747, 0);
            EndWriteAttribute();
            WriteLiteral(">Thumbnails Left</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 15816, "\"", 15823, 0);
            EndWriteAttribute();
            WriteLiteral(@">Zoom Image</a>
                                    </div>
                                </div>
                                <div class=""col-2 ms-5"">
                                    <div class=""shop-pages"">
                                        <a class=""first""");
            BeginWriteAttribute("href", " href=\"", 16101, "\"", 16108, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Pages</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 16172, "\"", 16179, 0);
            EndWriteAttribute();
            WriteLiteral(">Cart</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 16237, "\"", 16244, 0);
            EndWriteAttribute();
            WriteLiteral(">Checkout</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 16306, "\"", 16313, 0);
            EndWriteAttribute();
            WriteLiteral(">My account</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 16377, "\"", 16384, 0);
            EndWriteAttribute();
            WriteLiteral(">Wishlist</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 16446, "\"", 16453, 0);
            EndWriteAttribute();
            WriteLiteral(">Order Tracking</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 16521, "\"", 16528, 0);
            EndWriteAttribute();
            WriteLiteral(@">Order on WhatsApp</a>
                                    </div>
                                </div>
                                <div class=""col-2 ms-5"">
                                    <div class=""shop-layouts"">
                                        <a class=""first""");
            BeginWriteAttribute("href", " href=\"", 16815, "\"", 16822, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Layouts</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 16888, "\"", 16895, 0);
            EndWriteAttribute();
            WriteLiteral(">Two Columns</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 16960, "\"", 16967, 0);
            EndWriteAttribute();
            WriteLiteral(">Three Columns</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 17034, "\"", 17041, 0);
            EndWriteAttribute();
            WriteLiteral(">Three Columns Wide</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 17113, "\"", 17120, 0);
            EndWriteAttribute();
            WriteLiteral(">Four Columns</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 17186, "\"", 17193, 0);
            EndWriteAttribute();
            WriteLiteral(">Four Columns Wide</a><br>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 17264, "\"", 17271, 0);
            EndWriteAttribute();
            WriteLiteral(@">Five Columns Wide</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-2 col-3"">
                <div class=""meats-seafood-pages"">
                    <a href=""./product-detail.html""><i class=""fa-solid fa-drumstick-bite""></i> MEATS & SEAFOOD</a>
                </div>
            </div>
            <div class=""col-xl-1 col-2"">
                <div class=""bakery-page"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 17880, "\"", 17887, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-bread-slice\"></i> BAKERY</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-xl-2 col-3\">\r\n                <div class=\"beverages-page\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 18095, "\"", 18102, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa-solid fa-mug-hot""></i> BEVERAGES</a>
                </div>
            </div>
            <div class=""col-xl-1 col-2"">
                <div class=""blog-page"">
                    <a href=""./blog.html"">BLOG</a>
                </div>
            </div>
            <div class=""col-xl-1 col-2"">
                <div class=""contact-page"">
                    <a href=""./contact.html"">CONTACT</a>
                </div>
            </div>
        </div>
    </div>


</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LayoutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
