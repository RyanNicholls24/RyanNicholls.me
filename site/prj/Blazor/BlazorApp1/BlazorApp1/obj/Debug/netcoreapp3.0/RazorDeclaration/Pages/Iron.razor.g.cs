#pragma checksum "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6572d38468c55e522ac7d915a40d73f40dd7ddd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/iron")]
    public class Iron : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 129 "C:\Users\rnicholls\Desktop\Scripts For Jenkins\Git\RyanNicholls.me\site\prj\Blazor\BlazorApp1\BlazorApp1\Pages\Iron.razor"
       


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
                    for (int i = 0; i < 5; i++) {

                        System.Threading.Thread.Sleep(1000);
                        builder.Append(" . ");

                        newDialog = builder.ToString();
                        setInnerHTML("currentDialog", newDialog);

                    }
                    createElementNew("p", "currentDialog", "test", "content");
                    /** newDialog = "The bay south of StormHaven has historically experienced record breaking winds causing extreme weather conditions. " +
                             "Some have attributed these conditions to more than just natural causes, " +
                             "but nobody has been brave enough to fully explore the bay during a storm. " +
                             "Because of these conditions sailors and other travelers would regularly moor in the northernmost section of the bay. " +
                             "Over time many of them decided it was a truly unique area and stayed there. " +
                             "<br />The most notable of these was a young Lord Vysir, who is now the overseer of the territory. " +
                             "Although a relatively new territory, Lord Vysir had grand visions for StormHaven from the very beginning. " +
                             "His recruitment of skilled individuals such as Alacor and Eskell was key in this. Placing Alacor, a master combatant, " +
                             "and Eskell, a now famous alchemist, in the chain of command allowed the StormHaven government to have such polarizing " +
                             "opinions on topics that the people felt their rule has always been fair. Eventually many merchants set up shop there as well, " +
                             "and formed a union knows as the Artisans. This idea spread to many other territories as well, and has become a key cog in continental trade. " +
                             "This union is optional and has its drawbacks, so some traders decide to go it on their own. " +
                             "StormHaven is graced with two of these individuals, Godric and Harold. Each experts in crafting combat gear, " +
                             "Godric focuses on melee equipment while Harold chooses to work with archery. " +
                             "<br />    Lord Vysir saw some flaws with his land, however. He realized that without education and a strong military StormHaven would succumb " +
                             "to the pitfalls that most coastal towns in Iron do. Many of the men who stop here are pirates or drunks, and to keep his citizens " +
                             "safe he designated Alacor head of military and Eskell the spokesperson for all merchants. He also had The Academy built on a small" +
                             " rocky hill next to the castle, which now houses some of the brightest minds in magic. The hill was unknowingly built on an old ritual site, " +
                             "with ample residual energy. It is not uncommon to see mages harnessing the energy of the crystals around the academy, " +
                             "which act as a sort of mana conduit. The Academy is led by Arlo. " +
                             "Not much is known about Arlo's history, but he is trusted and respected by Lord Vysir." +
                             "<br />Thanks to a combination of it's location and" +
                             " leadership, StormHaven has many prosperous years ahead of it.";
                     setInnerHTML("currentDialog", newDialog);
                     **/
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
