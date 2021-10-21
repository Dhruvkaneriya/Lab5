using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{   
    [TestClass]
    public class TransitionSurface
    {
        [TestMethod]
        public void TransitionSurfaceTest()
        {
            TransitionSurface ts = new TransitionSurface();
            Assert.AreEqual(0,1);
            Assert.AreEqual(0,2);
        }
    }

    public class EmitSurface
    { 
        [TestMethod]
        public void EmitSurfaceTest() 
        {
            EmitSurface es = new EmitSurface();
            Assert.AreEqual(0,1);
            Assert.AreEqual(0,2);
        }
    }
}
