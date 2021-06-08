using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
   public class Rater
   {
      private readonly RatingEngine _engine;
      private ConsoleLogger _logger;

      public Rater(RatingEngine engine, ConsoleLogger logger)
      {
         _engine = engine;
         _logger = logger;
      }

      public virtual void Rate(Policy policy)
      {
         _logger.Log("Default Policy");
      }
   }
}
