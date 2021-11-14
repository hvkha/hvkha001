using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnPhuocShop.Models;

namespace AnPhuocShop.Web.Services
{
    public interface ILoaispSevice
    {
        Task<IEnumerable<Loaisp>> GetLoaisps();
        Task<Loaisp> GetLoaisp(int id);
    }
}
