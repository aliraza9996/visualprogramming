using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication4
{
    public class student
    {
        string enrollment;
        string name;
        string semester;
        string cgpa;
        string department;
        string university;
        string path = "C://Users/Ali/Desktop/data.txt";
        string attendance = "null";
        public string enrollmentFunction 
        {
            get
            {
                return enrollment;
            }
            set
            {
                enrollment = value;
            }
        }
        public string nameFunction
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string semesterFunction
        {
            get
            {
                return semester;
            }
            set
            {
                semester = value;
            }
        }
        public string cgpaFuntion
        {
            get
            {
                return cgpa;
            }
            set
            {
                cgpa = value;
            }
        }
        public string departmentFunction
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public string universityFunction
        {
            get
            {
                return university;
            }
            set
            {
                university = value;
            }
        }
        public string attendanceFunction
        {
            get
            {
                return attendance;
            }
            set
            {
                attendance=value;
            }
                
        }

       public void addStudent()
        {
            Console.WriteLine("Please enter student ID:");
            enrollment = Console.ReadLine();
            Console.WriteLine("Please enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter Semester");
            semester = Console.ReadLine();
            Console.WriteLine("Please enter CGPA");
            cgpa = Console.ReadLine();
            Console.WriteLine("Please enter Department");
            department = Console.ReadLine();
            Console.WriteLine("Please enter University");
            university = Console.ReadLine();
            string[] str = { enrollment, name, semester, cgpa, department, university, attendance };
            File.AppendAllLines(path, str);

        }
       public void searchStudent()
        {
          
        }
       public void delete()
        {
            string id;
            Console.WriteLine("Please enter the ID");
            id = Console.ReadLine();


        }

    }
                                 
    class Program
    {
        void read()
        {

        }
        //string path = "C://Users/Ali/Desktop/data.txt";
        static void Main(string[] args)
        {
            int temp;
            string path="C://Users/Ali/Desktop/data.txt";
            string[] data;
            int students;
            data = File.ReadAllLines("C://Users/Ali/Desktop/data.txt");
            temp = data.Length;
            students = temp / 7;
            Console.WriteLine("No of students = " + students);
            student[] obj = new student[students];
            int count = 0;
            for (int i = 0; i < students&&count!=temp; i++)
            {
                
                obj[i] = new student();
                obj[i].enrollmentFunction = data[count];
                count++;
                obj[i].nameFunction = data[count];
                count++;
                obj[i].semesterFunction = data[count];
                count++;
                obj[i].cgpaFuntion = data[count];
                count++;
                obj[i].departmentFunction = data[count];
                count++;
                obj[i].universityFunction = data[count];
                count++;
                obj[i].attendanceFunction = data[count];
                count++;    
                Console.WriteLine(obj[0].attendanceFunction);       
            }

            char ch = 'y';
            while (ch == 'Y' || ch == 'y')
            {
            Console.Clear();
            Console.WriteLine("\t\t\tWelcome to Bahria University CMS\nPlease choose the following options;");
            Console.WriteLine("1. Create Student profile\n2. Search Student\n3. Delete Student Record\n4. List top 03 of class\n5. Mark student attendance\n6. View attendance");
            int choice = Convert.ToInt32(Console.ReadLine());
            student wr = new student();
            
                switch (choice)
                {
                    case 1:
                        {
                            wr.addStudent();
                            Console.ReadKey();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Press;\n1. Search By ID\n2. Search By Name\n3. List Number of Students");
                            int choose;
                            choose = Convert.ToInt32(Console.ReadLine());
                            switch (choose)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Please enter ID");
                                        //int id = Convert.ToInt32(Console.ReadLine());
                                        string id = Console.ReadLine();
                                        StreamReader sr = new StreamReader("C://Users/Ali/Desktop/data.txt");
                                        string str;
                                        int check = 0;

                                        sr.BaseStream.Seek(0, SeekOrigin.Begin);
                                        str = sr.ReadLine();
                                        while (str != null)
                                        {
                                            if (str == id)
                                            {
                                                Console.Clear();
                                                Console.WriteLine(str);
                                                for (int i = 0; i < 5; i++)
                                                {
                                                    str = sr.ReadLine();
                                                    Console.WriteLine(str);
                                                    check = 1;
                                                }
                                                break;
                                            }
                                            str = sr.ReadLine();
                                        }
                                        if (check == 0)
                                        {
                                            Console.WriteLine("No such record");
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Please enter name");
                                        string name = Console.ReadLine();
                                        StreamReader sr = new StreamReader("C://Users/Ali/Desktop/data.txt");
                                        string str;
                                        string previous;
                                        int check = 0;
                                        sr.BaseStream.Seek(0, SeekOrigin.Begin);
                                        str = sr.ReadLine();
                                        previous = str;
                                        while (str != null)
                                        {
                                            if (str == name)
                                            {
                                                Console.Clear();
                                                Console.WriteLine(previous);
                                                Console.WriteLine(str);
                                                for (int i = 0; i < 4; i++)
                                                {
                                                    str = sr.ReadLine();
                                                    Console.WriteLine(str);
                                                    check = 1;
                                                }
                                                break;
                                            }
                                            previous = str;
                                            str = sr.ReadLine();
                                        }
                                        if (check == 0)
                                        {
                                            Console.WriteLine("No such record");
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Enrollment\tName\tSemester\tCGPA\tDepartment\tUniversity");
                                        data = File.ReadAllLines(path);
                                        temp = data.Length;
                                        students = temp / 7;
                                        student[] obj1 = new student[students];
                                        int counts = 0;
                                        for (int i = 0; i < students && counts != temp; i++)
                                        {

                                            obj1[i] = new student();
                                            obj1[i].enrollmentFunction = data[counts];
                                            counts++;
                                            obj1[i].nameFunction = data[counts];
                                            counts++;
                                            obj1[i].semesterFunction = data[counts];
                                            counts++;
                                            obj1[i].cgpaFuntion = data[counts];
                                            counts++;
                                            obj1[i].departmentFunction = data[counts];
                                            counts++;
                                            obj1[i].universityFunction = data[counts];
                                            counts++;
                                            obj1[i].attendanceFunction = data[counts];
                                            counts++;
                                        }
                                        for (int i = 0; i < students; i++)
                                        {
                                            Console.WriteLine(obj1[i].enrollmentFunction + "\t" + obj1[i].nameFunction + "\t" + obj1[i].semesterFunction + "\t" + obj1[i].cgpaFuntion + "\t" + obj1[i].departmentFunction + "\t" + obj1[i].universityFunction + "\t" + obj1[i].attendanceFunction);
                                        }
                                        
                                        break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Please enter the ID you want to delete");
                            string delete=Console.ReadLine();
                            File.WriteAllText(path, String.Empty);
                            for (int i = 0; i < students; i++)
                            {
                                if (obj[i].enrollmentFunction!=delete)
                                {
                                    string[] updates = { obj[i].enrollmentFunction, obj[i].nameFunction, obj[i].semesterFunction, obj[i].cgpaFuntion, obj[i].departmentFunction, obj[i].universityFunction, obj[i].attendanceFunction };
                                    File.AppendAllLines(path, updates);
                                }
                                    
                            }
                                break;
                        }
                    case 4:
                        {
                            Console.WriteLine("List top 3 students");
                            int i, j;
                            if (students >= 3)
                            {
                                for (i = 0; i < students; i++)
                                {
                                    for (j = 0; j < students; j++)
                                    {
                                        if ((float)Convert.ToDouble(obj[j].cgpaFuntion) > (float)Convert.ToDouble(obj[j + 1].cgpaFuntion))
                                        {
                                            student temperory = new student();
                                            temperory = obj[j];
                                            obj[j] = obj[j + 1];
                                            obj[j + 1] = temperory;
                                        }
                                    }
                                }
                                for (int t = 0; t < 2; t++)
                                {
                                    Console.WriteLine(obj[t].enrollmentFunction + obj[t].nameFunction + obj[t].cgpaFuntion);
                                }
                            }
                            break;
                        }
					case 5:
                        {
                            
                            Console.WriteLine("ID\t" + "Name\t" + "\tAttendance");
                            File.WriteAllText(path, String.Empty);
                            for (int i = 0; i < students;i++)
                            {
                                Console.Write(obj[i].enrollmentFunction + "\t" + obj[i].nameFunction + "\t");
                                obj[i].attendanceFunction = Console.ReadLine();
                                string[] updates = { obj[i].enrollmentFunction, obj[i].nameFunction, obj[i].semesterFunction, obj[i].cgpaFuntion, obj[i].departmentFunction, obj[i].universityFunction, obj[i].attendanceFunction };
                               File.AppendAllLines(path, updates);
                            }
                                break;
                        }
                    case 6:
                        {
                             //Console.WriteLine("Enrollment\tName\tSemester\tCGPA\tDepartment\tUniversity");
                                Console.WriteLine("Enrollment\tName\tAttendance");
                              
                            for (int i = 0; i < students;i++ )
                             {
                                    Console.WriteLine(obj[i].enrollmentFunction+"\t" + obj[i].nameFunction+"\t"+ obj[i].attendanceFunction);
                             
                             }
                                break;
                        }
                      }
                        Console.WriteLine("Do more? y/n");
                        ch = Convert.ToChar(Console.ReadLine());
            }
            
            
            

        }
    }
}
