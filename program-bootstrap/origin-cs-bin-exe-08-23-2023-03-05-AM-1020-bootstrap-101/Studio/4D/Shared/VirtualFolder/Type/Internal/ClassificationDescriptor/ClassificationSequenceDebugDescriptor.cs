using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public String ClassificationSequenceDebugDescriptor(String name)
        {
            String stringResult = default;

            stringResult = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {name}Sequence",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + "internal static void Debug" + '(' + "Boolean debug" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "if (debug is true)",
                String.Empty + '\t' + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + '\t' + "var descriptor = String.Join('\\n'.ToString(), new String[] {",
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + $"String.Empty + nameof({name}) + ' ' + \"::\" + ' ' + nameof({name}Sequence) + ' ' + '{{'" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + "String.Empty + '.' + \"debug\"" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + "String.Empty + '\\t' + '~' + \"01\" + ' ' + nameof(debug) + ':' + ' ' + debug" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + "String.Empty + '}'",
                String.Empty + '\t' + '\t' + '\t' + '\t' + "})" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + "Console.Clear()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + "Console.Out.WriteLine(descriptor)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + "Console.In.ReadLine()" + ';',
                String.Empty + '\t' + '\t' + '\t' + '}',
                String.Empty + '\t' + '\t' + '\t' + "else",
                String.Empty + '\t' + '\t' + '\t' + '\t' + "\"false\".ToString()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            return stringResult;
        }
    }
}
