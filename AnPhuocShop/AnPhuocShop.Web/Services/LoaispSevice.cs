using AnPhuocShop.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AnPhuocShop.Web.Services
{
    public class LoaispSevice : ILoaispSevice
    {
        private readonly HttpClient httpClient;
        public LoaispSevice(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Loaisp> GetLoaisp(int id)
        {
            return await httpClient.GetJsonAsync<Loaisp>($"api/loaisps/{id}");
        }

        public async Task<IEnumerable<Loaisp>> GetLoaisps()
        {
            return await httpClient.GetJsonAsync<Loaisp[]>("api/loaisps");
        }
    }
}
