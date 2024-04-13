using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

var features = new Dictionary<string, string> { { "FeatureManagement:Premium", "false" } };

IConfigurationRoot config = new ConfigurationBuilder().AddInMemoryCollection(features).Build();

IServiceCollection services = new ServiceCollection();

services.AddFeatureManagement(config);

IServiceProvider serviceProvider = services.BuildServiceProvider();

IFeatureManager featureManager = serviceProvider.GetRequiredService<IFeatureManager>();