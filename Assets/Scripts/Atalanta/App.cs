using Atalanta.Services;
using RSG;
using RSG.Utils;

namespace Atalanta
{
    public class App
    {
        public static App Instance
        {
            get;
            private set;
        }

        public IFactory Factory
        {
            get;
            private set;
        }

        private ISingletonManager singletonManager;

        public static void Startup()
        {
            if (Instance == null)
            {
                Instance = new App();
                UnityEngine.Debug.Log("in startup");
            }
        }

        private App()
        {
            var logger = new UnityLogger();
            var factory = new Factory("App", logger);
            factory.Dep<ILogger>(logger);
            factory.AutoRegisterTypes();

            this.Factory = factory;
            this.singletonManager = factory.AutoInstantiateSingletons();
            this.singletonManager.Startup();
        }

        public void Shutdown()
        {
            singletonManager.Shutdown();
        }
    }
}