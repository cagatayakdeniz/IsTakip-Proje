﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsTakipProject.Business.Interfaces;
using IsTakipProject.Entities.Concrete;
using IsTakipProject.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IsTakipProject.Web.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    [Area("Admin")]
    public class BildirimController : Controller
    {
        private IBildirimService _bildirimService;
        private UserManager<AppUser> _userManager;
        public BildirimController(IBildirimService bildirimService,UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _bildirimService = bildirimService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var bildirimler = _bildirimService.GetirOkunmayanlar(user.Id);

            List<BildirimListViewModel> models = new List<BildirimListViewModel>();

            foreach (var bildirim in bildirimler)
            {
                BildirimListViewModel model = new BildirimListViewModel();
                model.Id = bildirim.Id;
                model.Aciklama = bildirim.Aciklama;
                models.Add(model);
            }

            return View(models);
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            var bildirim = _bildirimService.GetirIdile(id);
            bildirim.Durum = true;
            _bildirimService.Guncelle(bildirim);
            return RedirectToAction("Index");
        }
    }
}