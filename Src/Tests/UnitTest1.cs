using Magic.Litedb;
using magic.node.extensions;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void EndsWith_001()
    {
        var lambda = Common.Evaluate(@"
litedb.query
   litedb.open:'test.db'
   'SELECT * FROM myCollection'");
        
        Assert.True(lambda.Children.Skip(1).First().Get<bool>());
    }

}