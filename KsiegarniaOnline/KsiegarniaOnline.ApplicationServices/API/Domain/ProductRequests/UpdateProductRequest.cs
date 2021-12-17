﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KsiegarniaOnline.ApplicationServices.API.Domain.ProductResponses;
using MediatR;
using static KsiegarniaOnline.DataAccess.Entities.Product;

namespace KsiegarniaOnline.ApplicationServices.API.Domain.ProductRequests
{
    public class UpdateProductRequest : IRequest<UpdateProductResponse>
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Author { get; set; } 
        public string Publisher { get; set; } 
        public int Year { get; set; } 
        public int Pages { get; set; } 
        public string Description { get; set; } 
        public decimal Price { get; set; } 
        public string ImageUrl { get; set; } 
        public bool IsBestseller { get; set; } 
        public bool InStock { get; set; }
        public string Series { get; set; } 
        public Types Type { get; set; }
        public Categories Category { get; set; }
        public Covers Cover { get; set; }
    }
}