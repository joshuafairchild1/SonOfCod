using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests.ModelTests
{
    public class NewsletterMemberTest
    {
        [Fact]
        public void GetNameTest()
        {
            NewsletterMember member = new NewsletterMember("Joshua", "Joshua@mail.com");

            string result = member.Name;

            Assert.Equal("Joshua", result);
        }

        [Fact]
        public void GetEmailTest()
        {
            NewsletterMember member = new NewsletterMember("Joshua", "Joshua@mail.com");

            string result = member.Email;

            Assert.Equal("Joshua@mail.com", result);
        }
    }
}
