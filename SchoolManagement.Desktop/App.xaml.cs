﻿using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using static SchoolManagement.Data.DatabaseContext;

namespace SchoolManagement.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Database.SetInitializer<DatabaseContext>(new DatabaseContextInitializer());
            using (DatabaseContext _db = new DatabaseContext())
            {
                _db.Database.Initialize(true);
            }
        }
    }
}
