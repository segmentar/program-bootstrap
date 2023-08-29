using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.Text;

    public partial class VirtualFilesystem
    {
        public static VirtualFilesystem MakeVirtualFilesystemDefaultSurface(Encoding encoding, VirtualFolder virtualFolder)
        {
            VirtualFilesystem virtualFilesystemResult = default;

            virtualFilesystemResult = MakeVirtualFilesystemDefault(encoding, virtualFolder, VirtualFilesystemPolicy.VirtualFilesystemDebugPolicy);

            return virtualFilesystemResult;
        }
    }
}
