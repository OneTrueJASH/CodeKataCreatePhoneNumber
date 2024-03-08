using CreatePhoneNumber;
using Machine.Specifications;

namespace CreatePhoneNumber_Test
{
    public class When_Passing_In_10_integers
    {
        Establish context = () =>
        {
            input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            expectation = "(123) 456-7890";
        };

        Because of = () => answer = PhoneNumberBuilder.CreatePhoneNumber(input);
        It Should_Return_Stringified_Phone_Number = () => answer.ShouldEqual(expectation);

        static int[] input;
        static string expectation;
        static string answer;
    }
}