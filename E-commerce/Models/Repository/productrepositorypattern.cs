using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_commerce.Models.view_models;

namespace E_commerce.Models.Repository
{
    public class productrepositorypattern : iproduct
    {
        EcommerceEntities db = new EcommerceEntities();
        public void editproduct(productviewmodel pro)
        {
            product p = db.products.Where(x => x.pro_id == pro.pro_id).SingleOrDefault();
            p.pro_id = pro.pro_id;
            p.pro_name = pro.pro_name;
            p.pro_price = pro.pro_price;
            p.pro_image1 = pro.pro_image1;
            p.pro_image2 = pro.pro_image2;
            p.pro_image3 = pro.pro_image3;
            p.pro_desc = pro.pro_desc;
            p.pro_fk_cat_id = pro.pro_fk_cat_id;
            db.SaveChanges();


        }

        public productviewmodel getproduct(int? id)
        {
            product pro = db.products.Where(x =>x.pro_id == id).SingleOrDefault();

            productviewmodel p = new productviewmodel();

            p.pro_id = pro.pro_id;
            p.pro_name = pro.pro_name;
            p.pro_price = pro.pro_price;
            p.pro_image1 = pro.pro_image1;
            p.pro_image2 = pro.pro_image2;
            p.pro_image3 = pro.pro_image3;
            p.pro_desc = pro.pro_desc;
            p.pro_fk_cat_id = pro.pro_fk_cat_id;
            return p;
        }

        public void inertproduct(productviewmodel pro)
        {
            product p = new product();

            p.pro_id = pro.pro_id;
            p.pro_name = pro.pro_name;
            p.pro_price = pro.pro_price;
            p.pro_image1 = pro.pro_image1;
            p.pro_image2 = pro.pro_image2;
            p.pro_image3 = pro.pro_image3;
            p.pro_desc = pro.pro_desc;
            p.pro_fk_cat_id = pro.pro_fk_cat_id;
            db.products.Add(p);
            db.SaveChanges();

           
        }

        public List<productviewmodel> viewpeoduct()
        {
            List<product> prod = db.products.ToList();
            List<productviewmodel> li = new List<productviewmodel>();
            foreach (var pro in prod)
            {



                productviewmodel p = new productviewmodel();

                p.pro_id = pro.pro_id;
                p.pro_name = pro.pro_name;
                p.pro_price = pro.pro_price;
                p.pro_image1 = pro.pro_image1;
                p.pro_image2 = pro.pro_image2;
                p.pro_image3 = pro.pro_image3;
                p.pro_desc = pro.pro_desc;
                p.pro_fk_cat_id = pro.pro_fk_cat_id;
                li.Add(p);




            }


            return li;


        }
    }
}