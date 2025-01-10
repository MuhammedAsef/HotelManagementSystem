# HotelManagementSystem
# Otel Otomasyon Sistemi
Bu proje, otellerin rezervasyon, müşteri yönetimi, oda yönetimi ve faturalandırma süreçlerini kolaylaştırmak için geliştirilmiştir.

![Class(güncel)](https://github.com/user-attachments/assets/64cae3b4-97d5-4625-8f0e-5d8c05681072)

Bu diyagram sisteme ait Class Diyagramıdır.


![ER(güncel)](https://github.com/user-attachments/assets/4bf868a0-7a56-4564-8ad6-ba038470336b)

Bu diyagram sisteme ait ER Diyagramıdır.Oda, Müşteri, Rezervasyon ve Fatura. Otel otomasyon sistemi, bu modüller arasındaki ilişkilerle oda rezervasyonlarını, müşteri bilgilerini ve faturalamayı yönetir. Şema, giriş/çıkış tarihleri, oda durumu, müşteri ayrıntıları ve fatura takibi gibi temel özellikleri içerir.


![use-case(excalidraw)2](https://github.com/user-attachments/assets/7a9c6c4e-b762-4710-9160-cdbef611e562)




![GirisEkrani](https://github.com/user-attachments/assets/a64de6db-9cfd-4eeb-b45e-57163455712f)

Bu proje, bir otel otomasyon sisteminin yönetici giriş ekranına ait bir görseldir. Yönetici TC Kimlik Numarası ve şifre bilgilerini girerek sisteme giriş yapabiliyor. "Şifreyi Göster" seçeneği ile şifreyi görüntüleyebilmektedir. Tasarım, kullanıcı dostu bir arayüz ve otelin marka kimliğini yansıtan bir tema ile hazırlanmıştır.


![MusteriEkrani](https://github.com/user-attachments/assets/186bd3bf-4ee1-4677-b6b0-1226004be2e7)

Bu ekran görüntüsü, bir otel yönetim sisteminin müşteri işlemleri modülüne aittir. Kullanıcı bu modül üzerinden müşteri bilgilerini ekleyebilir, silebilir, güncelleyebilir ve listeleyebilir. Arayüz, müşteri kimlik bilgileri, telefon numaraları ve cinsiyet gibi detayları görüntüleme ve düzenleme imkanı sağlar. Sol tarafta diğer işlevlere hızlı erişim sağlayan bir menü bulunmaktadır.
Özellikler:
+ Müşteri Ekleme: Yeni bir müşteri sisteme kayıt yapılabilir.
+ Müşteri Silme: Var olan herhangi bir müşteri listeden seçilerek silinebilir.
+ Müşteri Güncelleme: Sistem'e kayıtlı herhangi bir müşteri bilgisi üzerinde güncelleme yapılabilir.
+ Müşteri Listesi: Sistem'e kayıtlı müşteriler kimlik bilgileri, telefon numaraları vs. diğer tüm detaylar listelenir.
+ Arama özelliği: Herhangi bir müşteri hızlıca bulunmak istediği zaman arama çubuğu kullanılabilir.


![OdaEkrani](https://github.com/user-attachments/assets/a9fe477b-3214-4aa1-b6f3-f36cee7e9811)

Bu ekranda ise otel otomasyon sisteminin oda yönetimi ekranına ait bir fotoğraftır.. Bu ekrandan otelin odalarına ilişkin işlemler kolayca gerçekleştirilebilir.
Özellikler:
+ Oda Ekleme: Yeni bir oda bilgisi girilerek sisteme eklenebilir.
+ Oda Silme: Var olan odalar listeden seçilerek silinebilir.
+ Oda Güncelleme: Mevcut oda bilgileri üzerinde düzenleme yapılabilir.
+ Oda Listesi Görüntüleme: Tüm odalar, durumları ve diğer detaylarıyla birlikte listelenir.
+ Arama Özelliği: Odaları hızlıca bulmak için arama çubuğu kullanılabilir.


![RezervasyonEkrani](https://github.com/user-attachments/assets/335ced04-40d6-4b56-8f25-be82a587e350)

Bu ekran, otel otomasyon sisteminin rezervasyon işlemlerini yönetmek için tasarlanmıştır. Yöneticiler, otel odaları için rezervasyon ekleyebilir, mevcut rezervasyonları görüntüleyebilir ve gerektiğinde iptal edebilir.
Özellikler:
+ Rezervasyon Ekleme: Oda ID, müşteri ID, giriş ve çıkış tarihleri girilerek yeni rezervasyon oluşturulabilir.
+ Rezervasyon Silme: Mevcut rezervasyonlar listeden seçilerek iptal edilebilir.
+ Rezervasyon Listesi: Tüm rezervasyonlar giriş ve çıkış tarihleri, müşteri ID'si ve oda ID'si gibi detaylarla birlikte tabloda görüntülenir.
+ Dinamik Tarih Seçimi: Giriş ve çıkış tarihleri için kullanıcı dostu tarih seçimi yapılabilir.


![BilgiDuzenlemeEkrani](https://github.com/user-attachments/assets/df2df199-c246-4e96-8143-f6ba919c4449)

Bu ekran görüntüsü, yöneticilerin bilgilerini güncelleyebileceği bir diğer ekrandır. Yöneticiler herhangi bir şifre değişikliğine gitmek istediklerinde buradan kolaylıkla değiştirebilmektedirler.


![FaturaEkrani](https://github.com/user-attachments/assets/f4b43e7d-c631-42d7-875b-c36fe3f75486)

Bu ekran ise Faturaların görüntülendiği modüldür. Bu modülde Yönetici, toplam ücret, rezervasyon durumunu ve müşterinin ID bilgisini görüntülemektedir.
