﻿using GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;
using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce
{
    public class Add_To_Wishlist : IEvent
    {
        private string _name = "add_to_wishlist";
        private Cart_Parameters _parameters;//required for calls

        private Add_To_Wishlist(string currency, decimal value, List<Item> items)
        {
            this.parameters = new Cart_Parameters(currency, value, items);
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Cart_Parameters parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
}
