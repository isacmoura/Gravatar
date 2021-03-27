using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar")]
        [TestMethod("Should validate gravatar extension")]
        [DataRow("", false)]
        [DataRow(" ", false)]
        [DataRow("a@a", false)]
        [DataRow("a@andre.com", false)]
        [DataRow("contatoisacmoura@outlook.com", true)]
        public void ShouldValidateGravatar(string email, bool status)
        {
            var result = "https://www.gravatar.com/avatar/07af15ccaded5a2763805312001bda26";
            Assert.AreEqual((email.ToGravatar() == result), status);
        }
    }
}
