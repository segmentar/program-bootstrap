using Core;

namespace Core
{
    using System;

    using System.Text;

    internal static class Architecture
    {
        internal static String ApplicationName;

        internal static ProgramCode.ApplicationType ApplicationType;

        internal static String ApplicationVersion;

        internal static String WorkingDirectoryName;

        internal static Boolean IncludeStudioDirectory;

        internal static StringBuilder ClassStringBuilder;

        internal static StringBuilder ModuleStringBuilger;

        internal static StringBuilder IconStringBuilder;

        static Architecture()
        {
            ApplicationName = "Sample";

            ApplicationType = ProgramCode.ApplicationType.BinaryPortableExecutable;

            ApplicationVersion = "101";

            WorkingDirectoryName = "Working Directory";

            IncludeStudioDirectory = false;

            ClassStringBuilder = new StringBuilder("Classification list" + ':');

            ModuleStringBuilger = new StringBuilder("Modulation list" + ':');

            IconStringBuilder = new StringBuilder("Icon list" + ':');
        }
    }
}
