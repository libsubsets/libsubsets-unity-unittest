using System.Collections.Generic;
using LibUnity.Test;

namespace LibUnity.CoreTest.Test {

  public class WasRun : TestCase {
    public string result = "";

    public WasRun() : base() {
    }

    override protected void SetUp() {
      result += "SetUp ";
    }

    override protected void TearDown() {
      result += "TearDown";
    }

    public void test_method() {
      result += "test_method ";
    }
  }
}