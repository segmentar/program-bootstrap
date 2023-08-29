using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class VirtualFolder
    {
        public static IList<Object> VirtualFolderTraverseSet(VirtualFolder[] virtualFolderArray)
        {
            ICollection<Object> collectionResult = default;

            collectionResult = new Collection<Object>();

            foreach (VirtualFolder virtualFolder in virtualFolderArray)
            {
                if (Directory.Exists(virtualFolder.FullName) is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(virtualFolder.FullName);

                collectionResult.Add(virtualFolder);

                continue;
            }

            foreach (VirtualFolder virtualFolder in virtualFolderArray)
            {
                var array = VirtualFolderFileSetSurface(virtualFolder);

                foreach (VirtualFile virtualFile in array)
                {
                    if (File.Exists(virtualFile.Filename) is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    FileStream fileStream;

                    fileStream = File.Create(virtualFile.Filename);

                    using (fileStream)
                    {
                        fileStream.Write(virtualFile.ContentByteArray, 0, virtualFile.ContentByteArray.Length);

                        fileStream.Flush();

                        fileStream.Close();

                        fileStream.Dispose();
                    }

                    collectionResult.Add(virtualFile);

                    continue;
                }

                continue;
            }

            return new List<Object>(collectionResult);
        }
    }
}
