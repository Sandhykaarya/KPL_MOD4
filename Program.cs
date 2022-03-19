using System;

namespace modul4_1302204002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<float> sd = new SimpleDataBase<float>();

            sd.simpleDataBase();
            sd.addNewData(13);
            sd.addNewData(02);
            sd.addNewData(20);
            sd.printAllData();
        }
    }

    public class SimpleDataBase<T>
    {
        public List<T> storedData;
        public List<DateTime> inputDates = new List<DateTime>();
        int i = -1;

        public void simpleDataBase()
        {
            storedData = new List<T>();
        }

        public void addNewData(T data)
        { 
            i++;
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for(int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + " yang disimpan pada waktu " + inputDates[0]);
            }
        }
    }
}