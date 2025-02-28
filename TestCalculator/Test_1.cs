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
        public void MSave_MultipleValues()
        {
            memory.MSave(10);
            memory.MSave(20);
            Assert.AreEqual(20, memory.MRecall());
        }
        [TestMethod]
        public void MSave_AfterMCl_StoreNewValue()
        {
            memory.MSave(10);
            memory.MClear();
            memory.MSave(5);
            Assert.AreEqual(5, memory.MRecall());
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
        public void MAdd_MultipleTime()
        {
            memory.MAdd(2);
            memory.MAdd(3);
            Assert.AreEqual(5, memory.MRecall());
        }

        [TestMethod]
        public void MSub_AlsoDoMSave()
        {
            memory.MSub(3);
            Assert.AreEqual(-3, memory.MRecall());
        }
        [TestMethod]
        public void MSub_MultipleTimeNegativeValues()
        {
            memory.MSub(2);
            memory.MSub(3);
            Assert.AreEqual(-5, memory.MRecall());
        }

        [TestMethod]
        public void MSub_WithNegativeValue()
        {
            memory.MSave(10);
            memory.MSub(-5);  // -5 хасах нь нэмэхтэй адил
            Assert.AreEqual(15, memory.MRecall());
        }



        [TestMethod]
        public void MRecall_ReturnZero()
        {
            Assert.AreEqual(0, memory.MRecall());
        }
        
        [TestMethod]
        public void MRecall_AfterMAddCorrect()
        {
            memory.MSave(10);
            memory.MAdd(5);
            Assert.AreEqual(15, memory.MRecall());
        }
        [TestMethod]
        public void MRecall_AfterMClear_ReturnZero()
        {
            memory.MSave(10);
            memory.MClear();
            Assert.AreEqual(0, memory.MRecall());
        }
        [TestMethod]
        public void MRecall_AfterMultipleOp()
        {
            memory.MSave(10);
            memory.MAdd(5);
            memory.MClear();
            Assert.AreEqual(0, memory.MRecall());
        }
        [TestMethod]
        public void Display_MemoryList()
        {
            memory.MSave(10);
            memory.MSave(20);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                memory.Display();

                string expectedOutput = "Memory list below" + Environment.NewLine +
                                        "Memory Item: 10" + Environment.NewLine +
                                        "Memory Item: 20" + Environment.NewLine;

                string actualOutput = sw.ToString();

                Assert.AreEqual(expectedOutput, actualOutput);
            }
        }


        [TestClass]
        public class MemoryItemTests
        {
            [TestMethod]
            public void Init_StoreValue()
            {
                var memoryItem = new MemoryItem(10);
                Assert.AreEqual(10, memoryItem.Value);
            }

            [TestMethod]
            public void Add_IncreaseValue()
            {
                var memoryItem = new MemoryItem(10);
                memoryItem.MAdd(5);
                Assert.AreEqual(15, memoryItem.Value);
            }

            [TestMethod]
            public void Sub_DecreaseValue()
            {
                var memoryItem = new MemoryItem(10);
                memoryItem.MSub(3);
                Assert.AreEqual(7, memoryItem.Value);
            }

            [TestMethod]
            public void Ops_CorrectResult()
            {
                var memoryItem = new MemoryItem(10);
                memoryItem.MAdd(5);
                memoryItem.MSub(3);
                Assert.AreEqual(12, memoryItem.Value);
            }



        }
    }
}
