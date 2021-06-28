using Xunit.Abstractions;

namespace ASTLibs.Tests
{
    public abstract class BaseTest
    {
        protected readonly ITestOutputHelper Debug;

        protected BaseTest(ITestOutputHelper helper)
        {
            Debug = helper;
        }
    }
}