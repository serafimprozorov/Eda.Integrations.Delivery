using Microsoft.Extensions.DependencyInjection;


namespace Eda.Extensions.DependencyInjection
{
    /// <summary>
    /// The contract for the application block it has the same functionality as the Autofac's Module.
    /// </summary>
    public interface IApplicationBlock
    {
        /// <summary>
        /// Adds the module ti the <paramref name="services"/>.
        /// </summary>
        /// <param name="services">The service collection.</param>
        void AddTo(IServiceCollection services);
    }
}