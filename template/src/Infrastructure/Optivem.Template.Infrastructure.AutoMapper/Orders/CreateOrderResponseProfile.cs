﻿using AutoMapper;
using Optivem.Template.Core.Application.Orders.Responses;
using Optivem.Template.Core.Domain.Orders;

namespace Optivem.Template.Infrastructure.Mapping.Orders
{
    public class CreateOrderResponseProfile : Profile
    {
        public CreateOrderResponseProfile()
        {
            CreateMap<Order, CreateOrderResponse>()
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(e => e.OrderItems));

            CreateMap<OrderItem, CreateOrderItemResponse>();
        }
    }
}