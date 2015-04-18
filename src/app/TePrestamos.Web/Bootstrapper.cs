using Nancy.Conventions;
using Nancy.Hosting.Aspnet;

namespace TePrestamos.Web
{
    public class Bootstrapper : DefaultNancyAspNetBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions conventions)
        {
            base.ConfigureConventions(conventions);
            conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Client", @"Client"));
        }
    }
}