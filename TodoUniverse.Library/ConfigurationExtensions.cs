using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace TodoUniverse.Library;

public static class ConfigurationExtensions
{

    public static bool IsLoaded(this IConfiguration config)
    {
        return config != null  && config.AsEnumerable().Any();
    }

}
