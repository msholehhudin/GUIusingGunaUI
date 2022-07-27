using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOA_s_Project
{
    class InventoryAtt
    {
        public string Serial_Number { get; set; }
        public string Item_Name { get; set; }
        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string Item_type { get; set; }
        public string Quantity { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }



        public InventoryAtt(string serial_Number, string item_Name, string barcode, string brand, string item_type, string quantity, string location, string description)
        {
            Serial_Number = serial_Number;
            Item_Name = item_Name;
            Barcode = barcode;
            Brand = brand;
            Item_type = item_type;
            Quantity = quantity;
            Location = location;
            Description = description;
        }
    }
}
