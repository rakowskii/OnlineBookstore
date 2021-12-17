﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using KsiegarniaOnline.ApplicationServices.API.Domain.ProductRequests;
using KsiegarniaOnline.ApplicationServices.API.Domain.ProductResponses;
using KsiegarniaOnline.DataAccess;
using KsiegarniaOnline.DataAccess.CQRS.Queries.Products;
using MediatR;

namespace KsiegarniaOnline.ApplicationServices.API.Handlers.ProductHandlers
{
    public class GetProductByPublisherHandler : IRequestHandler<GetProductByPublisherRequest, GetProductByPublisherResponse>
    {
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;

        public GetProductByPublisherHandler(IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
        }

        public async Task<GetProductByPublisherResponse> Handle(GetProductByPublisherRequest request, CancellationToken cancellationToken)
        {
            var query = new GetProductByPublisherQuery
            {
                Publisher = request.Publisher
            };
            var product = await queryExecutor.Execute(query);
            var mappedProduct = mapper.Map<List<Domain.Models.Product>>(product);
            return new GetProductByPublisherResponse
            {
                Data = mappedProduct
            };
        }
    }
}
