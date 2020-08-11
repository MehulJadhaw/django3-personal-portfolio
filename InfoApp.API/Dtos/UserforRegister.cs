namespace InfoApp.API.Dtos
{
    public class UserforRegister
    {
         public int Id { get; set; }

        public string Shipment_type { get; set; }

        public int L { get; set; }

        public int B { get; set; }

        public int H { get; set; }

        public int Weight { get; set; }

        public string Delivery_option { get; set; }

        public string Pickup_address { get; set; }

        public int Building_no { get; set; }

        public int Street_no { get; set; }

        public string Locality { get; set; }

        public int Pin_code { get; set; }

        public int Contact_no { get; set; }
        
    }
}