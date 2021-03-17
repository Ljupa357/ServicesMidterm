using AutoMapper;
using Microsoft.EntityFrameworkCore;
using midTerm.Data.Entities;
using midTerm.Data.Migrations;
using midTerm.Models.Models.Options;
using midTerm.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace midTerm.Services.Services
{
    public class OptionService
        : IOptionService
    {
       
            private readonly midTermDbContext _context;
            private readonly IMapper _mapper;

            public OptionService(midTermDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<bool> Delete(int id)
        {
            var entity = await _context.Options.FindAsync(id);
            _context.Options.Remove(entity);
            return await SaveAsync() > 0;
        }

        private Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OptionModelBase>> Get()
        {
            var options = await _context.Options.ToListAsync();
            return _mapper.Map<IEnumerable<OptionModelBase>>(options);
        }

        public Task<OptionModelExtended> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<OptionModelBase> Insert(OptionCreateModel model)
        {
            var entity = _mapper.Map<Option>(model);

            await _context.Options.AddAsync(entity);
            await SaveAsync();

            return _mapper.Map<OptionModelBase>(entity);
        }

        public async Task<OptionModelBase> Update(OptionCreateModel model)
        {
            var entity = _mapper.Map<Option>(model);

            _context.Options.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            await SaveAsync();

            return _mapper.Map<OptionModelBase>(entity);
        }
    }
}
