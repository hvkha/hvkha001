using AnPhuocShop.Models;
using AnPhuocShop.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Web.Pages
{
    public class EditAnPhuocBase:ComponentBase
    {
        public AnPhuoc AnPhuoc { get; set; } = new AnPhuoc();
        [Inject]
        public IAnPhuocService AnPhuocService { get; set; }

        [Parameter]
        public string Id { get; set; }

        [Inject]
        public ILoaispSevice LoaispSevice { get; set; }
        public IEnumerable<Loaisp> Loaisps { get; set; }
        public string LoaispId { get; set; }
        protected async override Task OnInitializedAsync()
        {
            AnPhuoc = await AnPhuocService.GetAnPhuoc(int.Parse(Id));
            LoaispId = AnPhuoc.LoaispId.ToString();
            Loaisps = await LoaispSevice.GetLoaisps();
        }
    }
}
