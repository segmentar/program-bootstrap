using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public String ClassificationStaticDescriptor(String name)
        {
            String stringResult = default;

            stringResult = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + "internal partial class Program",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + "internal static String[] ArgumentArray" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + "internal static void Main" + '(' + "params String[] array_ARGUMENT" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "ArgumentArray = array_ARGUMENT" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "Bundle()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + "internal static void Procedure" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + "internal static void Manual" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + "internal static void Raise" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + "internal static void Bundle" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "Procedure()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "Manual()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "Raise()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + "static Program" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            return stringResult;
        }
    }
}
