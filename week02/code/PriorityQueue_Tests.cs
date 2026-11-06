using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add the following items to the queue: Bob(5), Alice(6), John(7), Marcel(2)
    // Expected Result: John(7), Alice(6), Bob(5), Marcel(2)
    // Defect(s) Found: Assert.AreEqual failed. Expected:<Alice>. Actual:<John> (Loop boundary and failure to remove dequeued items). 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Alice", 6);
        priorityQueue.Enqueue("John", 7);
        priorityQueue.Enqueue("Marcel", 2);
        Assert.AreEqual("John", priorityQueue.Dequeue());
        Assert.AreEqual("Alice", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Marcel", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Describe adding Alice (5), Bob (8), David (5), and John (8), then removing all items
    // Expected Result: Bob(8), John(8), Alice(5), David(5)
    // Defect(s) Found: The original comparison used >=, which did not preserve the insertion order of items with equal priorities. The later item could replace the earlier item, violating the FIFO rule
                 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Alice", 5);
        priorityQueue.Enqueue("Bob", 8);
        priorityQueue.Enqueue("David", 5);
        priorityQueue.Enqueue("John", 8);
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("John", priorityQueue.Dequeue());
        Assert.AreEqual("Alice", priorityQueue.Dequeue());
        Assert.AreEqual("David", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Remove from an empty queue
    // Expected Result: InvalidOperationException is thrown
    // Defect(s) Found: No defect found if the expected exception was already implemented
    public void TestPriorityQueue_EmptyDequeue()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}