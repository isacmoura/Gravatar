using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar")]
        [TestMethod("Should validate gravatar extension")]
        [DataRow("", 200, false)]
        [DataRow(" ", 200, false)]
        [DataRow("a@a", 200, false)]
        [DataRow("a@andre.com", 200, false)]
        [DataRow("contatoisacmoura@outlook.com", null, true)]
        [DataRow("contatoisacmoura@outlook.com", 200, true)]
        public void ShouldValidateGravatar(string email, int? size, bool status)
        {
            var imageSize = size.HasValue ? size.Value.ToString() : "80";
            var result = $"https://www.gravatar.com/avatar/07af15ccaded5a2763805312001bda26?s={imageSize}";
            Assert.AreEqual((email.ToGravatar(size ?? 80) == result), status);
        }
    }
}
