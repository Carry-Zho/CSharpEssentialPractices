using System.Collections;

namespace Practice_Test_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Patent> patents = PatentData.Patents;
            //patents = patents.Where(patent => patent.YearOfPublication.StartsWith("18"));
            //Print(patents);

            bool result;
            patents = patents.Where(
                                    patent =>
                                             {
                                                if (result = patent.YearOfPublication.StartsWith("18"))
                                                {
                                                     //谓词中的副作用演示
                                                     //实际编码中应避免
                                                     Console.WriteLine("谓词带副作用->输出数据到控制台:"+ patent);
                                                }
                                                return result;
                                              }
                                    );

            Console.WriteLine("1. 用Print打印1900 patents:"); //放在Lambda后面但先于Lambda执行,说明“Lambda表达式在声明时并不执行”
            //首先，foreach循环触发了Lambda表达式的执行。foreach循环被分解成MoveNext()调用，
            //针对原始集合中的每一项执行一次Lambda表达式。
            Print(patents);
            Console.WriteLine();

            Console.WriteLine("2. 用foreach空语句遍历 patents:");
            //即使foreach空语句遍历，依然会触发了Lambda表达式的执行。foreach循环被分解成MoveNext()调用，
            //针对原始集合中的每一项执行一次Lambda表达式。
            foreach (Patent patent in patents) { } 
            Console.WriteLine();


            //其次，调用Enumerable的Count()函数，会再次为原始集合每一项触发Lambda表达式。 
            Console.WriteLine("3. 对patents进行计数:");
            Console.WriteLine($@"There are {patents.Count()} patents prior to 1900.");
            Console.WriteLine();

            //最后，调用ToArray()（或ToList、ToDictionary、ToLookup）会再为原始集合每一项触发Lambda表达式。
            Console.WriteLine("4. 对patents进行ToArray转换:");
            patents = patents.ToArray();

            //综上，向查询要结果时，整个查询才会执行（甚至可能是再次执行），
            //因为查询对象不确定查询结果和上次执行的结果（如果存在的话）是不是一样。

            //“ToXXX”方法会创建基础数据的“快照”，所以基于“ToXXX”方法的结果再查询时，不会返回原始集合新的增量/减量集合项。
            //即使用快照数据，不再涉及对原始集合的查询
            Console.WriteLine(@"5. 使用“ToXXX”方法将查询数据缓存赋给一个局部集合后，对已赋好值的缓存集合进行遍历，不会触发原始查询表达式。");
            Console.WriteLine($@"There are {patents.Count()} patents prior to 1900.");
            foreach (Patent patent in patents) { }
            foreach (Patent patent in patents) { }
            Console.WriteLine($@"There are {((Array)patents).Length} patents prior to 1900.");

        }

        private static void Print<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}