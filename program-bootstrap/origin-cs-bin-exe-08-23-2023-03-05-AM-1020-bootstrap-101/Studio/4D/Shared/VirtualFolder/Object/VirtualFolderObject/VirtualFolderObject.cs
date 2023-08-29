using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
                String.Empty + nameof(VirtualFolder) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ':' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(FullName) + ':' + ' ' + FullName,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(FilesystemEntryArrayList) + ':' + ' ' + ". . ." + ' ' + $"<{FilesystemEntryArrayList.Count}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FilesystemEntryArrayList) + ':',
                String.Empty + String.Join('\n'.ToString(), FilesystemEntryArrayList)
            });
        }
    }
}
