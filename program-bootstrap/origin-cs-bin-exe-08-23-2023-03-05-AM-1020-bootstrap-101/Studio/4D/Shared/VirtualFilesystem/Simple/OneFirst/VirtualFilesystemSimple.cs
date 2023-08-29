using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFilesystemSimple
    {
        public VirtualFilesystem Result { get; set; } = default;

        public VirtualFilesystemSimple()
        {
            return;
        }

        ~VirtualFilesystemSimple()
        {
            return;
        }
    }
}

namespace Core.Shared
{
    using System;

    using System.Text;

    public partial class VirtualFilesystemSimple
    {
        public VirtualFilesystemSimple(VirtualFolder virtualFolder)
        {
            VirtualFilesystem virtualFilesystem;

            virtualFilesystem = VirtualFilesystem.MakeVirtualFilesystemDefaultSurface(Encoding.Default, virtualFolder);

            this.Result = virtualFilesystem;

            return;
        }
    }
}