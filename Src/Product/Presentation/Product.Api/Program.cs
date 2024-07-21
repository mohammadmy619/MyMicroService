
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.AddServiceDefaults();

//builder.Services.AddControllers();


builder.Configuration.AddEnvironmentVariables();

builder.Services.ConfigureMapster();
builder.Services.ConfigureValidator();

builder.Services.ConfigurePersistenceServices(builder.Configuration);
builder.Services.ApplicationServicesRegistration(builder.Configuration);

builder.Services.AddEndpoints();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();


builder.Services.ConfigureCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

////app.UseHttpsRedirection();
////app.UseCors("AllowOrigin");
//app.UseAuthorization();
//app.UseAuthentication();
//app.MapControllers();
//app.MapEndpoints();
//app.UseExceptionHandler();
app.UseExceptionHandler();
app.UseCors("AllowOrigin");

app.UseSwagger();
app.UseSwaggerUI();

app.MapEndpoints();

app.Run();
