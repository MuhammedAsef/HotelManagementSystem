### Hotel Management System
Bu proje, otellerin rezervasyon, müşteri yönetimi, oda yönetimi ve faturalandırma süreçlerini kolaylaştırmak için geliştirilmiştir.

## Diyagramlar

###Class Diyagramı
![Class(güncel)](https://github.com/user-attachments/assets/f01e1e7b-5d94-4fea-8b7d-e904b9b83670)
Bu diyagram Otel Otomasyon sistemine ait Class Diyagramıdır.
+ Yönetici (Yonetici): Otel yöneticileri için tanımlanan sınıftır. Odaları, müşterileri ve rezervasyonları yönetmek için gerekli özellik ve metotlara sahiptir.
+ Oda: Oteldeki odaların bilgilerini içerir. Oda ekleme ve güncelleme işlemlerini sağlar.
+ Müşteri (Musteri): Otel müşterilerinin bilgilerini tutar. Rezervasyon işlemleri bu sınıf üzerinden ilişkilendirilir.
+ Rezervasyon: Rezervasyon işlemleri için kullanılan sınıftır. Müşteri ve oda bilgileri ile ilişkilidir. Rezervasyon oluşturma, silme ve fiyat hesaplama gibi metotlara sahiptir.
+ Fatura: Her bir rezervasyon için oluşturulan faturaları temsil eder. Rezervasyon ve müşteri bilgileri ile ilişkilidir.
İlişkiler ise:
+ Bir yönetici, birden fazla odayı ve rezervasyonu yönetebilir.
+ Bir müşteri, bir veya birden fazla rezervasyona sahip olabilir.
+ Bir oda, bir rezervasyon ile ilişkilendirilir.
+ Her rezervasyon, bir fatura ile ilişkilendirilir

#ER Diyagramı
![ER(güncel)](https://github.com/user-attachments/assets/3057485a-5e05-4806-bba5-10d7225e7bae)
Bu diyagram sisteme ait ER Diyagramıdır.Oda, Müşteri, Rezervasyon ve Fatura. Otel otomasyon sistemi, bu modüller arasındaki ilişkilerle oda rezervasyonlarını, müşteri bilgilerini ve faturalamayı yönetir. Şema, giriş/çıkış tarihleri, oda durumu, müşteri ayrıntıları ve fatura takibi gibi temel özellikleri içerir.

#Use-case Diyagramı
![use-case(excalidraw)2](https://github.com/user-attachments/assets/075d2419-abd7-493c-b0d7-adc4b7970b08)
Bu diyagram ise Otel otomasyon sistemi için tasarlanan Use-case diyagramıdır. Sistemin işleyişini ve yöneticinin gerçekleştirebileceği işlemleri gösterir.
Yönetici:
Sistemin ana kullanıcısıdır ve tüm modüllerle etkileşim halindedir. Aşağıdaki işlemleri gerçekleştirebilir:

Oda Yönetimi
+ Oda Ekle: Yeni odaların sisteme eklenmesini sağlar.
+ Oda Düzenle: Var olan odaların bilgilerinin güncellenmesini sağlar.
+ Oda Sil: Artık kullanılmayan odaların sistemden kaldırılmasını sağlar.
+ Oda Görüntüle: Odalara ait bilgilerin görüntülenmesini sağlar.

 Müşteri Yönetimi
+ Müşteri Ekle: Yeni müşterilerin sisteme eklenmesini sağlar.
+ Müşteri Düzenle: Var olan müşterilerin bilgilerinin güncellenmesini sağlar.
+ Müşteri Sil: Artık sistemde tutulmayan müşterilerin kaldırılmasını sağlar.
+ Müşteri Görüntüle: Müşteri bilgilerine erişim sağlar.

 Rezervasyon Yönetimi
+ Rezervasyon Oluştur: Yeni rezervasyonların yapılmasını sağlar.
+ Rezervasyon Görüntüle: Mevcut rezervasyonların detaylarına ulaşılmasını sağlar.
+ Giriş Tarihi/Çıkış Tarihi Ayarla: Rezervasyon tarihlerinin düzenlenmesini sağlar.

Fatura Yönetimi
+ Fatura Görüntüle: Aktif ve Geçmiş Rezervasyonlara ait faturaların incelenmesini sağlar.

## Proje görselleri
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

Bir diğer ekran ise, yöneticilerin bilgilerini güncelleyebileceği ekrandır. Yöneticiler herhangi bir şifre değişikliğine gitmek istediklerinde buradan kolaylıkla değiştirebilmektedirler.


![FaturaEkrani](https://github.com/user-attachments/assets/f4b43e7d-c631-42d7-875b-c36fe3f75486)

Bu ekran ise Faturaların görüntülendiği modüldür. Bu modülde Yönetici, toplam ücret, rezervasyon durumunu ve müşterinin ID bilgisini görüntülemektedir.

Projenin YouTube Link'i:
