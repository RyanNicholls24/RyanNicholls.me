#pragma checksum "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c80d5f16723e693af3b6dc4fdb2b4356246d4f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/iron")]
    public class Iron : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .UI {\r\n        background-color: sandybrown;\r\n        height: 800px;\r\n        width: 800px;\r\n        position: relative;\r\n    }\r\n\r\n    .Buttons {\r\n        visibility: hidden;\r\n        background-color: rosybrown;\r\n        position: relative;\r\n        height: 25px;\r\n        width: 100%;\r\n    }\r\n\r\n    #Continue {\r\n        visibility: visible;\r\n        bottom: 0px;\r\n        display: inline;\r\n        text-align: center;\r\n        height: auto;\r\n        width: auto;\r\n        position: absolute;\r\n    }\r\n\r\n    #modButton1{\r\n\r\n    }\r\n    #modButton2{\r\n\r\n    }\r\n    #modButton3{\r\n\r\n    }\r\n    #modButton4{\r\n\r\n    }\r\n    #map {\r\n        background-image: url(\'../Continent.png\');\r\n        background-color: darkslategray;\r\n        height: 25%;\r\n        width: 25%;\r\n        position: absolute;\r\n        left: 0px;\r\n        bottom: 0px;\r\n    }\r\n\r\n    #settings {\r\n        background-color: slategray;\r\n        height: 25%;\r\n        width: 25%;\r\n        position: absolute;\r\n        bottom: 0px;\r\n        right: 0px;\r\n    }\r\n\r\n    #Dialog {\r\n        position: absolute;\r\n        left: 25%;\r\n        right: 50%;\r\n        background-color: slategray;\r\n        height: 25%;\r\n        width: 50%;\r\n        bottom: 0px;\r\n        border: 1px solid black;\r\n    }\r\n\r\n    #currentDialog {\r\n    font-family: \'runescape_chat_bold_07regular\';\r\n    font-size: 1.2em;\r\n    color:#FFFF00;\r\n    width: 1px;\r\n    display: inline-block;\r\n  \toverflow: hidden;\r\n  \tletter-spacing: 2px;\r\n    white-space: nowrap;\r\n    font-size: 14px;\r\n    box-sizing: border-box;\r\n    transition: width 2s;\r\n    }\r\n        #currentDialog:enabled {\r\n            width: 100%;\r\n        \r\n        }\r\n    #Choices {\r\n        position: absolute;\r\n        left: 25%;\r\n        right: 50%;\r\n        background-color: darkslategrey;\r\n        height: 20%;\r\n        width: 50%;\r\n        bottom: 25%;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Iron</h1>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "UI");
            __builder.AddAttribute(4, "onload", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.ProgressEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                         Intro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<div id=\"map\">\r\n\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "id", "Choices");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "Buttons");
            __builder.AddAttribute(12, "id", "Continue");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 106 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                        Continue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Continue...");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "Buttons");
            __builder.AddAttribute(18, "id", "modButton1");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                          setButton1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, 
#nullable restore
#line 107 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                                       modButton1Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "Buttons");
            __builder.AddAttribute(24, "id", "modButton2");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                          setButton2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, 
#nullable restore
#line 108 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                                       modButton2Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "Buttons");
            __builder.AddAttribute(30, "id", "modButton3");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                          setButton3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, 
#nullable restore
#line 109 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                                       modButton3Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "Buttons");
            __builder.AddAttribute(36, "id", "modButton4");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                          setButton4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, 
#nullable restore
#line 110 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                                       modButton4Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "id", "Dialog");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "id", "currentDialog");
            __builder.AddContent(46, 
#nullable restore
#line 114 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                 currentDialog

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.AddMarkupContent(49, "<div id=\"settings\">\r\n\r\n    </div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "C:\Users\rnicholls\source\repos\BlazorApp1\BlazorApp1\Pages\Iron.razor"
       
    string currentDialog = "Welcome. Press 'Continue...' to advance Dialog";
    string modButton1Text = "";
    string modButton2Text = "";
    string modButton3Text = "";
    string modButton4Text = "";

    void Intro() {
        currentDialog = "The Continent of Iron is a wonderful place.";
    }




    void Continue()
    {
        currentDialog = "";
        string nextDialog = "nextDialog Not Set";

        for (int i = 0; i < nextDialog.Length; i++) {

            currentDialog = currentDialog + nextDialog[i].ToString();
            //System.Threading.Thread.Sleep(50);
        }


    }

    void setButton1()
    {

    }

    void setButton2()
    {

    }
    void setButton3()
    {

    }
    void setButton4()
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
