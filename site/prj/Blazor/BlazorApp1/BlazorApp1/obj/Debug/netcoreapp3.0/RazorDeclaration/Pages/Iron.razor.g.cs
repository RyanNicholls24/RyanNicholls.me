#pragma checksum "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e936cb82035b95c524ecdc5c06cb9610e492e22"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/iron")]
    public class Iron : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
       

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
