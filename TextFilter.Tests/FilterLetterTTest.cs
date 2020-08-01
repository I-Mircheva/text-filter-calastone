using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextFilter.Tests
{
    [TestClass]
    public class FilterLetterTTest
    {
        //[UnitOfWork_StateUnderTest_ExpectedBehavior]
        [TestMethod]
        public void Apply_InputStringWithLetterTAndPunctuation_Filtered()
        {
            var filter = new FilterLetterT();
            var text = new OutputText("<<<<<Hop!1 hopity you efford is my property iv 5?itv");
            var filteredText = filter.Apply(text);

            Assert.AreEqual("<<<<<Hop!1  you efford is my  iv 5?", filteredText.text);
        }
        [TestMethod]
        public void Apply_InputStringWithoutLetterT_Unchanged()
        {
            var filter = new FilterLetterT();
            var text = new OutputText("Hr sj DJ hrompvr no leder d");
            var filteredText = filter.Apply(text);

            Assert.AreEqual("Hr sj DJ hrompvr no leder d", filteredText.text);
        }
        [TestMethod]
        public void Apply_InputStringWithLetterT_Filtered()
        {
            var filter = new FilterLetterT();
            var text = new OutputText("Meaningful text t explaining the power of the mind");
            var filteredText = filter.Apply(text);

            Assert.AreEqual("Meaningful   explaining  power of  mind", filteredText.text);
        }
    }
}
