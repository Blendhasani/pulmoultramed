#pragma checksum "C:\Users\Blend\source\repos\pulmoultramed\pulmoultramed\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0433ba8d51306690bb83ab69bf45a437eb4797c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Blend\source\repos\pulmoultramed\pulmoultramed\Views\_ViewImports.cshtml"
using pulmoultramed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Blend\source\repos\pulmoultramed\pulmoultramed\Views\_ViewImports.cshtml"
using pulmoultramed.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0433ba8d51306690bb83ab69bf45a437eb4797c7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09448db5739a0370d366415a1e7e00fcf040837", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Blend\source\repos\pulmoultramed\pulmoultramed\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""bg-image"" 
     style=""background-image: url('../images/fotojaEgjere.jpg');
            height: 60vh;"">
       <div class=""col-md-7 col-sm-8 col-12 text-center float-right "" style=""display:flex;  margin-top:12%; margin-right:2%;"" >
 <p style=""color:white; font-size:clamp(30px,3vw,50px); font-family:'Times New Roman', Times, serif"">Ambulanca Specialistike e Mushkërive Pulmo-Ultramed <br/> Dr. Fahri Hasani </p>
 
     </div>
</div>
    


 
        
   




 <div class=""col-md-5 "" style=""display: block;
  margin-left: auto;
  margin-right: auto;
margin-top:10%;

"">
                        <img name=""slide"" width=""100%"" style="" border-radius: 25px; box-shadow: 15px 15px 5px #ccc;"" >
 </div>


 <div  style=""margin-top:100px;width:80%;margin-right:10%;margin-left:10%;  display:flex; flex-direction:row; flex-wrap:wrap;justify-content:space-around;"">
     <div style=""display:flex;"">
         <p style="" color:#4c1a54;  font-size:clamp(30px,3vw,50px); font-family:Arial ""><");
            WriteLiteral(@"b>+383 49 416 531</b></p>
     </div>
     <div style=""display:flex;flex-direction:row;justify-content:space-evenly; align-items:center;margin-bottom:30px; width:160px;padding-left:15px; "">
         <a href=""https://www.facebook.com/people/Ambulanca-e-Mushk%C3%ABrive-Pulmo-Ultramed-DrFahri-Hasani/100086228600067/""><img style=""width:50px;height:50px;""src=""https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Facebook_Logo_%282019%29.png/768px-Facebook_Logo_%282019%29.png"" /></a>
              <a href=""https://mail.yahoo.com/d/compose/7060659850""><img src=""https://www.freepnglogos.com/uploads/yahoo-logo-png/yahoo-logo-png-y-logo-yahoo-social-media-icons-2.png"" style=""width:50px;height:50px;""/></a>
     </div>
 </div>
 


  
  



");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    var i = 0;
var images = [];
var time = 3000;

images [0] = '../images/ordinanca.jpg';
images [1] = '../images/lokacioni.png';


function changeImage(){
    document.slide.src = images[i];
    if(i<images.length-1){
        i++;
    }else{
        i=0;
    }
    setTimeout(""changeImage()"",time);
}

window.onload = changeImage;
    </script>
    
    
    ");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591