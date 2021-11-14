using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnPhuocShop.Models;

namespace AnPhuocShop.Web.Pages
{
    public class HienthiSanphamBase:ComponentBase
    {
        [Parameter]
        public AnPhuoc AnPhuoc { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }
    }
}
