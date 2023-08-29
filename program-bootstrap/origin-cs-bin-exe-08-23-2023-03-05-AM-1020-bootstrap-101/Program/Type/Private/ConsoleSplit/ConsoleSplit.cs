using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private void ConsoleSplit(String value)
        {
            var split = value.Split();

            var match_length__ZERO_TEN__two = (split.Length == 2) is true;

            var match_length__ZERO_TEN__three = (split.Length == 3) is true;

            var match_length__ZERO_TEN__six = (split.Length == 6) is true;

            Boolean 
                firstIsApplicationName,
                firstIsApplicationType,
                firstIsApplicationVersion, 
                firstIsIncludeStudioDirectory,
                firstIsClassification, 
                firstIsModulation,
                firstIsIcon
                ;

            if (match_length__ZERO_TEN__two is true)
            {
                var first = split[0];

                var second = split[1];

                String firstLower;

                firstLower = first.ToLower();

                firstIsApplicationName = (first == nameof(Architecture.ApplicationName)) is true;

                firstIsApplicationType = (first == nameof(Architecture.ApplicationType)) is true;

                firstIsApplicationVersion = (first == nameof(Architecture.ApplicationVersion)) is true;

                firstIsIncludeStudioDirectory = (first == nameof(Architecture.IncludeStudioDirectory)) is true;

                if (firstIsApplicationName is true)
                {
                    Architecture.ApplicationName = second;
                }
                else
                    "false".ToString();

                if (firstIsApplicationType is true)
                {
                    switch (second)
                    {
                        case nameof(ProgramCode.ApplicationType.BinaryPortableExecutable):
                            Architecture.ApplicationType = ProgramCode.ApplicationType.BinaryPortableExecutable;
                            break;

                        case nameof(ProgramCode.ApplicationType.LibraryDynamicLinkLibrary):
                            Architecture.ApplicationType = ProgramCode.ApplicationType.LibraryDynamicLinkLibrary;
                            break;

                        default:
                            break;
                    }
                }
                else
                    "false".ToString();

                if (firstIsApplicationVersion is true)
                {
                    Architecture.ApplicationVersion = second;
                }
                else
                    "false".ToString();

                if (firstIsIncludeStudioDirectory is true)
                {
                    var parse = Boolean.Parse(second);

                    Architecture.IncludeStudioDirectory = parse;
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            if (match_length__ZERO_TEN__three is true)
            {
                var first = split[0];

                var second = split[1];

                var third = split[2];

                String firstLower;

                firstLower = first.ToLower();

                firstIsClassification = (firstLower == "add-classification") is true;

                firstIsModulation = (firstLower == "add-modulation") is true;

                if (firstIsClassification is true)
                {
                    var separator = String.Empty;

                    separator = separator + '\n';

                    separator = separator + '\t';

                    separator = separator + $"class-{second}-{third}";

                    Architecture.ClassStringBuilder.Insert(Architecture.ClassStringBuilder.Length, separator);
                }
                else
                    "false".ToString();

                if (firstIsModulation is true)
                {
                    var separator = String.Empty;

                    separator = separator + '\n';

                    separator = separator + '\t';

                    separator = separator + $"module-{second}-{third}";

                    Architecture.ModuleStringBuilger.Insert(Architecture.ModuleStringBuilger.Length, separator);
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            if (match_length__ZERO_TEN__six is true)
            {
                var first = split[0];

                var second = split[1];

                var third = split[2];

                var fourth = split[3];

                var fifth = split[4];

                var sixth = split[5];

                firstIsIcon = (first == "add-icon") is true;

                if (firstIsIcon is true)
                {
                    var separator = String.Empty;

                    separator = separator + '\n';

                    separator = separator + '\t';

                    separator = separator + $"icon-{second}-{third}-{fourth}-{fifth}-{sixth}";

                    Architecture.IconStringBuilder.Insert(Architecture.IconStringBuilder.Length, separator);
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            return;
        }
    }
}
