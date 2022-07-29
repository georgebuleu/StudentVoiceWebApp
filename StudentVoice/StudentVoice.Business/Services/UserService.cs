using StudentVoice.Business.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentVoice.Domain.IRepositories;
using AutoMapper;
using StudentVoice.Business.Models;
using StudentVoice.Domain.Entities;

namespace StudentVoice.Business.Services
{

   public class UserService : IUserService
    {
        private readonly IUserRepository  _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public int AddUser(UserModel model)
        {
                
                var user = _userRepository.Add(_mapper.Map<User>(model));
                return user.Id;
            
        }

        

        public void Delete(int id)
        {
           _userRepository.Delete(_userRepository.GetById(id));
        }

        public int GetByEmail(string email)
        {
            var user = _userRepository.GetUserByEmail(email);
       
            return user;
           
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public IEnumerable<User> GetUserBySurvey(int id)
        {
            return _userRepository.GetUserBySurvey(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.ListAll();
        }

        
        public void Update(User user)
        {
            _userRepository.Update(user);
        }
    }
}
