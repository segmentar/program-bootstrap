using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static IList<Tuple<String, String, String>> ProgramClassTupleSet(String[] split)
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

                Int32 one, two, three;

                one = (indexer + 0);

                two = (indexer + 1);

                three = (indexer + 2);

                var first = split[one];

                var second = split[two];

                var third = split[three];

                var split_FIRST = first.Split();

                var split_LAST = third.Split();

                String firstLast, lastFirst;

                firstLast = split_FIRST[split_FIRST.Length - 1];

                lastFirst = split_LAST[0];

                if ((firstLast == "class") is true)
                {
                    Tuple<String, String, String> classTuple;

                    classTuple = new Tuple<String, String, String>(firstLast, second, lastFirst);

                    collectionResult.Add(classTuple);
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
