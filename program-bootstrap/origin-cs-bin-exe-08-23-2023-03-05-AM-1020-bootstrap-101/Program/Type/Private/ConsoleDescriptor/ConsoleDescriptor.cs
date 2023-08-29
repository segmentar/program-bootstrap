using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private String ConsoleDescriptor()
        {
            String stringResult = default;

            var join = String.Join('\n'.ToString(), new String[] {
                    String.Empty,
                    String.Empty + '\t' + 'O' + ' ' + $"This is called {Immutable.ProgramName}" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + 'o' + ' ' + "Write <variable-name> <variable-value> to modify a variable" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + 'o' + ' ' + "Write `escape` to run and exit" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(Architecture.ApplicationName) + ':' + ' ' + Architecture.ApplicationName,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(Architecture.ApplicationType) + ':' + ' ' + Architecture.ApplicationType,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(Architecture.ApplicationVersion) + ':' + ' ' + Architecture.ApplicationVersion,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(Architecture.IncludeStudioDirectory) + ':' + ' ' + Architecture.IncludeStudioDirectory,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(Architecture.ApplicationType) + ' ' + $"{{ {String.Join(", ", Enum.GetNames(typeof(ProgramCode.ApplicationType)))} }}",
                    String.Empty,
                    String.Empty + '\t' + '-' + ' ' + "add-classification" + ' ' + "<classification-name>" + ' ' + "<entry-boolean>",
                    String.Empty,
                    String.Empty + '\t' + '-' + ' ' + "add-modulation" + ' ' + "<modulation-name>" + ' ' + "<modulation-count>",
                    String.Empty,
                    String.Empty + '\t' + '-' + ' ' + "add-icon" + ' ' + "<icon-name>" + ' ' + "<foreground-color>" + ' ' + "<background-color>" + ' ' + "<impact-float>" + ' ' + "<scale-even-divisor>",
                    String.Empty,
                    String.Empty + '\t' + "Prompt" + ':' + ' ',
                    String.Empty,
                    String.Empty + '\t' + Architecture.ClassStringBuilder,
                    String.Empty,
                    String.Empty + '\t' + Architecture.ModuleStringBuilger,
                    String.Empty,
                    String.Empty + '\t' + Architecture.IconStringBuilder
                });

            stringResult = join;

            return stringResult;
        }
    }
}
