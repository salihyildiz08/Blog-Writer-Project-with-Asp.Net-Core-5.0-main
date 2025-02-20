
# Mağaza Blog Yönetim Sistemi

Bu proje, bir mağazanın **blog**, **admin** ve **yazar** olmak üzere 3 temel panelinden oluşan bir yapı geliştirilerek hazırlanmıştır. Özellikle **admin paneli** için güçlü bir arayüz tasarımı yapılmış, CRUD işlemlerinin ötesine geçecek özellikler eklenmiştir. Bu projede, **Entity Framework**, **n katmanlı mimari**, **LINQ sorguları**, **Trigger** ve **Procedure** gibi SQL yapıları kullanılarak somut bir proje ortaya çıkarılmıştır.

## Proje Özeti

Bu projede aşağıdaki temel yapı ve teknolojiler kullanılarak güçlü bir yönetim paneli ve kullanıcı arayüzü oluşturulmuştur:
- **Admin Paneli**: Blog yönetimi ve admin işlemleri için kapsamlı bir yönetim paneli.
- **Yazar Paneli**: Yazarların blog gönderileri oluşturmasını, düzenlemesini ve yayınlamasını sağlayan özellikler.
- **CRUD İşlemleri**: Admin ve yazarların içerik üzerinde temel işlem yapabilmesi (Ekleme, Silme, Güncelleme, Listeleme).

## Kullanılan Teknolojiler ve Mimari

Projede kullanılan teknolojiler ve mimari unsurlar şunlardır:

### 1. **Entity Framework**
   - **Code First** yaklaşımı kullanılarak, veritabanı modelini doğrudan kodlardan türettim.
   - Veritabanı işlemleri için Entity Framework üzerinden güçlü bir veri yönetimi sağladım.

### 2. **Generic Repository**
   - Veritabanı işlemlerini genel bir yapı üzerinden yönetmek amacıyla **Generic Repository** tasarım desenini kullandım.
   - Bu, veri erişimi katmanının tekrar kullanılabilirliğini artırmıştır.

### 3. **Fluent Validation**
   - Kullanıcı giriş verilerinin doğruluğunu kontrol etmek için **Fluent Validation** kütüphanesini kullandım.
   - Form doğrulamaları, kullanıcı deneyimini iyileştirecek şekilde geliştirilmiştir.

### 4. **SweetAlert**
   - Kullanıcıya görsel olarak daha hoş bir deneyim sunmak amacıyla **SweetAlert** kütüphanesini kullanarak bildirimler ve uyarılar oluşturulmuştur.

### 5. **Authentication ve Authorize**
   - Kullanıcıların kimlik doğrulama ve yetkilendirme işlemleri için **Authentication** ve **Authorization** yöntemlerini kullandım.
   - Admin ve yazar rolleri arasında yetki yönetimini sağlamış oldum.

### 6. **Trigger ve Procedure**
   - Veritabanında **Trigger** kullanarak otomatik işlemler gerçekleştirdim.
   - **SQL Procedure**'leri ile karmaşık veritabanı işlemleri gerçekleştirildi.

### 7. **Areas**
   - Projeyi modüler hale getirmek için **Areas** yapısını kullandım.
   - Bu yapı, projedeki farklı işlevleri mantıklı bir şekilde ayırmamı sağladı.

### 8. **Pagination**
   - Kullanıcı deneyimini geliştirmek için veri listeleme işlemlerinde **sayfalama** yapısını kullandım.

### 9. **Web API**
   - İstemcilere veri sunumu yapmak amacıyla **Web API** oluşturdum.
   - Veri alışverişi hızlı ve etkili bir şekilde gerçekleştirilmiştir.

### 10. **Ajax**
   - Sayfalar arası veri iletişimini hızlı hale getirmek için **Ajax** teknolojisini kullandım.
   - Sayfa yenilenmeden veri alma ve gönderme işlemleri sağlandı.

### 11. **Chart (Grafikler)**
   - Verileri görselleştirmek amacıyla **Chart** teknolojisini kullanarak grafikler oluşturulmuştur.

### 12. **Identity**
   - Kullanıcı kimlik doğrulaması ve yönetimi için **Identity** yapısını kullandım.
   - Admin ve yazarların sistemdeki işlemleri için güvenli bir kimlik doğrulama süreci sağlandı.

### 13. **JsonWebToken (JWT)**
   - **JsonWebToken (JWT)** kullanarak token tabanlı kimlik doğrulama sağladım.
   - API üzerinden güvenli bir iletişim yöntemi elde edilmiştir.

---

## Proje Yapısı

Projede kullanılan **n katmanlı mimari**, projenin daha sürdürülebilir ve yönetilebilir olmasını sağlamaktadır. Katmanlar şu şekildedir:

1. **Presentation Layer** (Sunum Katmanı): Kullanıcı arayüzü ve frontend işlemleri burada yapılmaktadır.
2. **Business Logic Layer** (İş Katmanı): CRUD işlemleri ve iş mantığı burada işlenir.
3. **Data Access Layer** (Veri Erişim Katmanı): Veritabanı ile iletişim, **Entity Framework** üzerinden gerçekleştirilir.

---

## Kurulum

Proje, **Visual Studio** veya benzeri bir IDE ile açılabilir. Projeyi kurmak için aşağıdaki adımları takip edebilirsiniz:

1. Bu repo'yu bilgisayarınıza klonlayın:
   ```bash
   git clone https://github.com/username/repository-name.git
   ```

2. **NuGet Paketlerini Yükleyin**:
   Projeyi açtıktan sonra, NuGet paket yöneticisini kullanarak gerekli paketleri yükleyin.

3. **Veritabanı Yapılandırmasını Yapın**:
   Entity Framework Code First yaklaşımıyla veritabanını oluşturmak için aşağıdaki komutları çalıştırın:
   ```bash
   Update-Database
   ```

4. **Projeyi Çalıştırın**:
   Projeyi **F5** ile çalıştırarak admin ve yazar panellerine erişebilirsiniz.

---

## Katkı Sağlama

Bu projeye katkı sağlamak için aşağıdaki adımları takip edebilirsiniz:

1. Fork'layın.
2. Yeni bir branch oluşturun (`git checkout -b feature-branch`).
3. Değişikliklerinizi yapın ve commit edin (`git commit -am 'Yeni özellik eklendi'`).
4. Push yapın (`git push origin feature-branch`).
5. Bir pull request gönderin.

---

## Lisans

Bu proje, **MIT Lisansı** ile lisanslanmıştır. Detaylar için [LICENSE.md](LICENSE.md) dosyasına bakabilirsiniz.
```

---

### Açıklamalar:

- **Projenin Tanıtımı**: Proje, bir mağaza blogunu yönetmeye yönelik güçlü bir sistem sunuyor.
- **Kullanılan Teknolojiler**: Teknolojiler detaylıca açıklanmış, her birinin projenin hangi kısmında kullanıldığı belirtilmiş.
- **Proje Yapısı**: N katmanlı mimari kullanıldığı vurgulanmış ve yapılar açıklanmış.
- **Kurulum Talimatları**: Projeyi kurma adımları net bir şekilde belirtilmiş.

