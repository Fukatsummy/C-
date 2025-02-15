﻿using System.IO;
using System.Xml.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human hum = new Human(typeof(Human));
            hum.GetAttribute(typeof(Human));
            Console.WriteLine(hum.ToString());
        }
    }
    [AttributeUsage(AttributeTargets.All)]
    public class PropertyAttribute : Attribute
    {
        public string? _value_name { get; set; }
        public string? _value_lastname { get; set; }
        public string? _value_dofb { get; set; }
        public PropertyAttribute() { }
        public PropertyAttribute(string pathtoname, string pathtolastname, string pathtodofb)
        {
            try
            {
                using StreamReader? readername = new StreamReader(pathtoname);
                using StreamReader? readerlastname = new StreamReader(pathtolastname);
                using StreamReader? readerdofb = new StreamReader(pathtodofb);
                _value_name = readername.ReadToEnd();
                _value_lastname = readerlastname.ReadToEnd();
                _value_dofb = readerdofb.ReadToEnd();
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentException(ex.Message, nameof(pathtoname));
            }
        }
    }
    [Property("name.ini", "lastname.ini", "dateofbirth.ini")]
    class Human
    {
        PropertyAttribute? MyAttribute;
        [Property("name.ini", "lastname.ini", "dateofbirth.ini")]
        public string? Name { get; set; }
        [Property("name.ini", "lastname.ini", "dateofbirth.ini")]
        public string? LastName { get; set; }
        [Property("name.ini", "lastname.ini", "dateofbirth.ini")]
        public string? Dayofbirth { get; set; }

        public void GetAttribute(Type t)
        {
            PropertyAttribute att;
            
            att = (PropertyAttribute)Attribute.GetCustomAttribute(t, typeof(PropertyAttribute));
            MemberInfo[] MyMemberInfo = t.GetProperties();
            for (int i = 0; i < MyMemberInfo.Length; i++)
            {
                att = (PropertyAttribute)Attribute.GetCustomAttribute(MyMemberInfo[i], typeof(PropertyAttribute));
                if (att == null)
                {
                    Console.WriteLine("No attribute in member function {0}.\n", MyMemberInfo[i].ToString());
                }
            }
        }
        public Human() { }
        public Human(Type t)
        {
            try
            {
                MyAttribute = (PropertyAttribute)Attribute.GetCustomAttribute(t, typeof(PropertyAttribute));
                if (MyAttribute != null)
                {
                    Name = MyAttribute._value_name;
                    LastName = MyAttribute._value_lastname;
                    Dayofbirth = MyAttribute._value_dofb;
                }
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentException(ex.Message, nameof(MyAttribute));
            }
        }
        public override string ToString()
        {
            return "Значение взято из INI файлов " + Name + " " + LastName + " " + Dayofbirth + " ";
        }
    }
}