using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xtensions.Binary;

namespace Tests {
    [TestFixture]
    public class BinaryExtensionsTests {
        [Test]
        public void Test_ToBase64String() {
            var tests = new List<TestHelper>();
            tests.Add(new TestHelper() { ByteArray_data = null, String_Expected = String.Empty });
            tests.Add(new TestHelper() { ByteArray_data = new byte[] { }, String_Expected = String.Empty });
            tests.Add(new TestHelper() { ByteArray_data = new byte[] { 31, 32, 33, 34 }, String_Expected = "HyAhIg==" });
            tests.Add(new TestHelper() { ByteArray_data = Guid.Parse("8a408cfb-97c1-4095-89f0-ee83f957d388").ToByteArray(), String_Expected = "+4xAisGXlUCJ8O6D+VfTiA==" });
            tests.Add(new TestHelper() { ByteArray_data = Guid.Parse("b76df3dd-ee79-46e5-850b-5ce81781bac6").ToByteArray(), String_Expected = "3fNtt3nu5UaFC1zoF4G6xg==" });
            tests.Add(new TestHelper() { ByteArray_data = Guid.Parse("438224cc-09a1-41b3-8ee0-d68618f6807a").ToByteArray(), String_Expected = "zCSCQ6EJs0GO4NaGGPaAeg==" });

            tests.ForEach(test => {
                test.String_Actual = test.ByteArray_data.ToBase64String();
                Assert.AreEqual(test.String_Expected, test.String_Actual, $"ToBase64String() returned {test.String_Actual}, '{test.String_Expected}' ");
            });
        }
    }
}
