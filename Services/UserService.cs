using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService
    {
        Aeroplane aeroplane = new();

        public void BuyTicket()
        {
            int loop = -1;
            while (loop != -1)
            {
                if (aeroplane.capacity<368)
                Console.WriteLine("Bilet numaranız: \"TK 4591 2387 65\"");
                else
                {
                    Console.WriteLine("Hata: Uçak kapasitesi dolu. Lütfen başka bir uçuş seçin veya daha sonra tekrar deneyin.");
                }
            }
        }
    }
}
