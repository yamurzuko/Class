using System;

namespace ClassConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*
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
*/
            Student student1 = new Student("UğurCan", "Yağmur", 43523, 12);
            student1.StudentInformation();
            student1.SınıfAtlat();
            student1.StudentInformation();

        }
    }
/*
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
*/  

    class Student
    {
        private string name;
        private string surname;
        private int no;
        private int sınıf;

        public Student(){}
        public Student(string name, string surname, int no , int sınıf)
        {
            Name = name;
            Surname = surname;
            No = no;
            Sınıf = sınıf;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int No { get => no; set => no = value; }
        public int Sınıf { get => sınıf; set => sınıf = value; }

        public void StudentInformation()
        {
            Console.WriteLine("Öğrencinin Adı: {0}", this.Name);
            Console.WriteLine("Öğrencinin Soyadı: {0}", this.Surname);
            Console.WriteLine("Öğrencinin Numarası: {0}", this.No);
            Console.WriteLine("Öğrencinin Sınıfı: {0}", this.Sınıf);
            Console.WriteLine("******************");
        }

        public void SınıfAtlat()
        {
            this.Sınıf = this.Sınıf + 1;
        }

    }
    
}