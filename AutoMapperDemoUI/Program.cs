// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutoMapperDemoData;
using AutoMapperDemoUI;

Console.WriteLine("Hello, World!");

var config = new MapperConfiguration(cfg => {
    cfg.CreateMap<ProductOwned, ProductOwnedDto>().ReverseMap();
    cfg.CreateMap<ProductComplex, ProductComplexDto>()
        .ForAllMembers(opt =>
        {
            opt.AllowNull();
            opt.Condition((src, dest, srcMember) => srcMember != null);
        });
    cfg.CreateMap<ProductComplexDto, ProductComplex>()
        .ForAllMembers(opt =>
        {
            opt.AllowNull();
            opt.Condition((src, dest, srcMember) => srcMember != null);
        });
    cfg.CreateMap<Dimension, DimensionDto>().ForAllMembers(opt =>
    {
        opt.AllowNull();
        opt.Condition((src, dest, srcMember) => srcMember != null);
    });
    cfg.CreateMap<DimensionDto, Dimension>().ForAllMembers(opt =>
    {
        opt.AllowNull();
        opt.Condition((src, dest, srcMember) => srcMember != null);
    });
});

var context = new ApplicationDbContext();

var first = context.ProductSOwned.ProjectTo<ProductOwnedDto>(config).ToList();
var second = context.ProductsComplex.ProjectTo<ProductComplexDto>(config).ToList();
