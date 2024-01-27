// See https://aka.ms/new-console-template for more information
using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutoMapperDemoData;
using AutoMapperDemoUI;

Console.WriteLine("Hello, World!");

var config = new MapperConfiguration(cfg => {
    cfg.CreateMap<ProductOwned, ProductOwnedDto>().ReverseMap();
    cfg.CreateMap<ProductComplex, ProductComplexDto>().ReverseMap();
    cfg.CreateMap<Dimension, DimensionDto>().ReverseMap();
});

var context = new ApplicationDbContext();

var first = context.ProductSOwned.ProjectTo<ProductOwnedDto>(config).ToList();
var second = context.ProductsComplex.ProjectTo<ProductComplexDto>(config).ToList();
