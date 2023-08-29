using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public static VirtualFile[] VirtualFolderFileSetSurface(VirtualFolder virtualFolder)
        {
            VirtualFile[] arrayResult = default;

            var list = VirtualFolderFileSet(virtualFolder);

            VirtualFile[] virtualFileArray;

            virtualFileArray = new VirtualFile[list.Count];

            list.CopyTo(virtualFileArray, 0);   

            arrayResult = virtualFileArray;

            return arrayResult;
        }
    }
}
