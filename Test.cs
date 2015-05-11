using NUnit.Framework;
using NSubstitute;

public interface ICrasher
{
    void Crash<T>();
}

[TestFixture]
public class Test
{
    [Test]
    public void TestCrash()
    {
        Substitute.For<ICrasher>().Crash<object>();
    }
}
