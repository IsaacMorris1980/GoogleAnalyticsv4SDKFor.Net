﻿using GoogleAnalyticsv4SDK.Models;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.EcommerceEvents
{
    public class Add_To_Cart
    {
        private string currency; //required
        private decimal value; //required
        private List<Item> items; //required

    }
}
