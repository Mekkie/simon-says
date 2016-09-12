﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Simon_Says
{
// Hints
//
// When you make the second `repeat` test pass, you might break the **first**
//


    [TestClass]
    public class SimonSaysTest
    {
        [TestMethod]
        public void ShouldEchoHello()
        {
            Simon simon = new Simon();
            Assert.AreEqual("hello", Simon.Echo("hello"));
        }
        [TestMethod]
        public void ShouldEchoBye()
        {
            Simon simon = new Simon();
            Assert.AreEqual("bye", Simon.Echo("Bye"));
        }
        [TestMethod]
        public void ShoutHello()
        {
            Simon simon = new Simon();
            Assert.AreEqual("HELLO", Simon.Shout("hello"));
        }
        [TestMethod]
        public void ShoutMultipleWords()
        {
            Simon simon = new Simon();
            Assert.AreEqual("HELLO WORLD", Simon.Shout("hello world"));
        }
        [TestMethod]
        public void ShouldRepeat()
        {
            Simon simon = new Simon();
            Assert.AreEqual("hello hello", Simon.Repeat("hello"));
        }


        // Wait a second! How can you make the "repeat" method
        // take one *or* two arguments?

        // Hint: "Default values"

        [TestMethod]
        public void ShouldRepeatANumberOfTimes()
        {
            Simon simon = new Simon();
            Assert.AreEqual("hello hello hello", Simon.Repeat("hello", 3));
        }

        [TestMethod]
        public void ShouldRepeatANumberOfTimes1()
        {
            Simon simon = new Simon();
            Assert.AreEqual("hello hello hello", Simon.Repeat("hello", 3));
        }
        [TestMethod]
        public void ReturnsFirstLetterOfWord()
        {
            Simon simon = new Simon();
            Assert.AreEqual("h", Simon.StartOfWord("hello", 1));
        }
        [TestMethod]
        public void ReturnsFirstTwoLettersOfWord()
        {
            Simon simon = new Simon();
            Assert.AreEqual("Bo", Simon.StartOfWord("Bob", 2));
        }
        [TestMethod]
        public void ReturnsFirstSeveralLettersOfWord()
        {
            Simon simon = new Simon();
            string s = "abcdefg";
            Assert.AreEqual("a", Simon.StartOfWord(s, 1));
            Assert.AreEqual("ab", Simon.StartOfWord(s, 2));
            Assert.AreEqual("abc", Simon.StartOfWord(s, 3));
        }
        [TestMethod]
        public void ReturnsFirstWordOfHelloWorld()
        {
            Simon simon = new Simon();
            Assert.AreEqual("Hello", Simon.FirstWord("Hello World"));
        }
        [TestMethod]
        public void ReturnsFirstWordOfOhDear()
        {
            Simon simon = new Simon();
            Assert.AreEqual("Oh", Simon.FirstWord("Oh Dear"));
        }
        [TestMethod]
        public void CapitilizeAWord()
        {
            Simon simon = new Simon();
            Assert.AreEqual("Jaws", Simon.Titleize("jaws"));
        }
        [TestMethod]
        public void CapitilizeEveryWord()
        {
            Simon simon = new Simon();
            Assert.AreEqual("David Copperfield", Simon.Titleize("david copperfield"));
        }
        [TestMethod]
        public void DontCapitilizeLittleWords()
        {
            Simon simon = new Simon();
            Assert.AreEqual("War and Peace", Simon.Titleize("war and peace"));
        }
        [TestMethod]
        public void CapitilizeLittleWordsInBeginningOfSentence()
        {
            Simon simon = new Simon();
            Assert.AreEqual("The Bridge over the River Kwai", Simon.Titleize("the bridge over the river kwai"));
        }
    }
}
