using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFilesystem
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 

                String.Empty + nameof(VirtualFilesystem) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(VirtualFileEncoding) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(VirtualFolderRoot) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(VirtualFileEncoding) + ':',
                String.Empty + VirtualFileEncoding,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(VirtualFolderRoot) + ':',
                String.Empty + VirtualFolderRoot
            });
        }
    }
}
