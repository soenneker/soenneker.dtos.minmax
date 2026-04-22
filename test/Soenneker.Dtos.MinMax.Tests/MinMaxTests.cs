using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.MinMax.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class MinMaxTests : HostedUnitTest
{
    public MinMaxTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
