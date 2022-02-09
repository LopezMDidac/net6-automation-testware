﻿using System.Text.Json;

namespace TestWare.Core.Configuration;

public static class ConfigurationManager
{
    public static TestConfiguration ReadConfigurationFile(string filePath)
    {
        var configurationFile = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<TestConfiguration>(configurationFile);
    }
}