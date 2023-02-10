using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Client.Static
{
    public static class Endpoint
    {
        private static readonly string Prefix = "api";

        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string ProductsEndpoint = $"{Prefix}/products";
        public static readonly string OrdersEndpoint = $"{Prefix}/orders";
    }
}
