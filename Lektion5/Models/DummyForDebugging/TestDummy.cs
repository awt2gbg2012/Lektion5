using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lektion5.Models.DummyForDebugging
{
    public class TestDummy
    {
        private InnerTestDummy innerDummy;
        public TestDummy()
        {
            innerDummy = new InnerTestDummy();
        }

        public string GetString()
        {
            return innerDummy.getMyString();
        }
    }

    public class InnerTestDummy
    {
        private string myString;
        public InnerTestDummy() {
            setMyString();
        }

        public void setMyString() {
            throw new IndexOutOfRangeException();
            myString = "test";
        }

        public string getMyString() {
            return myString;
        }
    }
}