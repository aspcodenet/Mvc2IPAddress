using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Mvc2IPAddress.Services;
using Mvc2IPAddress.ViewModels;

namespace Mvc2IPAddress.Controllers
{
    public class IpController : Controller
    {
        private readonly IIpAddressService _ipAddressService;

        public IpController(IIpAddressService ipAddressService)
        {
            _ipAddressService = ipAddressService;
        }


        public IActionResult GetMyIPAddress()
        {
            var viewModel = new IpGetMyIPAddressViewModel();

            viewModel.IpAddress = GetIp();

            return View(viewModel);
        }

        private string GetIp()
        {
            return _ipAddressService.GetCurrentWebVisitorsIpAddress();
        }
    }
}