using System;

namespace ClassConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Ugur", "Yagmur", 34627, "İnsan Kaynaklari");
            worker1.Workers();
            Console.WriteLine("*************");

            Worker worker2 = new Worker();
            worker2.name = "ayşe";
            worker2.surname = "kaplan";
            worker2.no = 3834934;
            worker2.departman = "satin alma";
            worker2.Workers();
            Console.WriteLine("*************");

        }
    }
    class Worker
    {
        public string name;
        public string surname;
        public int no;
        public string departman;

        public Worker(){}
        public Worker(string name, string surname, int no, string departman)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
            this.departman = departman;
        }
        public void Workers()
        {
            Console.WriteLine("Çalişanin Adi: {0}", name);
            Console.WriteLine("Çalişanin Soyadi: {0}", surname);
            Console.WriteLine("Çalişanin Numarasi: {0}", no);
            Console.WriteLine("Çalişanin Departmani: {0}", departman);
        }
    }
}