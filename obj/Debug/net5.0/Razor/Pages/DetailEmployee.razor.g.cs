#pragma checksum "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52de5e1420521525304645ce4be41bae09f43104"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFrontendUTS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using BlazorFrontendUTS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using BlazorFrontendUTS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{id}")]
    public partial class DetailEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 4 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
     Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(2, " ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                         Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "img");
            __builder.AddAttribute(6, "class", "card-img-top");
            __builder.AddAttribute(7, "style", "width: 200px; height:200px;");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 5 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                                                                    Employee.Photopath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                                                                                                        Mouse_Move

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "h4");
            __builder.AddContent(12, 
#nullable restore
#line 6 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
     Koordinat

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.AddMarkupContent(14, "<h3>Detail Employee</h3>\r\n            ");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, "Employee Id : ");
            __builder.AddContent(17, 
#nullable restore
#line 8 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                              Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, "Firts Name: ");
            __builder.AddContent(21, 
#nullable restore
#line 9 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                            Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "p");
            __builder.AddContent(24, "Last Name : ");
            __builder.AddContent(25, 
#nullable restore
#line 10 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                            Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "p");
            __builder.AddContent(28, "Email : ");
            __builder.AddContent(29, 
#nullable restore
#line 11 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                        Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "p");
            __builder.AddContent(32, "Date Of Birth: ");
            __builder.AddContent(33, 
#nullable restore
#line 12 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                               Employee.DateOfBirth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "p");
            __builder.AddContent(36, "Gender : ");
            __builder.AddContent(37, 
#nullable restore
#line 13 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                         Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "p");
            __builder.AddContent(40, "Department Id : ");
            __builder.AddContent(41, 
#nullable restore
#line 14 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                                Employee.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "p");
            __builder.AddContent(44, "Photo : ");
            __builder.AddContent(45, 
#nullable restore
#line 15 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                        Employee.Photopath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n\r\n");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "class", "btn btn-primary");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                                          Button_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, 
#nullable restore
#line 18 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                                                         ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 20 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\DetailEmployee.razor"
                                     CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "<a href=\"/employeedpage\"><button class=\"btn btn-primary\">Back</button></a>\r\n            ");
            __builder.AddMarkupContent(55, "<a href=\"#\"><button class=\"btn btn-primary\">Edit</button></a>\r\n            ");
            __builder.AddMarkupContent(56, "<a href=\"#\"><button class=\"btn btn-danger\">Hapus</button></a>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
