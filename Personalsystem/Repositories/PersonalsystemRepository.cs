﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Personalsystem.Models;

namespace Personalsystem.Repositories
{
    public class PersonalsystemRepository
    {
        private ApplicationDbContext db;

        public PersonalsystemRepository()
        {
            db = new ApplicationDbContext();
        }

        #region Company Methods
        public IEnumerable<Company> Companies()
        {
            return db.Companies.ToList();
        }
        #endregion

        #region Department Methods
        public IEnumerable<Department> Departments()
        {
            return db.Departments.ToList();
        }
        #endregion

        #region Group Methods
        public IEnumerable<Group> Groups()
        {
            return db.Groups.ToList();
        }
        #endregion

        public void Dispose()
        {
            db.Dispose();
        }
    }
}