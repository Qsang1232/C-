using System;

namespace WinFormsApp1
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; } // True = Nam, False = Nữ
        public string AvatarPath { get; set; } // Đường dẫn ảnh

        public Employee() { }

        public Employee(string id, string name, int age, bool gender, string avatarPath)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            AvatarPath = avatarPath;
        }
    }
}