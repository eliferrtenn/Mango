using Mango.Web.Dtos;
using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto>? GetCouponAsync(string couponCode);
        Task<ResponseDto>? GetAllCouponsAsync();
        Task<ResponseDto>? GetCouponByIdAsync(int id);
        Task<ResponseDto>? CreateCouponAsync(CouponDto reqDto);
        Task<ResponseDto>? UpdateCouponAsync(CouponDto reqDto);
        Task<ResponseDto>? DeleteCouponAsync(int id);
    }
}