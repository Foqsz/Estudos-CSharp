using DotNetTen.Entities;

namespace DotNetTen.Extensions;

public static class StudentExtension
{
    extension (Student)
    {
        public static Student CreateDefault()
        {
            return new Student { Name = "Default Name" };
        }
    }
}
