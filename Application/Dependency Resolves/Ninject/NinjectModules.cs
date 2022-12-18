using A_Domain.RepostoryInterface;
using C_Infrustructure.RepostoryEntities;
using Ninject.Modules;

namespace B_App.Ninject
{
    public class NinjectModules : NinjectModule
    {
        public override void Load()
        {
            Bind<IGrupRepository>().To<EfGrupRepository>().InSingletonScope();
            Bind<IİletişimNumarasıRepository>().To<EfİletişimNumarasıRepository>().InSingletonScope();

            Bind<IİletişimTürRepository>().To<EfiletişimTürRepository>().InSingletonScope();

            Bind<IKisiGruplariRepository>().To<EfKisiGruplariRepository>().InSingletonScope();

            Bind<IKisiRepository>().To<EfKisiRepository>().InSingletonScope();

            Bind<IMailRepository>().To<EfMailRepository>().InSingletonScope();
        }
    }
}
