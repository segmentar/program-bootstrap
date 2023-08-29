using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal static class Immutable
    {
        internal static readonly String ProgramName;

        internal static readonly Random ProgramRandom;

        internal static readonly String WorknigDirectoryIdentifier;

        static Immutable()
        {
            ProgramName = Assembly.GetEntryAssembly().GetName().Name;

            ProgramRandom = new Random(DateTime.Now.Millisecond);

            WorknigDirectoryIdentifier = Path.GetRandomFileName();

            return;
        }
    }
}
