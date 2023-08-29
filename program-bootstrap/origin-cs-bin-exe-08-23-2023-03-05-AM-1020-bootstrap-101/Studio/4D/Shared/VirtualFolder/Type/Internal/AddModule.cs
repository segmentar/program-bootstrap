using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public VirtualFolder AddModule(String name, Int32 count)
        {
            VirtualFolder virtualFolderResult = default;

            var descriptor__MODULE__ENTRY__descriptor = String.Empty;

            var descriptor__MODULE__DEFAULT_descriptor = String.Empty;

            switch (count)
            {
                case 1:
                    descriptor__MODULE__ENTRY__descriptor = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionFirst First" + ';'
                    });
                    break;

                case 2:
                    descriptor__MODULE__ENTRY__descriptor = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionSecond Second" + ';'
                    });
                    break;

                case 3:
                    descriptor__MODULE__ENTRY__descriptor = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionSecond Second" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionThird Third" + ';'
                    });
                    break;

                case 4:
                    descriptor__MODULE__ENTRY__descriptor = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionSecond Second" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionThird Third" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionFourth Fourth" + ';'
                    });
                    break;

                case 5:
                    descriptor__MODULE__ENTRY__descriptor = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionSecond Second" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionThird Third" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionFourth Fourth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {name}ModuleFunctionFifth Fifth" + ';'
                    });
                    break;

                default:
                    break;
            }

            switch (count)
            {
                case 1:
                    descriptor__MODULE__DEFAULT_descriptor = String.Join('\n'.ToString(),  new String[] {
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionOne(module)" + ';'
                    });
                    break;

                case 2:
                    descriptor__MODULE__DEFAULT_descriptor = String.Join('\n'.ToString(), new String[] {
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionTwo(module)" + ';'
                    });
                    break;

                case 3:
                    descriptor__MODULE__DEFAULT_descriptor = String.Join('\n'.ToString(), new String[] {
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionTwo(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionThree(module)" + ';'
                    });
                    break;

                case 4:
                    descriptor__MODULE__DEFAULT_descriptor = String.Join('\n'.ToString(), new String[] {
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionTwo(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionThree(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionFour(module)" + ';'
                    });
                    break;

                case 5:
                    descriptor__MODULE__DEFAULT_descriptor = String.Join('\n'.ToString(), new String[] {
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionTwo(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionThree(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionFour(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {name}ModuleFunctionFive(module)" + ';'
                    });
                    break;

                default:
                    break;
            }

            var descriptor__MODULE__ENTRY = String.Join('\n'.ToString(), new String[] {
                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial struct {name}Module",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + "internal Object Object" + ';',
                String.Empty,
                String.Empty + descriptor__MODULE__ENTRY__descriptor,
                String.Empty,
                String.Empty + '\t' + '}',
                String.Empty + '}',
            });

            var descriptor__MODULE__DEFAULT = String.Join('\n'.ToString(), new String[] { 
                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial struct {name}Module",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal static {name}Module {name}ModuleDefault" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + $"{name}Module module" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"module = new {name}Module()" + ';',
                String.Empty,
                String.Empty + descriptor__MODULE__DEFAULT_descriptor,
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return module" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            
            });

            var module = AddFolder($"{name}Module");

            var module_DEFAULT = module.AddFolder("Default");   

            var module_FUNCTION = module.AddFolder("Function");

            switch (count)
            {
                case 1:
                    module_FUNCTION.AddFolder("01");
                    break;

                case 2:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    break;

                case 3:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    module_FUNCTION.AddFolder("03");
                    break;

                case 4:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    module_FUNCTION.AddFolder("03");
                    module_FUNCTION.AddFolder("04");
                    break;

                case 5:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    module_FUNCTION.AddFolder("03");
                    module_FUNCTION.AddFolder("04");
                    module_FUNCTION.AddFolder("05");
                    break;

                default:
                    break;
            }

            var ordinal = 1;

            foreach (VirtualFolder virtualFolder in VirtualFolderFolderSetSurface(module_FUNCTION))
            {
                String number, numberth;

                number = default;

                numberth = default;

                switch (ordinal)
                {
                    case 1:
                        number = "One";
                        numberth = "First";
                        break;

                    case 2:
                        number = "Two";
                        numberth = "Second";
                        break;

                    case 3:
                        number = "Three";
                        numberth = "Third";
                        break;

                    case 4:
                        number = "Four";
                        numberth = "Fourth";
                        break;

                    case 5:
                        number = "Five";
                        numberth = "Fifth";
                        break;

                    default:
                        break;
                }

                var descriptor_NUMBER = String.Join('\n'.ToString(), new String[] { 
                    String.Empty + "using" + ' ' + "Core" + ';',
                    String.Empty,
                    String.Empty + "namespace" + ' ' + "Core",
                    String.Empty + '{',
                    String.Empty + '\t' + "using" + ' ' + "System" + ';',
                    String.Empty,
                    String.Empty + '\t' + $"internal partial struct {name}Module",
                    String.Empty + '\t' + '{',
                    String.Empty + '\t' + '\t' + $"internal static {name}Module {name}ModuleFunction{number}" + '(' + $"{name}Module module" + ')',
                    String.Empty + '\t' + '\t' + '{',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '\t' + $"{name}ModuleFunction{numberth} {numberth}" + ';',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '\t' + $"{numberth} = new {name}ModuleFunction{numberth}()" + ';',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '\t' + $"module.{numberth} = {numberth}" + ';',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '\t' + "return module" + ';',
                    String.Empty + '\t' + '\t' + '}',
                    String.Empty + '\t' + '}',
                    String.Empty + '}'
                });

                var descriptor_NUMBERTH = String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + "using" + ' ' + "Core" + ';',
                    String.Empty,
                    String.Empty + "namespace" + ' ' + "Core",
                    String.Empty + '{',
                    String.Empty + '\t' + "using" + ' ' + "System" + ';',
                    String.Empty,
                    String.Empty + '\t' + $"internal partial class {name}ModuleFunction{numberth}",
                    String.Empty + '\t' + '{',
                    String.Empty,
                    String.Empty + '\t' + '\t' + $"internal {name}ModuleFunction{numberth}" + '(' + ')',
                    String.Empty + '\t' + '\t' + '{',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                    String.Empty + '\t' + '\t' + '}',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '~' + $"{name}ModuleFunction{numberth}" + '(' + ')',
                    String.Empty + '\t' + '\t' + '{',
                    String.Empty,
                    String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                    String.Empty + '\t' + '\t' + '}',
                    String.Empty + '\t' + '}',
                    String.Empty + '}'
                });

                var folder_NUMBER = virtualFolder.AddFolder(number);

                var folder_NUMBERTH = virtualFolder.AddFolder(numberth);

                var file_NUMBER = folder_NUMBER.AddFile($"{name}ModuleFunction{number}", "cs", descriptor_NUMBER);

                var file_NUMBERTH = folder_NUMBERTH.AddFile($"{name}ModuleFunction{numberth}", "cs", descriptor_NUMBERTH);

                ordinal = ordinal + 1;

                continue;
            }

            var module__MODULE__ENTRY = module.AddFile($"{name}Module", "cs", descriptor__MODULE__ENTRY);

            var module__MODULE__DEFAULT = module_DEFAULT.AddFile($"{name}ModuleDefault", "cs", descriptor__MODULE__DEFAULT);

            virtualFolderResult = module;

            return virtualFolderResult;
        }
    }
}