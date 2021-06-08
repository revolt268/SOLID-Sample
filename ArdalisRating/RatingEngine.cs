﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
   /// <summary>
   /// The RatingEngine reads the policy application details from a file and produces a numeric 
   /// rating value based on the details.
   /// </summary>
   public class RatingEngine
   {
      public FilePolicySource PolicySource { get; set; } = new FilePolicySource();
      public ConsoleLogger Logger { get; set; } = new ConsoleLogger();
      public PolicySerializer PolicySerial { get; set; } = new PolicySerializer();
      public decimal Rating { get; set; }
      public void Rate()
      {
         Logger.Log("Starting rate.");

         Logger.Log("Loading policy.");
         // load policy - open file policy.json
         string policyJson = PolicySource.GetPolicyFromSource();

         var policy = PolicySerial.GetPolicyFromJsonString(policyJson);

         var factory = new RaterFactory();
         var rater = factory.Create(policy, this);
         rater.Rate(policy);

         Logger.Log("Rating completed.");
      }
   }
}
