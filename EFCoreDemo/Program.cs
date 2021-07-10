using EFCoreDemo.DataBase;
using EFCoreDemo.Models;
using System;
using System.Linq;

namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EFCoreDbContext())
            {
                // 执行数据库插入操作
                Console.WriteLine("向数据库插入一条数据：");
                // 这里可以不用给 T_blogContent 实体的ID字段赋值，EFCore会自动生成一个 GUID
                db.Add(new T_blogContent { Content = "这是一篇博客的演示内容，这条数据将插入到数据库中", blogListId = Guid.NewGuid() });
                // 执行保存操作
                db.SaveChanges();

                // 执行读取数据库数据操作  
                Console.WriteLine("从数据库中读取数据：");
                var blogContentList = db.T_BlogContents.OrderBy(b => b.Id).First();
                Console.WriteLine("{0}\t{1}\t{2}", blogContentList.Id, blogContentList.Content, blogContentList.blogListId);

                // 更新数据库中的数据
                Console.WriteLine("更新数据表中的数据：");
                blogContentList.Content = "这条数据已经被修改了！";
                db.SaveChanges();
                var blogContentList2 = db.T_BlogContents.OrderBy(b => b.Id).First();
                Console.WriteLine("{0}\t{1}\t{2}", blogContentList2.Id, blogContentList2.Content, blogContentList2.blogListId);

                // 删除数据库表中的数据   
                Console.WriteLine("删除数据库表中的数据");
                db.Remove(blogContentList2);
                db.SaveChanges();
            }
            Console.WriteLine("数据库操作结束，按任意键退出：");
            Console.ReadKey();
        }
    }
}