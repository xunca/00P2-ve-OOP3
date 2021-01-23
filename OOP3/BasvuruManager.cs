using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();  //Method Injection, hangi kredi türü ve hangi logu kullanacağını söylüyoruz.



            //Böylece genel olarak kredi başvurusu interface aracılığıyla hesaplanabilir.
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) // IKrediManager tipinde bana bir liste ver demek
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); // bu şekilde tek bir hesap yerine listedeki her bir krediyi hesaplayabiliriz.
            }
        }

    }

}
