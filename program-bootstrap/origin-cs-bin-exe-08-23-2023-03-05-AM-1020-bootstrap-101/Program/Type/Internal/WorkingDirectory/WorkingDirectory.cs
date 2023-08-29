using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal String WorkingDirectory(String currentDirectory)
        {
            String stringResult = default;

            var path_NAME = $"{Architecture.WorkingDirectoryName}-{Immutable.ProgramName}-{Immutable.WorknigDirectoryIdentifier}";

            var split = path_NAME.Split(new String[] { ' '.ToString() }, StringSplitOptions.RemoveEmptyEntries);

            var join = String.Join('-'.ToString(), split);

            var path_NAME_lower = join.ToLower();

            var path_DIRECTORY_full_name = Path.Combine(currentDirectory, path_NAME_lower);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            stringResult = path_DIRECTORY_full_name;

            return stringResult;
        }
    }
}
