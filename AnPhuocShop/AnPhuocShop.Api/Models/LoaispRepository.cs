using AnPhuocShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Api.Models
{
    public class LoaispRepository : ILoaispRepository
    {
        private readonly AppDbContext appDbContext;
        public LoaispRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async  Task<Loaisp> AddLoaisp(Loaisp loaisp)
        {
            var result = await appDbContext.Loaisps.AddAsync(loaisp);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Loaisp> DeleteLoaisp(int loaispId)
        {
            var result = await appDbContext.Loaisps
                .FirstOrDefaultAsync(l => l.LoaispId == loaispId);
            if (result != null)
            {
                appDbContext.Loaisps.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            else
                return null;
        }

        public async Task<Loaisp> GetLoaisp(int loaispId)
        {
            return await appDbContext.Loaisps.FirstOrDefaultAsync(l => l.LoaispId == loaispId);
        }

        public async  Task<IEnumerable<Loaisp>> GetLoaisps()
        {
            return await appDbContext.Loaisps.ToListAsync();
        }

        public async Task<Loaisp> UpdateLoaisp(Loaisp loaisp)
        {
            var result = await appDbContext.Loaisps
                 .FirstOrDefaultAsync(l => l.LoaispId == loaisp.LoaispId);
            if (result != null)
            {
                result.LoaispName = loaisp.LoaispName;
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Loaisp>> Search(string name)
        {
            IQueryable<Loaisp> query = appDbContext.Loaisps;
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(a => a.LoaispName.Contains(name));
            }
            return await query.ToListAsync();
        }
    }
}
