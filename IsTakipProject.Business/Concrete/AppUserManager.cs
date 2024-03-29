﻿using IsTakipProject.Business.Interfaces;
using IsTakipProject.DataAccess.Interfaces;
using IsTakipProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakipProject.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private IAppUserDal _userDal;
        public AppUserManager(IAppUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<AppUser> GetirAdminOlmayanlar()
        {
            return _userDal.GetirAdminOlmayanlar();
        }

        public List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa,string aranacakKelime, int aktifSayfa)
        {
            return _userDal.GetirAdminOlmayanlar(out toplamSayfa,aranacakKelime, aktifSayfa);
        }

        public List<DualHelper> GetirEnCokGorevdeCalisanPersoneller()
        {
            return _userDal.GetirEnCokGorevdeCalisanPersoneller();
        }

        public List<DualHelper> GetirEnCokGorevTamamlamisPersoneller()
        {
            return _userDal.GetirEnCokGorevTamamlamisPersoneller();
        }
    }
}
