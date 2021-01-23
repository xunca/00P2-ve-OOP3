using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{   //Interface kullanıldığında her bir krediye özel hesaplama yapılabilir. 
    //Bu metod her kredide zorunlu hale gelir çünkü buradan interitace edilir.
    //Birbirinin alternatifi olan ama kod içeriği farklı olan yerlerde kullanılır. Örneğin kredilerin hepsinde
    //hesaplama var fakat kodları farklıdır.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();

    }
}
