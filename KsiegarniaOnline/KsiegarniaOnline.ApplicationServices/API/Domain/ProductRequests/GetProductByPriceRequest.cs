﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KsiegarniaOnline.ApplicationServices.API.Domain.ProductResponses;
using MediatR;

namespace KsiegarniaOnline.ApplicationServices.API.Domain.ProductRequests
{
   public class GetProductByPriceRequest : IRequest<GetProductByPriceResponse>
    {
        public decimal PriceFrom { get; set; }
        public decimal PriceTo { get; set; }
    }
}
