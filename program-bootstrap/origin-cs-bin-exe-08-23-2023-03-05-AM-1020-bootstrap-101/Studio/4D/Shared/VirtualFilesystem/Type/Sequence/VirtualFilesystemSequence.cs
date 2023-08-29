using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.Text;

    public partial class VirtualFilesystemSequence
    {
        public VirtualFilesystem Result { get; set; } = default;

        public VirtualFilesystemSequence(Encoding encoding, VirtualFolder virtualFolder, Boolean debug)
        {
            Debug(encoding, virtualFolder, debug);

            VirtualFilesystem virtualFilesystem;

            virtualFilesystem = new VirtualFilesystem(encoding, virtualFolder, debug);

            this.Result = virtualFilesystem;

            return;
        }

        ~VirtualFilesystemSequence()
        {
            return;
        }
    }
}
