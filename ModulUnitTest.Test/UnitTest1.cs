using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;


namespace UnitTestExample.Test
{
    [TestClass]
    public class UnitTest1
    {

        private const string SolutionFilePath = "E:\\IQOS-Modul\\IQOS-Modul\\licitFinal\\licitFinal.sln";

        [TestMethod]

        public void SolutionFileExists()
        {
            Assert.IsTrue(File.Exists(SolutionFilePath), "Solution file should exist at the specified location.");
        }

        public void SolutionFileContainsExpectedProjects()
        {
            string solutionFileContent = File.ReadAllText(SolutionFilePath);

            
            Assert.IsTrue(solutionFileContent.Contains("Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") = \"licitFinal\", \"licitFinal\\licitFinal.csproj\", \"{4130D773-4930-4C21-9BCF-0C5244F585D0}\""));
        }

        public void SolutionFileHasValidConfigurations()
        {
            string solutionFileContent = File.ReadAllText(SolutionFilePath);

            Assert.IsTrue(solutionFileContent.Contains("Debug|Any CPU"));
            Assert.IsTrue(solutionFileContent.Contains("Release|Any CPU"));
        }

    }
}
