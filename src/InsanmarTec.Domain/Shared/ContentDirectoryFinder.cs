namespace InsanmarTec.Domain.Shared
{
    public class ContentDirectoryFinder
    {
        public static string CalculateContentRootFolder(string presentationProject)
        {
            var domainAssemblyDirectoryPath = Path.GetDirectoryName(typeof(DomainModule).Assembly.Location)
                ?? throw new Exception("Could not find location of InsanmarTec.Domain assembly!");

            var directoryInfo = new DirectoryInfo(domainAssemblyDirectoryPath);
            while (!DirectoryContains(directoryInfo.FullName, "InsanmarTec.sln"))
            {
                if (directoryInfo.Parent is null)
                    throw new Exception("Could not find content root folder!");

                directoryInfo = directoryInfo.Parent;
            }

            var entryProjectFolder = Path.Combine(directoryInfo.FullName, "src", presentationProject);
            if (Directory.Exists(entryProjectFolder))
                return entryProjectFolder;

            throw new Exception("Could not find root folder of the presentation project!");
        }

        private static bool DirectoryContains(string directory, string fileName) =>
            Directory.GetFiles(directory).Any(filePath => string.Equals(Path.GetFileName(filePath), fileName));
    }
}
