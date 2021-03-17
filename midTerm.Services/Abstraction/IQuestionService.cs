using midTerm.Models.Models.Questions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace midTerm.Services.Abstraction
{
    public interface IQuestionService
    {
        Task<IEnumerable<QuestionModelBase>> Get();
        Task<QuestionModelExtended> Get(int id);
        Task<QuestionModelBase> Insert(QuestionCreateModel model);
        Task<QuestionModelBase> Update(QuestionCreateModel model);
        Task<bool> Delete(int id);
    }
}
