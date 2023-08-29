using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.IO;

    public partial class VirtualFolder
    {
        public VirtualFolder AddFolder(String name)
        {
            VirtualFolder virtualFolderResult = default;

            var path_DIRECTORY_full_name = Path.Combine(FullName, name);

            VirtualFolder virtualFolder;

            virtualFolder = new VirtualFolderSimple(path_DIRECTORY_full_name).Result;

            FilesystemEntryArrayList.Add(virtualFolder);

            virtualFolderResult = virtualFolder;

            return virtualFolderResult;
        }
    }
}
