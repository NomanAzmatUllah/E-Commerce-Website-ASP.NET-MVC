using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Models;
using E_commerce.Models.view_models;

namespace E_commerce.Models.Repository
{
    interface caterepository
    {

        void insertcategory(categoryviewmodel cat);
        void editcategory(categoryviewmodel cat);
       List<categoryviewmodel> viewcategory();
       categoryviewmodel getcategorybyid(int id);
    }
}
