﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();         
            IKrediManager tasitKrediManager = new TasitKrediManager();        
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager }; //Birden fazla kredi.

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); //
        }
    }       //Interfacelerde referans bilgi tutuyor. Bu yüzden IKrediManager çalıştı.
}