﻿using AutoMapper;
using CSGOMarketplace.Data.Models;
using CSGOMarketplace.Models.Items;
using CSGOMarketplace.Services.Items.Models;
using CSGOMarketplace.Services.Sales.Models;

namespace CSGOMarketplace.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<ItemJsonResponseModel, ItemServiceModel>();

            this.CreateMap<ItemServiceModel, ItemFormModel>();
            this.CreateMap<Item, ItemServiceModel>().ReverseMap();

            this.CreateMap<Item, LatestItemServiceModel>()
                .ForMember(i => i.Condition, cfg => cfg.MapFrom(i => i.Condition.Name));

        }
    }
}
