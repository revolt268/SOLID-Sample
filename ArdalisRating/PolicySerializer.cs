using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating
{
   public class PolicySerializer
   {
      public Policy GetPolicyFromJsonString(string policyJson)
      {
         return JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());
      }
   }
}
