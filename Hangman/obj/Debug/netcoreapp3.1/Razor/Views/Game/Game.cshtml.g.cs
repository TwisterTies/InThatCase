#pragma checksum "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ded3cc9c60ec53e5da7178458ddebcc3aba4f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Game), @"mvc.1.0.view", @"/Views/Game/Game.cshtml")]
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
#line 1 "/Users/bryan/Projects/Hangman solution/Hangman/Views/_ViewImports.cshtml"
using Hangman.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bryan/Projects/Hangman solution/Hangman/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ModelBinding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bryan/Projects/Hangman solution/Hangman/Views/_ViewImports.cshtml"
using Hangman.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7ded3cc9c60ec53e5da7178458ddebcc3aba4f7", @"/Views/Game/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deb18f5d7905d503f6695c0081823b327ca01bcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div id=\"game-container\">\n    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 98, "\"", 115, 1);
#nullable restore
#line 5 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
WriteAttributeValue("", 106, Model.Id, 106, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"hidden-game-id\">\n");
#nullable restore
#line 7 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
      
        var stateClasses = "";
        for (int i = 1; i <= Model.NrOfIncorrectGuesses; i++)
        {
            stateClasses += $" hang{i}";
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"wrapper hangmanGame\">\n        <div id=\"hangMan\">\n            <div class=\"indicator\">\n                <span class=\"maxTry\">");
#nullable restore
#line 17 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                                Write(Model.NrOfIncorrectGuesses);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>/<span class=\"remaining\">");
#nullable restore
#line 17 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                                                                                           Write(GameConfig.MaxNrOfGuesses);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            </div>\n            <div");
            BeginWriteAttribute("class", " class=\"", 661, "\"", 690, 2);
            WriteAttributeValue("", 669, "hangman", 669, 7, true);
#nullable restore
#line 19 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
WriteAttributeValue(" ", 676, stateClasses, 677, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""shaft""></div>
                <div class=""pole""></div>
                <div class=""rope""></div>
                <div class=""base""></div>
                <div class=""man"">
                    <div class=""wrapperMan"">
                        <div class=""face""></div>
                        <div class=""hands""></div>
                        <div class=""legs""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div>
");
            WriteLiteral("        <p id=\"word-to-guess\">\n");
#nullable restore
#line 39 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
             if (!Model.WordGuessed && Model.NrOfIncorrectGuesses == GameConfig.MaxNrOfGuesses)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                 Write(Model.WordToGuess.Word);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                                                    
            }
            else
            {
                foreach (var letter in Model.WordToGuess.Word)
                {
                    if (letter.ToString() == " ")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>&nbsp;</span>\n");
#nullable restore
#line 50 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                    }
                    else if (!Model.GuessedLetters.Select(x => x.Letter).Contains(letter.ToString().ToUpper()))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>_</span>\n");
#nullable restore
#line 54 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>");
#nullable restore
#line 57 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                         Write(letter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 58 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                    }
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\n\n");
#nullable restore
#line 64 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
          
            var letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K",
                                 "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
                                 "W", "X", "Y", "Z"};
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 70 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
         if (!Model.WordGuessed && Model.NrOfIncorrectGuesses != GameConfig.MaxNrOfGuesses)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul id=\"letters\">\n");
#nullable restore
#line 73 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                 foreach (var letter in letters)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 2629, "\"", 2716, 1);
#nullable restore
#line 75 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
WriteAttributeValue("", 2637, Model.GuessedLetters.Select(x => x.Letter).Contains(letter) ? "guessed" : "", 2637, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <button");
            BeginWriteAttribute("id", " id =\"", 2750, "\"", 2763, 1);
#nullable restore
#line 76 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
WriteAttributeValue("", 2756, letter, 2756, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onClick", " onClick=\"", 2764, "\"", 2796, 3);
            WriteAttributeValue("", 2774, "guessLetter(\'", 2774, 13, true);
#nullable restore
#line 76 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
WriteAttributeValue("", 2787, letter, 2787, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2794, "\')", 2794, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                                                                          Write(letter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                        <!-- <a href=\"/game/");
#nullable restore
#line 77 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                                       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("/guess?letter=");
#nullable restore
#line 77 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                                                              Write(letter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 77 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                                                                       Write(letter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> -->\n                    </li>\n");
#nullable restore
#line 79 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n");
#nullable restore
#line 81 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
        }

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
         if (!Model.WordGuessed && !ViewContext.ModelState.IsValid)
        {
            var errorEntries = ViewContext.ModelState.Values.Where(x => x.ValidationState == ModelValidationState.Invalid);

            foreach (var entry in errorEntries)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>");
#nullable restore
#line 90 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
              Write(entry.Errors[0].ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 91 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 94 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
         if (Model.WordGuessed)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"box good\">\n                <div class=\"content\">\n                    <p id=\"word-guessed\">Je hebt het woord geraden! Goed bezig!</p>\n                </div>\n            </div>\n");
#nullable restore
#line 101 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 103 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
         if (!Model.WordGuessed && Model.NrOfIncorrectGuesses == GameConfig.MaxNrOfGuesses)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"box bad\">\n                <div class=\"content\">\n                    <p id=\"word-not-guessed\">Helaas, volgende keer beter...</p>\n                </div>\n            </div>\n");
#nullable restore
#line 110 "/Users/bryan/Projects/Hangman solution/Hangman/Views/Game/Game.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public GameConfig GameConfig { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
