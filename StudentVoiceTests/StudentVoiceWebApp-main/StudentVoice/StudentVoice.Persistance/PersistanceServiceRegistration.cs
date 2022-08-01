using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentVoice.Domain.IRepositories;
using StudentVoice.Persistance.Data;
using StudentVoice.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Persistance
{
    public static class PersistanceServiceRegistration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StudentVoiceDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("StudentVoiceConnectionString")));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ISurveyRepository, SurveyRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository > ();


            return services;
        }
    }
}
