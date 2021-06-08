﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
   public class Rater
   {
      protected readonly RatingEngine _engine;
      protected ConsoleLogger _logger;

      public Rater(RatingEngine engine, ConsoleLogger logger)
      {
         _engine = engine;
         _logger = logger;
      }

      public virtual void Rate(Policy policy)
      {
         _logger.Log("Unknown Policy");
      }
   }
}
