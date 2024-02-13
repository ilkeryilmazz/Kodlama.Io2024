// See https://aka.ms/new-console-template for more information
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using Entities.Concretes;


#region Category

ICategoryService _categoryService = new CategoryManager(new CategoryDal());
Console.WriteLine("Tüm Kategorileri Listeleme.");

foreach (var category in _categoryService.GetAll())
{
    Console.WriteLine("Kategori Adı: " + category.Name);
}
Console.WriteLine();
Console.WriteLine("Yeni Kategori Ekleme.");


_categoryService.Add(new Category() { Id=3,Name="Python",Description="Python içerikli kurslar"});

foreach (var category in _categoryService.GetAll())
{
    Console.WriteLine("Kategori Adı: " + category.Name);
}
Console.WriteLine();

Console.WriteLine("Kategori Silme.");

_categoryService.Delete(new Category() { Id = 1});

foreach (var category in _categoryService.GetAll())
{
    Console.WriteLine("Kategori Adı: " + category.Name);
}
Console.WriteLine();

Console.WriteLine("Kategori Güncelleme İşlemi.");

_categoryService.Update(new Category() { Id = 3,Name="Python Güncelleme",Description="Python Güncelleme" });

foreach (var category in _categoryService.GetAll())
{
    Console.WriteLine("Kategori Adı: " + category.Name);
}

#endregion
Console.WriteLine();
Console.WriteLine("**********************************************************************************************");
Console.WriteLine();
#region Instructor

IInstructorService _instructorService = new InstructorManager(new InstructorDal());
Console.WriteLine("Tüm Eğitmenleri Listeleme.");

foreach (var instructor in _instructorService.GetAll())
{
    Console.WriteLine("Eğitmen Adı: " + instructor.FirstName);
}
Console.WriteLine();
Console.WriteLine("Yeni Eğitmen Ekleme.");


_instructorService.Add(new Instructor() { Id = 3, FirstName = "Gençay", LastName="Yıldız", Description = "Gençay yıldız açıklaması" ,ImagePath="test.png"});

foreach (var instructor in _instructorService.GetAll())
{
    Console.WriteLine("Eğitmen Adı: " + instructor.FirstName);
}
Console.WriteLine();

Console.WriteLine("Eğitmen Silme.");

_instructorService.Delete(new Instructor() { Id = 1 });

foreach (var instructor in _instructorService.GetAll())
{
    Console.WriteLine("Eğitmen Adı: " + instructor.FirstName);
}
Console.WriteLine();

Console.WriteLine("Eğitmen Güncelleme İşlemi.");
_instructorService.Update(new Instructor() { Id = 3, FirstName = "Gençay Güncellenen Veri", LastName = "Yıldız", Description = "Gençay yıldız açıklaması", ImagePath = "test.png" });

foreach (var instructor in _instructorService.GetAll())
{
    Console.WriteLine("Eğitmen Adı: " + instructor.FirstName);
}


#endregion

Console.WriteLine();
Console.WriteLine("**********************************************************************************************");
Console.WriteLine();

#region Course

ICourseService _courseService = new CourseManager(new CourseDal());
Console.WriteLine("Tüm Kursları Listeleme.");

foreach (var course in _courseService.GetAll())
{
    Console.WriteLine("Kurs Adı: " + course.Name);
}
Console.WriteLine();
Console.WriteLine("Yeni Kurs Ekleme.");


_courseService.Add(new Course() {Id=3,Description="Python kursu",CategoryId=3,Name="Python",InstructorId=1 });

foreach (var course in _courseService.GetAll())
{
    Console.WriteLine("Kurs Adı: " + course.Name);
}
Console.WriteLine();

Console.WriteLine("Kurs Silme.");

_courseService.Delete(new Course() { Id = 2 });

foreach (var course in _courseService.GetAll())
{
    Console.WriteLine("Kurs Adı: " + course.Name);
}
Console.WriteLine();

Console.WriteLine("Kurs Güncelleme İşlemi.");
_courseService.Update(new Course() { Id = 1, Description = "C# kursu", Name = "C# güncellendi", CategoryId=1,InstructorId = 1 ,ImagePath="newcsharp.png"});

foreach (var course in _courseService.GetAll())
{
    Console.WriteLine("Kurs Adı: " + course.Name);
}

#endregion