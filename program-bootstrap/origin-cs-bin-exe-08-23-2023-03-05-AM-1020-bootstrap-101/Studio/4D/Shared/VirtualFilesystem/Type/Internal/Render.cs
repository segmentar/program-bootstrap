using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFilesystem
    {
        public void Render(Boolean openExplorer)
        {
            var array_FOLDER = VirtualFolder.VirtualFolderRecurseSetSurface(VirtualFolderRoot);

            var array_FILE = VirtualFolder.VirtualFolderTraverseSetSurface(array_FOLDER);

            if (openExplorer is true)
            {
                OpenExplorer(VirtualFolderRoot.FullName, 1);
            }
            else
                "false".ToString();

            return;
        }
    }
}
