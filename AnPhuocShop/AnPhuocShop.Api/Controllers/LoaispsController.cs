using AnPhuocShop.Api.Models;
using AnPhuocShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaispsController: ControllerBase
    {
        private readonly ILoaispRepository loaispRepository;
        public LoaispsController(ILoaispRepository loaispRepository)
        {
            this.loaispRepository = loaispRepository;
        }
        [HttpGet]//Dùng httpget để goi trình duyệt web
        public async Task<ActionResult<IEnumerable<Loaisp>>> GetLoaisps()
        {
            try
            {
                return (await loaispRepository.GetLoaisps()).ToList();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Lỗi khi truy xuất dữ liệu từ cơ sở dữ liệu");//hiện ra khi gặp lỗi ngoại lệ
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Loaisp>> GetLoaisp(int id)
        {
            try
            {
                var result = await loaispRepository.GetLoaisp(id);
                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi tu server");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Loaisp>> CreateLoaisp(Loaisp loaisp)
        {
            try
            {
                if (loaisp == null)
                    return BadRequest();
                var createLoaisp = await loaispRepository.AddLoaisp(loaisp);

                return CreatedAtAction(nameof(GetLoaisp),
                    new { id = createLoaisp.LoaispId }, createLoaisp);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi khi them san pham moi");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Loaisp>> UpdateLoaisp(int id, Loaisp loaisp)
        {
            try
            {
                if (id != loaisp.LoaispId)
                    return BadRequest("Ma ID khong khop");
                var loaispToUpdate = await loaispRepository.GetLoaisp(id);
                if (loaispToUpdate == null)
                    return NotFound($"Khong tim thay san pham Id = {id}");
                return await loaispRepository.UpdateLoaisp(loaisp);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi cap nhat du lieu");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Loaisp>> DeleteLoaisp(int id)
        {
            try
            {
                var loaispToDelete = await loaispRepository.GetLoaisp(id);
                if (loaispToDelete == null)
                {
                    return NotFound($"Khong tim thay san pham co Id = {id}");
                }
                return await loaispRepository.DeleteLoaisp(id);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi khi xoa du lieu");
            }
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Loaisp>>> Search(string name)
        {
            try
            {
                var result = await loaispRepository.Search(name);
                if (result.Any())
                {
                    return Ok(result);
                }
                else
                    return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi khi lay du lieu tu CSDL");
            }
        }
    }
}
