﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface IWareAreaManaView:IBaseView
    {
        void RefreshHouseListData(List<string> houseList);
    }
}
