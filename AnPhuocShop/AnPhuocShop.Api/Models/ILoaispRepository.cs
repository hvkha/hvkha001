using AnPhuocShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Api.Models
{
    public interface ILoaispRepository
    {
        Task<IEnumerable<Loaisp>> GetLoaisps();
        Task<Loaisp> GetLoaisp(int loaispId);
        Task<Loaisp> AddLoaisp(Loaisp loaisp);
        Task<Loaisp> UpdateLoaisp(Loaisp loaisp);
        Task<Loaisp> DeleteLoaisp(int loaispId);
        Task<IEnumerable<Loaisp>> Search(string name);
    }
}
