using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary
{
    public interface FunctionRepository
    {
        Question GetQuestion(int questionID);

        //admin functionality TODO

        void AddQuestion(Question question);
        void EditQuestion(Question question);
        void DeleteQuestion(Question question);

    }
}
