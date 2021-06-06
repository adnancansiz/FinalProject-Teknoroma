Projeyi Visual Studio ' da çalıştırdıktan sonra , Package Manager Console üzerinden Migration ' ı Kurmanız/Eklemeniz (add-migration)
gerekmektedir.
Migration işleminden sonra yine Package Manager Console üzerinden veritabanı güncelleme işlemi (update-database) yapmalısınız.

Bu işlemleri yaptıktan sonra programı çalıştırdığınızda veri tabanına otomatik olarak eklenecek veriler aşağıdaki gibidir ;

Uygulamanın kontrollerinin yapılabilmesi için eklenen veriler;

Kullanıcı Bilgileri;
-Admin poziyonu
Kullanıcı Adı:Admin
Password : Test123++
-Muhasebe Pozisyonu
Kullanıcı Adı: Accounting
Password : Test123++
-Depo Pozisyonu
Kullanıcı Adı: StockRoom
Password : Test123++
-Kasiyer Pozisyonu
Kullanıcı Adı : Cashier
Password : Test123++
-Mobil Satış Pozisyonu
Kullanıcı Adı : MobileSales
Password : Test123++
-Teknik Servis Pozisyonu
Kullanıcı Adı : TechnicalService
Password : Test123++
Kullanıcıların Yanı sıra Kategori , Alt Kategori , Ürün , Müşteri , Tedarikçi Gibi bilgiler ek olarak eklenmiştir. 
