using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Indexer
            SampleIndexer sampleIndexer = new SampleIndexer();
            Console.WriteLine(sampleIndexer[3]);

            
        }
    }
    class SampleIndexer
    {
        string[] list = new string[] { "Krishna", "Altaf", "Bharath", "RaviTeja", "Manjeet", "Praveen" };
        public string this[int indx]
        {
            get
            {
                if (indx > 0 && indx < list.Length)
                {
                    return list[indx];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index Out Of Range");
                }
            }
            set
            {
                list[indx] = value;
            }

        }


    }
}
