using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    public interface ICoreModule
    {
        void Load(IServiceCollection collection);
    }

}
