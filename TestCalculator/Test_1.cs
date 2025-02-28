using CalculatorLibrary.Memoryfolder;

using CalculatorLibrary.Calculatorfoler;

namespace TestCalculator
{
    [TestClass]
        public class MemoryTests
        {
            private Memory? memory;

        [TestInitialize]
        public void Setup()
        {
            memory = new Memory();
        }
        [TestMethod]
        public void MSave_Store_MValue()
            {
                memory.MSave(10);
                Assert.AreEqual(10, memory.MRecall());
            }
        [TestMethod]
        public void MClear_Clear_Memory()
            {
                memory.MSave(10);
                memory.MClear();
                Assert.AreEqual(0, memory.MRecall());
            }
        [TestMethod]
        public void MAdd_Increase_MValue()
            {
                memory.MSave(10);
                memory.MAdd(5);
                Assert.AreEqual(15, memory.MRecall());
            }
        [TestMethod]
        public void MSub_Decrease_MValue()
            {
                memory.MSave(10);
                memory.MSub(3);
                Assert.AreEqual(7, memory.MRecall());
            }
        [TestMethod]
        public void MAdd_AlsoDoMSave()
        {
            memory.MAdd(5);
            Assert.AreEqual(5, memory.MRecall());
        }

        [TestMethod]
        public void MSub_AlsoDoMSave()
        {
            memory.MSub(3);
            Assert.AreEqual(-3, memory.MRecall());
        }

        [TestMethod]
        public void MRecall_ReturnZero()
            {
                Assert.AreEqual(0, memory.MRecall());
            }
        }

}
