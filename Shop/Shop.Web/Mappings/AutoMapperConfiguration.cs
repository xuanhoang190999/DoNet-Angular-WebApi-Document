﻿using AutoMapper;
using Shop.Model.Models;
using Shop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}