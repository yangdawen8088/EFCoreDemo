using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace EFCoreDemo.DataBase
{
    class EFCoreDbContext : DbContext
    {
        public DbSet<T_blogList> T_blogLists { get; set; }
        public DbSet<T_blogContent> T_BlogContents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source={数据库服务器};Database={数据库名称};User ID={数据库登录账户};Password={数据库连接字符串密码}");
    }
}