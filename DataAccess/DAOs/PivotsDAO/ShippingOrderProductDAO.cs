using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.PivotsDTO;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs.PivotsDAO;
    public class ShippingOrderProductDAO {
        private readonly AppDbContext context;

        public ShippingOrderProductDAO(AppDbContext context) {
            this.context = context;
        }

        public ShippingOrderProducts? GetShippingOrderProductById(int orderId, int productId) {
            return this.context.ShippingOrderProducts
                .Where(sop => sop.ShippingOrderId == orderId && sop.ProduitId == productId)
                .SingleOrDefault();
        }

        public ShippingOrderProducts CreateShippingOrderProduct(ShippingOrderProducts shippingOrderProduct) {
            this.context.ShippingOrderProducts.Add(shippingOrderProduct);
            this.context.SaveChanges();
            return shippingOrderProduct;
        }

        public ShippingOrderProducts UpdateShippingOrderProduct(ShippingOrderProducts shippingOrderProduct) {
            this.context.ShippingOrderProducts.Update(shippingOrderProduct);
            this.context.SaveChanges();
            return shippingOrderProduct;
        }

        public ShippingOrderProducts DeleteShippingOrderProduct(ShippingOrderProducts shippingOrderProduct) {
            this.context.ShippingOrderProducts.Remove(shippingOrderProduct);
            this.context.SaveChanges();
            return shippingOrderProduct;
        }
    }


