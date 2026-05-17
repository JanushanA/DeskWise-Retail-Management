using System.Collections.Generic;

using System.Linq;

using DeskWise.Models;



namespace DeskWise.Services

{

    // A lightweight "alert" is anything the user should glance at: low stock, out of stock,

    // pending POs. Alerts are computed live from the underlying data, not persisted.

    public class Alert

    {

        public string Type { get; set; }      // Low Stock | Out of Stock | Pending PO

        public string Priority { get; set; }  // High | Medium | Low

        public string Message { get; set; }

        public string Reference { get; set; }

    }



    public static class AlertService

    {

        // Builds the full alert list from products and open purchase orders.

        public static List<Alert> GetAll()

        {

            List<Alert> list = new List<Alert>();



            // Stock-related alerts from low or zero quantity products.

            foreach (Product product in ProductService.GetLowStock())

            {

                if (product.Status == StockStatus.OutOfStock)

                {

                    list.Add(new Alert

                    {

                        Type = "Out of Stock",

                        Priority = "High",

                        Message = product.Name + " is out of stock.",

                        Reference = product.Id.ToString()

                    });

                }

                else

                {

                    list.Add(new Alert

                    {

                        Type = "Low Stock",

                        Priority = "Medium",

                        Message = product.Name + " has " + product.Quantity + " left (reorder at " + product.ReorderLevel + ").",

                        Reference = product.Id.ToString()

                    });

                }

            }



            // Purchase orders still waiting to be received.

            foreach (PurchaseOrder purchaseOrder in PurchaseOrderService.All.Where(order => order.Status == "Pending" || order.Status == "Sent"))

            {

                list.Add(new Alert

                {

                    Type = "Pending PO",

                    Priority = "Low",

                    Message = purchaseOrder.Id + " awaiting receipt (" + purchaseOrder.SupplierName + ").",

                    Reference = purchaseOrder.Id

                });

            }



            return list;

        }



        // Total number of active alerts (recomputes each time).

        public static int Count

        {

            get { return GetAll().Count; }

        }

    }

}


