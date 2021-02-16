using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace lab5
{
    [Serializable]
    public class Student
    {
        public string Nume;
        public int Varsta;

        public int An;
        public int[] Note;

        public double Media;

        [NonSerialized] 
        static public List<Student> Students = new List<Student>();
        
        
        [NonSerialized]
        static public List<Student> customStudents = null;

        public Student()
        {
            Media = getMedia();
        }
        
        public Student(string nume, int varsta, int an, int[] note)
        {
            Nume = nume;
            Varsta = varsta;
            An = an;
            this.Note = note;
            this.Media = getMedia();
            
            Students.Add(this);
        }

        
        public double getMedia()
        {
            if (Note.Length == 0)
            {
                return 0;
            }
            
            int sum = 0;
            for (int i = 0; i < Note.Length; i++)
            {
                sum += Note[i];
            }

            return sum / Note.Length;
        }
        

        #region Sorting
        public static void bubleSortByName()
        {
            if (Students.Count <= 1)
            {
                return;
            }
            
            bool ok;
            do
            {
                ok = true;
                for (int i = 0; i < Students.Count - 1; i++)
                {
                    if (Students[i].Nume.CompareTo(Students[i + 1].Nume) < 0)
                    {
                        Student st_aux = Students[i];
                        Students[i] = Students[i + 1];
                        Students[i + 1] = st_aux;

                        ok = false;
                    }
                }
            } while (!ok);
        }
        
        public static void bubleSortByMedie()
        {
            if (Students.Count <= 1)
            {
                return;
            }
            
            bool ok;
            do
            {
                ok = true;
                for (int i = 0; i < Students.Count - 1; i++)
                {
                    if (Students[i].Media < Students[i + 1].Media)
                    {
                        Student st_aux = Students[i];
                        Students[i] = Students[i + 1];
                        Students[i + 1] = st_aux;

                        ok = false;
                    }
                }
            } while (!ok);
        }

        public static List<Student> getStudentsFromYear(int year)
        {
            List<Student> studentsFromYear = new List<Student>();

            foreach (var student in Students)
            {
                if (student.An == year)
                {
                    studentsFromYear.Add(student);
                }
            }

            return studentsFromYear;
        }

        public static List<Student> getStudentsByName(string name)
        {
            List<Student> studentsFromYear = new List<Student>();

            foreach (var student in Students)
            {
                if (student.Nume.Equals(name))
                {
                    studentsFromYear.Add(student);
                }
            }

            return studentsFromYear;
        }
        #endregion

        #region Serialize
        public static void serializeAll()
        {
            BinaryFormatter bf = new BinaryFormatter();
            
            PushNotification pn = new PushNotification();

            try
            {

                using (var fs = new FileStream("students2.bin", FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                {
                    bf.Serialize(fs, Students);
                    
                    pn.setSucces("Succesfull serialized");
                    pn.showPushNotification();    
                }
            }
            catch (Exception e)
            {
                pn.setError("Serialization Failed");       
                pn.showPushNotification();
            }
            
        }
        
        public static void deserializeAll()
        {
            List<Student> students_tmp;
            
            BinaryFormatter bf = new BinaryFormatter();

            PushNotification ps = new PushNotification();

            try
            {
                using (var fs = new FileStream("students2.bin", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    students_tmp = (List<Student>) bf.Deserialize(fs);
                    ps.setSucces("Succesfull deserialize");


                    if (students_tmp != null)
                    {
                        if (students_tmp.Count >= 1)
                        {
                            Students = students_tmp;


                            ps.showPushNotification();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                ps.setError("Failed deserialize");
                ps.showPushNotification();
                
            }
            
             
        }
        #endregion

        public static void updateStudent(Student student, int index)
        {
            if (customStudents != null)
            {
                Students.Remove(customStudents[index]);
                customStudents.Remove(customStudents[index]);
                serializeAll();
            }
            else
            {
                Students.Remove(Students[index]);
                serializeAll();
            }
        }

       public override string ToString()
        {
            return Nume + ", " + Varsta + " ani, Anul " + An + ", Media " + Media;
        }

        public static void deleteBySelectedIndex(int selectedIndex)
        {
            if (customStudents != null)
            {
                Students.Remove(customStudents[selectedIndex]);
                serializeAll();
            }
            else
            {
                Students.Remove(Students[selectedIndex]);
                serializeAll();
            }
        }
    } 
}