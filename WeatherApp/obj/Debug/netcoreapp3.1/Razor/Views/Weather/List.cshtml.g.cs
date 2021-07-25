#pragma checksum "C:\Weather\WeatherApp\WeatherApp\Views\Weather\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4325d9a844a571447b91cb4f25cad9e80a704544"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Weather_List), @"mvc.1.0.view", @"/Views/Weather/List.cshtml")]
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
#line 1 "C:\Weather\WeatherApp\WeatherApp\Views\_ViewImports.cshtml"
using WeatherApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Weather\WeatherApp\WeatherApp\Views\_ViewImports.cshtml"
using WeatherApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4325d9a844a571447b91cb4f25cad9e80a704544", @"/Views/Weather/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5982ed880600284e9d1c6d2e6f98bfd2936ac1ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Weather_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CityViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Weather\WeatherApp\WeatherApp\Views\Weather\List.cshtml"
   ViewData["Title"] = "City List"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>City List</h3>\n\n");
#nullable restore
#line 7 "C:\Weather\WeatherApp\WeatherApp\Views\Weather\List.cshtml"
Write(Html.DisplayNameFor(model => model.CityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<select id=\"ddlCities\" name=\"ddlCities\" onchange=\"getWeather()\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4325d9a844a571447b91cb4f25cad9e80a7045443852", async() => {
                WriteLiteral("Please select");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 11 "C:\Weather\WeatherApp\WeatherApp\Views\Weather\List.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4325d9a844a571447b91cb4f25cad9e80a7045445195", async() => {
#nullable restore
#line 13 "C:\Weather\WeatherApp\WeatherApp\Views\Weather\List.cshtml"
                          Write(item.CityName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Weather\WeatherApp\WeatherApp\Views\Weather\List.cshtml"
   WriteLiteral(item.CityName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 13 "C:\Weather\WeatherApp\WeatherApp\Views\Weather\List.cshtml"
                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</select>

<div>
    <br /><br /><br />
                <table>

                    <tr>
                        <td>
                            <h3>Weather Forecast</h3>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>City/Location : </strong>
                            <span id=""lblCity""></span>&nbsp;&nbsp;
");
            WriteLiteral(@"                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Time : </strong>
                            <span id=""lblTime""></span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Wind Speed : </strong>
                            <span id=""lblWind""></span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Visibility : </strong>
                            <label id=""lblVisibility""></label>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Sky : </strong>
                            <label id=""lblSky""></label>

                        </td>
                    </tr>
                    <tr>
                        <td>
                    ");
            WriteLiteral(@"        <strong>Temp (C) : </strong>
                            <label id=""lblTempCelcius""></label>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Temp (F) : </strong>
                            <label id=""lblTempFahrenheit""></label>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Dew Point (C) : </strong>
                            <label id=""lblDewPoint""></label>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Relative Humidity : </strong>
                            <label id=""lblHumidity""></label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>Pressure : </strong>
                            <label id=""lblPressur");
            WriteLiteral(@"e""></label>
                        </td>
                    </tr>

                </table>
</div>

<script>


    function getWeather() {

        var cityname = document.getElementById(""ddlCities"").value;
        if (cityname.length > 0) {
            $.ajax({
                url: ""GetWeather?cityName="" + cityname,
                type: ""POST"",
                success: function (result) {
                    var data = JSON.parse(result);
                    console.log(data);
                    $(""#lblCity"").html(data.City);
                    $(""#lblCountry"").text(data.Country);
                    $(""#lblTime"").text(data.WeatherDateTime);
                    $(""#lblWind"").text(data.Wind);
                    $(""#lblVisibility"").text(data.Visibility);
                    $(""#lblSky"").text(data.Sky);
                    $(""#lblTempCelcius"").text(data.TempInCelcius);
                    $(""#lblTempFahrenheit"").text(data.TempInFahrenheit);
                    $(""#lblDewPoint"").text(data.DewPoint);
      ");
            WriteLiteral(@"              $(""#lblHumidity"").text(data.Humidity);
                    $(""#lblPressure"").text(data.Pressure);
                },
                error: function () {

                }
            });
        }
        else {
            alert(""City Not Found"");
        }
    };

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CityViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
