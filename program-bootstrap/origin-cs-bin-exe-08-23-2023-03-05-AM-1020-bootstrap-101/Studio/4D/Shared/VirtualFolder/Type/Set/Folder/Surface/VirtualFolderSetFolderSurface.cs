using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public static VirtualFolder[] VirtualFolderFolderSetSurface(VirtualFolder virtualFolder)
        {
            VirtualFolder[] arrayResult = default;

            var list = VirtualFolderFolderSet(virtualFolder);

            VirtualFolder[] virtualFolderArray;

            virtualFolderArray = new VirtualFolder[list.Count];

            list.CopyTo(virtualFolderArray, 0);

            arrayResult = virtualFolderArray;

            return arrayResult;
        }
    }
}
