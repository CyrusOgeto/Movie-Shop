namespace MoviePlace.Models
{
    public class Receipt
    {

        public int Id { get; set; }
        public String MTitle { get; set; }
        public  String MType { get; set; }
        public String MGenre { get; set; }
        public String MTrailer { get; set; }
        public int SoldCopies { get; set; }
        public Receipt()
        {

        }
        public int CustomerReceipt(int quantity)
        {
            int CustomerTotal;
            CustomerTotal = quantity * 50;
            return CustomerTotal;
        }
         

    }
}
