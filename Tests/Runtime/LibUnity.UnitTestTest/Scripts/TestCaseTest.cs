using System.Collections.Generic;
using LibUnity.UnitTest;

namespace LibUnity.UnitTestTest {

  public class TestCaseTest : TestCase {
    [TestMethod]
    public void TestMethod() {
      testCase = CreateTestCase(typeof(WasRun), "TestMethod") as WasRun;
      testCase.Run(result);
      Waits(1);
      Runs(on_run_result);
    }

    //[TestMethod]
    public void test_async() {
      WaitsFor(delegate () {
        return true;
      }, 1000);
      Runs(delegate () {
        testCase = CreateTestCase(typeof(WasRun), "TestMethod") as WasRun;
        testCase.Run(result);
      });
      Runs(on_run_result);
    }

    private void on_run_result() {
      Assert(testCase.result == "SetUp TestMethod TearDown");
    }

    //[TestMethod]
    public void TestResult() {
      testCase = CreateTestCase(typeof(WasRun), "TestMethod") as WasRun;
      testCase.Run(result);
      Assert(result.Summary() == "WasRun: 1 run, 0 failed");
    }

    override protected void SetUp() {
      string suite_name = "WasRun";
      result = new TestResult(suite_name);
    }

    override protected void TearDown() {
    }

    private TestResult result;
    private WasRun testCase = null;
  }
}
