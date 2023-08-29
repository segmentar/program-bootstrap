using Core;

using Core.Shared;

namespace Core
{
    using System;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleDefault()
        {
            Program program;

            program = Program.MakeProgramDefaultSurface();

            program.ConsoleSetup();

            ProgramModule module;

            module = new ProgramModule();

            module.Program = program;

            module = ProgramModuleFunctionOne(module);

            program.BuildTemplate(module.First.WorkingDirectory);

            return module;
        }
    }
}
