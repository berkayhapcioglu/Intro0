using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
          // IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
          // ihtiyacKrediManager.Hesapla();
          //
          // TasitKrediManager tasitKrediManager = new TasitKrediManager();
          // tasitKrediManager.Hesapla();
          //
          // KonutKrediManager konutKrediManager = new KonutKrediManager();
          // konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService()});
           // basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            //Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.

        }
    }
}
