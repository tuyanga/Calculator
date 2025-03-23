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
        public void MSave_ShouldStoreValuesInOrder()
        {
            memory.MSave(10);
            memory.MSave(20);
            memory.MSave(30);

            List<int> expected = new List<int> { 10, 20, 30 };
            List<int> actual = memory.memoryList.Select(m => m.Value).ToList();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MClear_ShouldRemoveAllMemoryItems()
        {
            memory.MSave(10);
            memory.MSave(20);
            memory.MClear();

            Assert.AreEqual(0, memory.memoryList.Count);
        }

        [TestMethod]
        public void MC_ShouldRemoveSpecificMemoryItem()
        {
            var item1 = memory.MSave(10);
            var item2 = memory.MSave(20);
            var item3 = memory.MSave(30);

            item2.MC(memory.memoryList);

            List<int> expected = new List<int> { 10, 30 };
            List<int> actual = memory.memoryList.Select(m => m.Value).ToList();

            CollectionAssert.AreEqual(expected, actual);
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

