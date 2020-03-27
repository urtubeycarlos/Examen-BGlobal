using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_BGlobal.Services
{
    public class BrandsClient
    {
        private RestClient _client;
        public dynamic _result;
        public BrandsClient() 
        {
            _client = new RestClient("https://api.mercadolibre.com/categories/MLB1744");
            _result = _client.GetObject();
        }

        public List<string> GetBrands()
        {
            List<string> ret = new List<string>();

            var listOfBrands = _result.children_categories;

            for (int i = 0; i < listOfBrands.Count; i++)
            {
                var obj = listOfBrands[i].name;
                ret.Add(obj.ToString());
            }

            return ret;
            
        }
    }
}