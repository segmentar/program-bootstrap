using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static IList<Tuple<String, String, String, String, String, String>> ProgramIconTupleSet(String[] split)
        {
            ICollection<Tuple<String, String, String, String, String, String>> collectionResult = default;

            collectionResult = new Collection<Tuple<String, String, String, String, String, String>>();

            var indexer = 0;

            do
            {
                var safe__ZERO_TEN__EQUAL_OR_MORE_THAN_four = ((indexer + 5) >= split.Length) is true;

                if (safe__ZERO_TEN__EQUAL_OR_MORE_THAN_four is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Int32 one, two, three, four, five, six;

                one = (indexer + 0);

                two = (indexer + 1);

                three = (indexer + 2);

                four = (indexer + 3);

                five = (indexer + 4);

                six = (indexer + 5);

                var first = split[one];

                var second = split[two];

                var third = split[three];

                var fourth = split[four];

                var fifth = split[five];

                var sixth = split[six];

                var split_FIRST = first.Split();

                var split_LAST = sixth.Split();

                String firstLast, lastFirst;

                firstLast = split_FIRST[split_FIRST.Length - 1];

                lastFirst = split_LAST[0];

                Boolean isIcon;

                isIcon = firstLast is "icon";

                if (isIcon is true)
                {
                    Tuple<String, String, String, String, String, String> iconTuple;

                    iconTuple = new Tuple<String, String, String, String, String, String>(firstLast, second, third, fourth, fifth, lastFirst);

                    collectionResult.Add(iconTuple);
                }
                else
                    "false".ToString();

                indexer = indexer + 1;

                continue;

            } while (true);

            return new List<Tuple<String, String, String, String, String, String>>(collectionResult);
        }
    }
}
