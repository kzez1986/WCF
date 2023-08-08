using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;

namespace MagicEightBallServiceLib
{
    public class MagicEightBallService : IEightBall
    {
        public MagicEightBallService()
        {
            Console.WriteLine("The 8-ball await your question...");
        }

        public string ObtainAnswerToQuestion(string userQuestion)
        {
            string[] answers = { "Future Uncertain", "Yes", "No", "Hazy", "Ask again later", "Definitely" };

            Random r = new Random();
            return answers[r.Next(answers.Length)];
        }
    }

    [ServiceContract(Namespace = "http://MyCompany.com")]
    public interface IEightBall
    {
        [OperationContract]
        string ObtainAnswerToQuestion(string userQuestion);
    }
}
