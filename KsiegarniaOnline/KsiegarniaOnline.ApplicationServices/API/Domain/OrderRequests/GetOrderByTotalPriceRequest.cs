﻿using KsiegarniaOnline.ApplicationServices.API.Domain.OrderResponses;
using MediatR;
using System;

namespace KsiegarniaOnline.ApplicationServices.API.Domain.OrderRequests
{
    public class GetOrderByTotalPriceRequest : IRequest<GetOrderByTotalPriceResponse>
    {
        public decimal From { get; set; }
        public decimal To { get; set; }

    }
}
