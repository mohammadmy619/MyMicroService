using Microsoft.AspNetCore.Mvc;
using Projects;

var builder = DistributedApplication.CreateBuilder(args);

//var cache = builder.AddRedis("cache");

//var apiService = builder.AddProject<Projects.Aspire_ApiService>("apiservice");

var Order_Api = builder.AddProject<Order_Api>("OrderApi");
var Discount_Api = builder.AddProject<Discount_Api>("DiscountApi");
var Product_Api = builder.AddProject<Product_Api>("ProductApi");

//builder.AddProject<Projects.Aspire_Web>("webfrontend")
//    .WithExternalHttpEndpoints()
//    .WithReference(cache)
//    .WithReference(apiService);

builder.Build().Run();
