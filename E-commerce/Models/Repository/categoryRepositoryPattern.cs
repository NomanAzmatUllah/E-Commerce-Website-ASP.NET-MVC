using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_commerce.Models.view_models;

namespace E_commerce.Models.Repository
{

    public class categoryRepositoryPattern : caterepository
    {
        EcommerceEntities db = new EcommerceEntities();

        public void editcategory(categoryviewmodel item)
        {
            category c = db.categories.Where(x => x.cat_id == item.cat_id).SingleOrDefault();
            c.cat_id = item.cat_id;
            c.cat_name = item.cat_name;
            c.cat_createon = item.cat_createon;
            c.cat_icon = item.cat_icon;
            c.cat_fk_ad_id = item.cat_fk_ad_id;
            db.categories.Add(c);
            db.SaveChanges();
        }

        public categoryviewmodel getcategorybyid(int  id)
        {
            category item = db.categories.Where(x => x.cat_id == id).SingleOrDefault();
            categoryviewmodel c = new categoryviewmodel();
            c.cat_id = item.cat_id;
            c.cat_name = item.cat_name;
            c.cat_createon = item.cat_createon;
            c.cat_icon = item.cat_icon;
            c.cat_fk_ad_id = item.cat_fk_ad_id;
            return c;


        }

        public void insertcategory(categoryviewmodel item)
        {
            category c = new category();

            c.cat_id = item.cat_id;
            c.cat_name = item.cat_name;
            c.cat_createon = item.cat_createon;
            c.cat_icon = item.cat_icon;
            c.cat_fk_ad_id = item.cat_fk_ad_id;
            db.categories.Add(c);
            db.SaveChanges();
        }

        public List<categoryviewmodel> viewcategory()
        {
            List<categoryviewmodel> li = new List<categoryviewmodel>();
            List<category> cat = db.categories.ToList();

            foreach (var item in cat)
            {

                categoryviewmodel c = new categoryviewmodel();
                c.cat_id = item.cat_id;
                c.cat_name = item.cat_name;
                c.cat_createon = item.cat_createon;
                c.cat_icon = item.cat_icon;
                c.cat_fk_ad_id = item.cat_fk_ad_id;
                li.Add(c);
            }
            return li;
        }
    }
}