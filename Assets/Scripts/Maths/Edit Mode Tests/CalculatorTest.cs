using System.Collections;
using System.Collections.Generic;
using Maths;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CalculatorTest
{
    [SetUp]
    public void SetUp()
    {
    }
    
    [TearDown]
    public void TearDown()
    {
    }
    
    // A Test behaves as an ordinary method
    [Test]
    public void Sum_TwoNumberAreAdded_ReturnsCorrectResult()
    {
        var calculator = new Calculator();
        var result = calculator.Sum(20, 30);
        
        Assert.AreEqual(50, result, "Result is not as expected.");
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CalculatorTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
