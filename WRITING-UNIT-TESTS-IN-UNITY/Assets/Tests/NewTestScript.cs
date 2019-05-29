using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {

        myClass classy;
        [SetUp]
        public void SetupMyClass()
        {
            classy = new myClass();
        }

        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        [Test]
        public void BasicTest()
        {
            bool isActive = true;

            Assert.AreEqual(true, isActive, $"{true} != {isActive}.");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        [Test]
        public void CheckMyClass()
        {
            classy.CheckThis();

            Assert.AreEqual(classy.CheckThis(), true, $"classy.CheckThis() = {classy.CheckThis()}, NOT {false}!");
        }
    }
}
