﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSJadeUtilities.DataGridViewModels
{
    class DgvUserPriceListModel
    {
        public String UserPriceButtonEdit { get; set; }
        public String UserPriceButtonDelete { get; set; }
        public Int32 UserPriceListId { get; set; }
        public Int32 UserPriceListUserId { get; set; }
        public String UserPriceListUserFullName { get; set; }
        public String UserPriceListPriceDescription { get; set; }
    }
}
