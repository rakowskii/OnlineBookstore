﻿using AutoMapper;
using KsiegarniaOnline.ApplicationServices.API.Domain.OrderRequests;
using KsiegarniaOnline.ApplicationServices.API.Domain.OrderResponses;
using KsiegarniaOnline.DataAccess;
using KsiegarniaOnline.DataAccess.CQRS.Queries.Orders;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace KsiegarniaOnline.ApplicationServices.API.Handlers.OrderHandlers
{
    public class GetOrderByTotalPriceHandler : IRequestHandler<GetOrderByTotalPriceRequest, GetOrderByTotalPriceResponse>
    {
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;

        public GetOrderByTotalPriceHandler(IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
        }

        public async Task<GetOrderByTotalPriceResponse> Handle(GetOrderByTotalPriceRequest request, CancellationToken cancellationToken)
        {
            var query = new GetOrderByTotalPriceQuery
            {
                From = request.From,
                To = request.To
            };
            var order = await queryExecutor.Execute(query);
            var mappedOrder = mapper.Map<List<Domain.Models.Order>>(order);
            return new GetOrderByTotalPriceResponse
            {
                Data = mappedOrder
            };
        }
    }
}