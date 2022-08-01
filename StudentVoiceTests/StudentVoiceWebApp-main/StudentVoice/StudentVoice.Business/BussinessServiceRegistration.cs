using Microsoft.Extensions.DependencyInjection;
using StudentVoice.Business.Services;
using StudentVoice.Business.Services.IService;
using System.Reflection;


namespace StudentVoice.Bussiness
{
    public static class BussinessServiceRegistration
    {
        public static IServiceCollection AddBusinessService(this IServiceCollection services)
        {
            services.AddScoped<ISurveyService, SurveyService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<INotificationService, NotificationService>();
            //Need to add services for, notification and question
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
