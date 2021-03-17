using AutoMapper;
using Microsoft.EntityFrameworkCore;
using midTerm.Data.Entities;
using midTerm.Data.Migrations;
using midTerm.Models.Models.Questions;
using midTerm.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace midTerm.Services.Services
{
    public class QuestionService
        : IQuestionService

    {
        private readonly midTermDbContext _context;
        private readonly IMapper _mapper;
        public QuestionService(midTermDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            var entity = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(entity);
            return await SaveAsync() > 0;
        }

        public async Task<IEnumerable<QuestionModelBase>> Get()
        {
            var questions = await _context.Questions.ToListAsync();
            return _mapper.Map<IEnumerable<QuestionModelBase>>(questions);
        }

        public Task<QuestionModelExtended> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<QuestionModelBase> Insert(QuestionCreateModel model)
        {
            var entity = _mapper.Map<Question>(model);

            await _context.Questions.AddAsync(entity);
            await SaveAsync();

            return _mapper.Map<QuestionModelBase>(entity);
        }

        public async Task<QuestionModelBase> Update(QuestionCreateModel model)
        {
            var entity = _mapper.Map<Question>(model);

            _context.Questions.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            await SaveAsync();

            return _mapper.Map<QuestionModelBase>(entity);
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
