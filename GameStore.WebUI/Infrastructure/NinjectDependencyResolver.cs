using GameStore.Domain.Concrete;

namespace GameStore.WebUI.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Web.Mvc;

    using Moq;
    using Ninject;

    using GameStore.Domain.Entities;
    using GameStore.Domain.Abstract;

    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IGameRepository>().To<EFGameRepository>();
        }
    }
}
