using System;

namespace static_class
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Çalışan Sayısı: {0}",Employee._numberOfEmployees);
            Employee emp1 = new Employee("Yusuf Tolunay","Çağlar","EEM");
            System.Console.WriteLine("Çalışan Sayısı: {0}",Employee._numberOfEmployees);
            emp1.Personal();
            Employee emp2 = new Employee("Ahmet","Kar","IK");
            System.Console.WriteLine("Çalışan Sayısı: {0}",Employee._numberOfEmployees);
            emp2.Personal();

            System.Console.WriteLine(Operation.Add(50,20));
            System.Console.WriteLine(Operation.Subtract(50,20));




        }
    }

    class Employee
    {
        // static objeler veya property'ler direk class üzerinden kullanılır.
        // static class'ın elemanlarıda mutlaka static olmalıdır.
        public static int _numberOfEmployees;
        private string _Name;
        private string _Surname;
        private string _Department;

        public Employee(string name, string surname, string department)
        {
            _Name = name;
            _Surname = surname;
            _Department = department;
            _numberOfEmployees++;
        }

        public static int NumberOfEmployees { get => _numberOfEmployees;}

        public void Personal(){
            System.Console.WriteLine("-- Çalısan Bilgileri --");
            System.Console.WriteLine("Çalısan Adı: {0}",_Name);
            System.Console.WriteLine("Çalısan Soyadı: {0}",_Surname);
            System.Console.WriteLine("Çalısan Departman: {0}",_Department);
        }
    }

    public static class Operation
    {
        public static int Add(int sayi1, int sayi2){
            return sayi1+sayi2;
        }

        public static int Subtract(int sayi1, int sayi2){
            return sayi1-sayi2;
        }
    }
}