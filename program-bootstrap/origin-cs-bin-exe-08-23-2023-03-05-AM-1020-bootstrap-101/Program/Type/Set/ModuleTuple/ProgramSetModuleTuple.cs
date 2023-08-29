using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static IList<Tuple<String, String, String>> ProgramModuleTupleSet(String[] split)
        {
            ICollection<Tuple<String, String, String>> collectionResult = default;

            collectionResult = new Collection<Tuple<String, String, String>>();

            var indexer = 0;

            do
            {
                if (((indexer + 2) >= split.Length) is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var left = split[indexer];

                var middle = split[indexer + 1];

                var right = split[indexer + 2];

                var split_LEFT = left.Split();

                var split_RIGHT = right.Split();

                String leftLast, rightFirst;

                leftLast = split_LEFT[split_LEFT.Length - 1];

                rightFirst = split_RIGHT[0];

                if ((leftLast == "module") is true)
                {
                    Tuple<String, String, String> moduleTuple;

                    moduleTuple = new Tuple<String, String, String>(leftLast, middle, rightFirst);

                    collectionResult.Add(moduleTuple);
                }
                else
                    "false".ToString();

                indexer = indexer + 1;

                continue;

            } while (true);

            return new List<Tuple<String, String, String>>(collectionResult);
        }
    }
}
