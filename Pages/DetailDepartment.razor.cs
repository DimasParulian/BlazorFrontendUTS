using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFrontendUTS.Models;
using BlazorFrontendUTS.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFrontendUTS.Pages
{
    public partial class DetailDepartment
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IDepartmentService DepartmentService{ get; set; }


        public Department Department { get; set; } = new Department();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Department = await DepartmentService.GetById(int.Parse(id));
        }
    }
}