#pragma checksum "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8481289d32245d835bd2165ed391e6bc400c8b2d"
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
#line 1 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/iron")]
    public class Iron : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .UI {\r\n        background-color: sandybrown;\r\n        height: 800px;\r\n        width: 800px;\r\n        position: relative;\r\n    }\r\n\r\n    .Buttons {\r\n        visibility: hidden;\r\n        background-color: rosybrown;\r\n        position: relative;\r\n        height: 25px;\r\n        width: 100%;\r\n    }\r\n\r\n    #Continue {\r\n        visibility: visible;\r\n        bottom: 0px;\r\n        display: inline;\r\n        text-align: center;\r\n        height: auto;\r\n        width: auto;\r\n        position: absolute;\r\n    }\r\n\r\n    #modButton1 {\r\n    }\r\n\r\n    #modButton2 {\r\n    }\r\n\r\n    #modButton3 {\r\n    }\r\n\r\n    #modButton4 {\r\n    }\r\n\r\n    #map {\r\n        background-size: cover;\r\n        background-color: darkslategray;\r\n        height: 25%;\r\n        width: 25%;\r\n        position: absolute;\r\n        left: 0px;\r\n        bottom: 0px;\r\n        overflow: hidden;\r\n    }\r\n\r\n        #map img {\r\n            transition: transform .5s ease;\r\n        }\r\n\r\n        #map:hover img {\r\n            transform: scale(1.5);\r\n        }\r\n\r\n\r\n    #settings {\r\n        background-color: slategray;\r\n        height: 25%;\r\n        width: 25%;\r\n        position: absolute;\r\n        bottom: 0px;\r\n        right: 0px;\r\n    }\r\n\r\n    #Dialog {\r\n        position: absolute;\r\n        left: 25%;\r\n        right: 50%;\r\n        background-color: slategray;\r\n        height: 25%;\r\n        width: 50%;\r\n        bottom: 0px;\r\n        border: 1px solid black;\r\n    }\r\n\r\n    #currentDialog {\r\n        font-family: \'runescape_chat_bold_07regular\';\r\n        font-size: 1.2em;\r\n        color: #FFFF00;\r\n        display: inline-block;\r\n        overflow: hidden;\r\n        letter-spacing: 2px;\r\n        font-size: 14px;\r\n        box-sizing: border-box;\r\n        transition: width 2s;\r\n        height: 100%;\r\n        width: 100%;\r\n        overflow-y: auto;\r\n    }\r\n\r\n    #Choices {\r\n        position: absolute;\r\n        left: 25%;\r\n        right: 50%;\r\n        background-color: darkslategrey;\r\n        height: 20%;\r\n        width: 50%;\r\n        bottom: 25%;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Iron</h1>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "UI");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<div id=\"map\">\r\n        <img src=\"../../img/Continent.png\">\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "id", "Choices");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "Buttons");
            __builder.AddAttribute(11, "id", "Continue");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                        Continue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Continue...");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "Buttons");
            __builder.AddAttribute(17, "id", "modButton1");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 116 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                          setButton1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, 
#nullable restore
#line 116 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                                       modButton1Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "Buttons");
            __builder.AddAttribute(23, "id", "modButton2");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 117 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                          setButton2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, 
#nullable restore
#line 117 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                                       modButton2Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "Buttons");
            __builder.AddAttribute(29, "id", "modButton3");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 118 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                          setButton3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, 
#nullable restore
#line 118 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                                       modButton3Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "Buttons");
            __builder.AddAttribute(35, "id", "modButton4");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 119 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                          setButton4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, 
#nullable restore
#line 119 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                                                       modButton4Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "id", "Dialog");
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "id", "currentDialog");
            __builder.AddContent(45, 
#nullable restore
#line 123 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
                                 currentDialog

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.AddMarkupContent(48, "<div id=\"settings\">\r\n\r\n    </div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 130 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
       

    string currentDialog = "Welcome. Press 'Continue...' to advance Dialog";
    string nextDialog = "";
    string modButton1Text = "0";
    string modButton2Text = "0";
    string modButton3Text = "0";
    string modButton4Text = "0";

    private void setInnerHTML(string id, string content)
    {
        JSRuntime.InvokeVoidAsync("setInnerHTML", id, content);
    }

    private void setElementVis(string id, string vis)
    {
        JSRuntime.InvokeVoidAsync("setElementVis", id, vis);
    }

    private void createElementNew(string type, string parentid, string childid, string content)
    {

    }

    void Continue()
    {
        nextDialog = getNewDialog(1);
        currentDialog = nextDialog;


    }


    static private string getConnectionString()
    {
        return "Server=(localdb)\\mssqllocaldb;Database=aspnet-BlazorApp1-048656A3-24D4-4ABA-8D48-4D9CB15501DB;Trusted_Connection=True;MultipleActiveResultSets = true;";
    }


    string getNewDialog(int index)
    {

        //get new dialog from DB. Based on NPC, quest active/inactive, etc.


        string newDialog = "";
        switch (index)
        {
            case 1: //case 1 is considered introductory and is hard coded for testing
                newDialog = "Welcome to the world of Iron. You will begin your journey in the city fo StormHaven. " +
                        "Would you like to read some lore about StormHaven before beginning?";
                setElementVis("modButton1", "visible");
                setElementVis("modButton2", "visible");
                setInnerHTML("modButton1", "Yes");
                setInnerHTML("modButton2", "No");
                if (modButton1Text == "1")
                {
                    newDialog = "StormHaven's History By Gregory";
                    clearButtons();


                    var builder = new System.Text.StringBuilder();
                    builder.Append(newDialog);
                    for (int i = 0; i < 5; i++)
                    {

                        System.Threading.Thread.Sleep(1000);
                        builder.Append(" . ");

                        newDialog = builder.ToString();
                        setInnerHTML("currentDialog", newDialog);

                    }

                }
                else if (modButton2Text == "1")
                {
                    newDialog = "You just missed out on hints for some treasure. Nice job.";
                    clearButtons();
                }
                break;
        }

        return newDialog;
    }

    void clearButtons()
    {
        modButton1Text = "0";
        modButton2Text = "0";
        modButton3Text = "0";
        modButton4Text = "0";
        setElementVis("modButton1", "hidden");
        setElementVis("modButton2", "hidden");
        setElementVis("modButton3", "hidden");
        setElementVis("modButton4", "hidden");
        setInnerHTML("modButton1", "");
        setInnerHTML("modButton2", "");
        setInnerHTML("modButton3", "");
        setInnerHTML("modButton4", "");
    }

    void setButton1()
    {
        modButton1Text = "1";
        modButton2Text = "0";
        modButton3Text = "0";
        modButton4Text = "0";
        Continue();
    }

    void setButton2()
    {
        modButton1Text = "0";
        modButton2Text = "1";
        modButton3Text = "0";
        modButton4Text = "0";
        Continue();
    }
    void setButton3()
    {

        modButton1Text = "0";
        modButton2Text = "0";
        modButton3Text = "1";
        modButton4Text = "0";
        Continue();
    }
    void setButton4()
    {

        modButton1Text = "0";
        modButton2Text = "0";
        modButton3Text = "0";
        modButton4Text = "1";
        Continue();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
