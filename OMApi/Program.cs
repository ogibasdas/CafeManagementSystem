using OM.Business.Abstract;
using OM.Business.Concrete;
using OM.DataAccess.Abstract;
using OM.DataAccess.Concrete;
using OM.DataAccess.EntityFramework;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<SignalRContext>();
        builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
        builder.Services.AddScoped<IAboutService, AbtMngr>();
        builder.Services.AddScoped<IAboutDal, EntityFrameworkAboutDal>();
        builder.Services.AddScoped<IBookingService, BkngMngr>();
        builder.Services.AddScoped<IBookingDal, EntityFrameworkBookingDal>();
        builder.Services.AddScoped<ICategoryService, CtgryMngr>();
        builder.Services.AddScoped<ICategoryDal, EntityFrameworkCategoryDal>();
        builder.Services.AddScoped<IContactService, CntctMngr>();
        builder.Services.AddScoped<IContactDal, EntityFrameworkContactDal>();
        builder.Services.AddScoped<IDiscountService, DscntMngr>();
        builder.Services.AddScoped<IDiscountDal, EntityFrameworkDiscountDal>();
        builder.Services.AddScoped<IReferenceService, RefMngr>();
        builder.Services.AddScoped<IReferenceDal, EntityFrameworkReferenceDal>();
        builder.Services.AddScoped<ISocialMediaService, SclMed>();    //SclMedMngr olmasi lazim ama OM.Business/Concrete'de ismi eksik yazmisim.
        builder.Services.AddScoped<ISocialMediaDal, EntityFrameworkSocialMediaDal>();
        builder.Services.AddScoped<IFeatureService, FtrMngr>();
        builder.Services.AddScoped<IFeatureDal, EntityFrameworkFeatureDal>();
        builder.Services.AddScoped<IProductService, PrdctMngr>();
        builder.Services.AddScoped<IProductDal, EntityFrameworkProductDal>();
        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "OM API v1");
                c.RoutePrefix = string.Empty; // Burasý önemli!
            });
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}