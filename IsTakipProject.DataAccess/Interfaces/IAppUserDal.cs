﻿using IsTakipProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakipProject.DataAccess.Interfaces
{
    public interface IAppUserDal
    {
        List<AppUser> GetirAdminOlmayanlar();
        List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa,string aranacakKelime,int aktifSayfa=1);
        List<DualHelper> GetirEnCokGorevTamamlamisPersoneller();
        List<DualHelper> GetirEnCokGorevdeCalisanPersoneller();
    }
}
