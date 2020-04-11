using E_commerce.Models.view_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Models.Repository
{
    interface iproduct
    {

        void inertproduct(productviewmodel pro);
        void editproduct(productviewmodel pro);

        List<productviewmodel> viewpeoduct();

        productviewmodel getproduct(int? id);

    }
}
