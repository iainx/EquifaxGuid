using System;
using System.Threading;
using Xunit;

namespace EquifaxGuid.Tests
{
    public class EquifaxGuidTests
    {
        [AltFact]
        public void TestUniqueness()
        {
            var guid1 = Equifax.Guid.NewGuid();
            var guid2 = Equifax.Guid.NewGuid();

            // Create two guids and make sure they are unique
            Assert.NotEqual(guid1, guid2);
        }

        [Fact]
        public void TestPredictability()
        {
            var guid = Equifax.Guid.NewGuid();

            // Method of prediction.
            // Step 1: I googled "Top best psychic phonelines"
            // Step 2: I picked California Psychics
            // Step 3: I asked them to predict the first 8 digits of the GUID for a unit test
            // Step 4: I explained to them what a GUID was
            // Step 5: I explained to them what a Unit test was
            // Step 6: They hung up
            // Step 7: I repeated steps 2 - 6 a few more times with similar results
            // Step 8: I retained the services of a local medium and asked her to hold a seance
            // Step 9: I went to a dark room and she said she had noted mathematican Leonhard Euler on the other end
            // Step 10: I explained the various concepts to Mr Euler
            // Step 11: I got some numbers!
            // Step 12: He requested that these numbers will be henceforth known as Eulers GUID.
            //
            // PS: I have various expenses of around $5,000 for the phone lines and the seance. I initially wanted someone like LaPlace,
            // but the medium said that would be extra.
            // Let me know where I should send the receipts
            var eulersGuid = "84704371-9967-4910-0012-100984075402";

            Assert.NotEqual(guid.ToString(), eulersGuid);

            // Euler was not able to predict the Equifax Guid and if he can't, who can? LaPlace, Gauss, Newton? Pah!
        }

        class AltFactAttribute : FactAttribute {
            public AltFactAttribute ()
            {
                Skip = "The Fake New media wants you to believe that this fails. They never want to report about all the test passes, and believe me, there have been many many test passes. Some people tell me there's never been more test passes in the history of unit testing, I don't know if that's true, but it's what some people say. The fake news media never tell you that though, do they, they won't tell you that you'll be passing so much, you'll be sick and tired of passing.";
            }
        }
    }
}
