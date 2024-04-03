
namespace SkillTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testAction = new TestAction<int>();

            testAction.TestDating();
            testAction.TestQuestionAnswer(score:0);



        }
    }
}
