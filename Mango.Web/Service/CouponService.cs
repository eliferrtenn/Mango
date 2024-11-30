using Mango.Web.Dtos;
using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utilities;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        public IBaseService _baseService;

        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }


        public async Task<ResponseDto>? CreateCouponAsync(CouponDto reqDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Url = SD.CouponAPIBase + $"/api/coupon",
                Data = reqDto
            });
        }

        public async Task<ResponseDto>? DeleteCouponAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.CouponAPIBase + $"/api/coupon/{id}"
            });
        }

        public async Task<ResponseDto>? GetAllCouponsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon",
            });
        }

        public async Task<ResponseDto>? GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + $"/api/coupon/GetByCode/{couponCode}"
            });
        }

        public async Task<ResponseDto>? GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + $"/api/coupon/{id}"
            });
        }

        public async Task<ResponseDto>? UpdateCouponAsync(CouponDto reqDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Url = SD.CouponAPIBase + $"/api/coupon",
                Data = reqDto
            });
        }
    }
}