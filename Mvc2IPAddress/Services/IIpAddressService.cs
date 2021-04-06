using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Mvc2IPAddress.Services
{
    public interface IIpAddressService
    {
        public string GetCurrentWebVisitorsIpAddress();
    }

    class IpAddressService : IIpAddressService
    {
        private readonly IActionContextAccessor _actionContextAccessor;

        public IpAddressService(IActionContextAccessor actionContextAccessor)
        {
            _actionContextAccessor = actionContextAccessor;
        }
        public string GetCurrentWebVisitorsIpAddress()
        {
            return _actionContextAccessor.ActionContext.HttpContext.Connection.RemoteIpAddress.ToString();
        }
    }
}