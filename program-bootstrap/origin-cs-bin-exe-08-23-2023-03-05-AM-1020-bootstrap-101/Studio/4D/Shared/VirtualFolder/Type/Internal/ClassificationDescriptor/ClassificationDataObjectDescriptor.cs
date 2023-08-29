using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public String ClassificationDataObjectDescriptor(String name)
        {
            String stringResult = default;

            stringResult = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial struct {name}Data",
                String.Empty + '\t' + '{',
                String.Empty,
                String.Empty + '\t' + '\t' + "public override String ToString" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return String.Join('\\n'.ToString(), new String[] {",
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + $"String.Empty + nameof({name}) + ' ' + \"::\" + ' ' + nameof({name}Data) + ' ' + '{{'" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + "String.Empty + '.' + \"data\"" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + "String.Empty + '\\t' + '~' + \"01\" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + "String.Empty + '}'",
                String.Empty + '\t' + '\t' + '\t' + "})" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            return stringResult;
        }
    }
}
