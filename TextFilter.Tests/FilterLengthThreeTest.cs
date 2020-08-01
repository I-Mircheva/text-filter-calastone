using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextFilter.Tests
{
    [TestClass]
    public class FilterLengthThreeTest
    {
        //[UnitOfWork_StateUnderTest_ExpectedBehavior]
        [TestMethod]
        public void Apply_InputStringWithUnder3LettersAndPunctuation_Filtered()
        {
            var filter = new FilterLengthThree();
            var text = new OutputText("<<<<<Hop!1 dsd having a good timeee iv 5?iv");
            var filteredText = filter.Apply(text);

            Assert.AreEqual("<<<<<Hop! dsd having  good timeee  ?", filteredText.text);
        }
        [TestMethod]
        public void Apply_InputStringWithoutUnder3Letters_Unchanged()
        {
            var filter = new FilterLengthThree();
            var text = new OutputText("Hrsdf ssdj DJsss hrompvr");
            var filteredText = filter.Apply(text);

            Assert.AreEqual("Hrsdf ssdj DJsss hrompvr", filteredText.text);
        }
        [TestMethod]
        public void Apply_InputStringWithUnder3Letters_Filtered()
        {
            var filter = new FilterLengthThree();
            var text = new OutputText("Jo has a nice shotgun");
            var filteredText = filter.Apply(text);

            Assert.AreEqual(" has  nice shotgun", filteredText.text);
        }
    }
}
