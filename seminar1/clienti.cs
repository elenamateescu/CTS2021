using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Greseli identificate
1. Clasele nu sunt corelate 
Scopul a 3 clase e sa aiba anumite relatii intre ele

2. Lipsa functionalitatii din cadrul unor clase

3.
 */
//prima clasa
//Clienti.cs

namespace WindowsFormsAppProjectHotelReservation.Class
{
   
    public class Clienti
    {
        
        public int Id { get; set; }//cheia primara in tabela
        public String Name { get; set; }
        public String Email { get; set; }     
        public String Camera { get; set; }
        

    }
}

//a 2-a clasa
//Rezervari.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppProjectHotelReservation.Class
{
    [Serializable]
    public class Rezervari
{
       public string nume;
       public DateTime checkIn;
       public DateTime checkOut;

        String NumeClient { get; set; }
        DateTime CheckInData { get; set; }
        DateTime CheckOutData { get; set; }
        public TipCamere Tip { get; set; }
        public String nrCamere { get; set; }

        public Rezervari(string nume, DateTime checkIn, DateTime checkOut, TipCamere tip, String nrCamere)
        {
            this.nume = nume;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.nrCamere = nrCamere;          
            this.Tip = TipCamere.APARTAMENT;
        }
        
        

        public override string ToString()
        {
            return this.NumeClient + "," +
                this.CheckInData + "," +
                this.CheckOutData + "," +
                this.Tip + "\n";
        }
    }
}

//a 3-a clasa 
//RevervariClienti.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppProjectHotelReservation.Class
{
    class RezervariClienti : Clienti
    {
        
        public int Id { get; set; }
        public String GuestName { get; set; }
        public String Telephone { get; set; }
        public List<Clienti> Guests { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
       
    }
}

//a 4-a clasa
TipCamere.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppProjectHotelReservation.Class
{
    public enum TipCamere
    {
        STANDARD_ROOM,
        SINGLE_ROOM,
        DOUBLE_ROOM,
        APARTAMENT,
        LUX_ROOM
        
    }

}
pe viitor rezolv problema cu git si nu ma mai folosesc de copy paste
