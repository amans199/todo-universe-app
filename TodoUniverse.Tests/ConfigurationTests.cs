using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoUniverse.Library;

namespace TodoUniverse.Tests;

public class ConfigurationTests
{
    [Fact]
    public void IsLoaded()
    {
        IConfiguration config = null;

        Assert.False(config.IsLoaded());
    }
}
