var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SpaceGameWorldContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("dbConnection")));
builder.Services.AddTransient<IAccount, AccountClass>();
builder.Services.AddTransient<IResources, ResourcesClass>();
builder.Services.AddTransient<ICreateUser, CreateUserClass>();
builder.Services.AddTransient<IDrone, DroneClass>();
builder.Services.AddTransient<IDroneSkills, DroneSkillsClass>();
builder.Services.AddTransient<IEfficiencyAction, EfficiencyActionClass>();
builder.Services.AddTransient<INetScan, NetScanClass>();
builder.Services.AddTransient<ILogin, LoginDataClass>();
builder.Services.AddTransient<IGameObject, GameObjectClass>();
builder.Services.AddTransient<ICreateLocation, CreateLocationClass  >();
builder.Services.AddTransient<IPlanet, PlanetClass>();
builder.Services.AddTransient<IDisasterWorld, DisasterWorldClass>();
builder.Services.AddTransient<IEventNew, EventNewClass>();
builder.Services.AddTransient<IMove, Move>();


// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRateLimitService(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint($"/swagger/v1/swagger.json", "Документация к игре APIWARS");
    });
}


//app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();