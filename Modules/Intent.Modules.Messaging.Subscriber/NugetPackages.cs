using Intent.Modules.Common.VisualStudio;

namespace Intent.Modules.Messaging.Subscriber
{
    public static class NugetPackages
    {
        public static NugetPackageInfo AkkaRemote = new NugetPackageInfo("Akka.Remote", "1.1.1", "net45");

        public static NugetPackageInfo IntentEsbClient = new NugetPackageInfo("Intent.Esb.Client", "0.1.18-beta", "net45");
    }
}