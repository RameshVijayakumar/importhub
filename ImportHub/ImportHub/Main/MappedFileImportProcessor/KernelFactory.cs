﻿using System.Collections.Generic;
using log4net;
using log4net.Config;
using Ninject;
using Ninject.Modules;

namespace MappedFileImportProcessor
{
    internal static class KernelFactory
    {
        private static IKernel _kernel;

        public static IKernel GetKernel()
        {
            if (_kernel != null) return _kernel;
            _kernel = new StandardKernel();
            XmlConfigurator.Configure();

            var loader = new ModuleLoader(_kernel);
            loader.LoadModules(new [] {"*.dll"});
            
            _kernel.Bind<ILog>().ToMethod(ctx => LogManager.GetLogger("Mapped File Import Processor"));
            return _kernel;
        }
    }
}
