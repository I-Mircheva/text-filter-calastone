using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextFilter.Tests
{
    [TestClass]
    public class FilterMiddleVowelTest
    {
        //[UnitOfWork_StateUnderTest_ExpectedBehavior]
        [TestMethod]
        public void Apply_InputStringWithVowelsAndPunctuation_Filtered()
        {
            var filter = new FilterMiddleVowel();
            var text = new OutputText("<<<<<Hop!1 dsd iv 5?iv");
            var filteredText = filter.Apply(text);

            Assert.AreEqual("<<<<<!1 dsd  5?", filteredText.text);
        }
        [TestMethod]
        public void Apply_InputStringWithoutVowels_Unchanged()
        {
            var filter = new FilterMiddleVowel();
            var text = new OutputText("Hr sj DJ hrompvr");
            var filteredText = filter.Apply(text);

            Assert.AreEqual("Hr sj DJ hrompvr", filteredText.text);
        }
        [TestMethod]
        public void Apply_InputStringWithVowels_Filtered()
        {
            var filter = new FilterMiddleVowel();
            var text = new OutputText("Jo has a nice shotgun in his car. He never uses it on animals though. Only on monsters!");
            var filteredText = filter.Apply(text);

            Assert.AreEqual("    shotgun   .  never    animals . Only  monsters!", filteredText.text);
        }
    }
}
