using midTerm.Models.Models.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace midTerm.Services.Abstraction
{
   public interface IOptionService
    {
        Task<IEnumerable<OptionModelBase>> Get();
        Task<OptionModelExtended> Get(int id);
        Task<OptionModelBase> Insert(OptionCreateModel model);
        Task<OptionModelBase> Update(OptionCreateModel model);
        Task<bool> Delete(int id);
    }
}
