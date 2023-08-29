using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.Diagnostics;

    public partial class VirtualFilesystem
    {
        public void OpenExplorer(String path, Int32 ordinal)
        {
            if ((ordinal > 5) is true)
            {
                return;
            }
            else
                "false".ToString();

            ProcessStartInfo processStartInfo;

            processStartInfo = new ProcessStartInfo("explorer", path);

            Process process;

            process = new Process();

            process.StartInfo = processStartInfo;

            using (process)
            {
                if (process.Start())
                {
                    goto skip;
                }
                else
                {
                    OpenExplorer(path, (ordinal + 1));
                }

                skip:
                {
                    process.Close();

                    process.Dispose();
                }
            }

            return;
        }
    }
}
