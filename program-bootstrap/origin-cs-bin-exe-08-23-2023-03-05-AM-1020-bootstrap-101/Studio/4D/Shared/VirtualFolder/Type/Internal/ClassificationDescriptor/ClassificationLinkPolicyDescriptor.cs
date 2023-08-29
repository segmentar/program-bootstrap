using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public String ClassificationLinkPolicyDescriptor(String name)
        {
            String stringResult = default;

            stringResult = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + "using" + ' ' + "System" + '.' + "Collections" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {name}Policy",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal static ArrayList {name}ArrayList = new ArrayList()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + $"internal static Boolean {name}DebugPolicy = false" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + $"internal static Boolean {name}InfoPolicy = false" + ';',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            return stringResult;
        }
    }
}
