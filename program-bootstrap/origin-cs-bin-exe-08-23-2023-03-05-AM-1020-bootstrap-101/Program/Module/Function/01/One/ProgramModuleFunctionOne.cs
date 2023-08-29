using Core;

namespace Core
{
    using System;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleFunctionOne(ProgramModule module)
        {
            var tuple = module.Program.CurrentTuple__FILE_FOLDER();

            String workingDirectory;

            workingDirectory = module.Program.WorkingDirectory(tuple.Item2);

            ProgramModuleFunctionFirst first;

            first = new ProgramModuleFunctionFirst(tuple.Item1, tuple.Item2, workingDirectory);

            module.First = first;

            return module;
        }
    }
}
