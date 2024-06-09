using OmniGLM_API.Setup;

var devOrigin = "_devOrigin";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: devOrigin,
        policy  =>
        {
            policy.WithOrigins("http://localhost:5173");
        });
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.ConfigureServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(devOrigin);
app.UseAuthorization();

app.MapControllers();
app.UsePathBase(new PathString("/api"));
app.UseRouting();

app.Run();
