using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
[Serializable]
class Student
{
    public int rollno;
    public string name;
    public Student(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }
}
public class DeserializeExample
{
    public static void Main(string[] args)
    {
        FileStream stream = new FileStream("G://kavya2//folder4.txt", FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();

        Student s = (Student)formatter.Deserialize(stream);
        Console.WriteLine("Rollno: " + s.rollno);
        Console.WriteLine("Name: " + s.name);

        stream.Close();
    }
}