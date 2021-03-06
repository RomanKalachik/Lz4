﻿using LZ4;
using NUnit.Framework;
using System;
using System.IO;
using System.Text;

namespace Tanius.LZ4.Tests
{
    [TestFixture]
    public class LZ4CodecTests : LZ4Tools
    {
        [Test]
        public void TestCompressStream()
        {
            var content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsumcomes from a line in section 1.10.32.";
            CompressString("TestCompressStream.lz4", content);
        }



        [Test]
        public void TestDecompressStream()
        {
            string filename = "TestDecompressStream.lz4";
            string content = "some text some textsome textsome textsome textsome text";
            CompressString(filename, content);
            string result = DecompressString(filename);
            Assert.AreEqual(content, result);
        }

    }
}
