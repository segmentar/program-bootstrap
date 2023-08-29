using Core;

namespace Core
{
    using System;

    internal partial class ProgramModuleFunctionFirst
    {
        internal String CurrentFile;

        internal String CurrentFolder;

        internal String WorkingDirectory;

        public ProgramModuleFunctionFirst(String currentFile, String currentFolder, String workingDirectory)
        {
            this.CurrentFile = currentFile;

            this.CurrentFolder = currentFolder;

            this.WorkingDirectory = workingDirectory;

            return;
        }

        ~ProgramModuleFunctionFirst()
        {
            return;
        }
    }
}
