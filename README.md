# C# SQL Server CRUD Uygulaması

Bu proje, **C# ve SQL Server** kullanılarak temel veritabanı işlemlerini öğrenmek amacıyla geliştirilmiştir.

Projede ADO.NET ve `Microsoft.Data.SqlClient` kullanılarak SQL Server üzerinde **CRUD (Create, Read, Update, Delete)** işlemleri gerçekleştirilmektedir.

## 🚀 Kullanılan Teknolojiler

* **C#**
* **.NET**
* **SQL Server**
* **Microsoft.Data.SqlClient**
* **ADO.NET**
* `DataTable`
* `SqlDataAdapter`
* `SqlCommand`

## 📌 Projede Bulunan İşlemler

### 1. Kategori Ekleme

SQL Server içerisindeki `CategoryTable` tablosuna yeni kategori eklenir.

```sql
INSERT INTO CategoryTable (category_name)
VALUES (@p1)
```

Kullanıcıdan alınan kategori adı parametre olarak SQL sorgusuna gönderilir.

---

### 2. Ürün Ekleme

`Producttab` tablosuna yeni ürün eklenir.

Eklenen bilgiler:

* Ürün adı
* Ürün fiyatı
* Ürün durumu

Örnek SQL sorgusu:

```sql
INSERT INTO Producttab
(Product_Name, Product_Price, Product_Status)
VALUES
(@productName, @productPrice, @productStatus)
```

---

### 3. Veri Listeleme

`Producttab` tablosundaki ürünler SQL Server'dan çekilir.

Bu işlemde:

* `SqlCommand`
* `SqlDataAdapter`
* `DataTable`
* `DataRow`

kullanılmıştır.

Örnek sorgu:

```sql
SELECT * FROM Producttab
```

Çekilen veriler `foreach` döngüsü kullanılarak konsola yazdırılır.

---

### 4. Ürün Silme

Kullanıcıdan alınan ürün ID'sine göre ilgili ürün silinir.

```sql
DELETE FROM Producttab
WHERE Product_id = @productId
```

Ürün ID'si SQL parametresi olarak gönderilmektedir.

---

### 5. Ürün Güncelleme

Kullanıcının belirttiği ürünün:

* ID'si
* Adı
* Fiyatı

güncellenebilir.

```sql
UPDATE Producttab
SET
    Product_Name = @productName,
    Product_Price = @productPrice
WHERE Product_id = @productId
```

## 🔐 SQL Parametreleri

Projede SQL sorgularında kullanıcıdan gelen veriler doğrudan sorguya eklenmek yerine **parametreler** kullanılarak gönderilmektedir.

Örneğin:

```csharp
command1.Parameters.AddWithValue("@productName", Product_Namee);
command1.Parameters.AddWithValue("@productId", Product_idd);
command1.Parameters.AddWithValue("@productPrice", Product_Pricee);
```

Bu yaklaşım SQL sorgularının daha güvenli ve düzenli hazırlanmasını sağlar.

## 🗄️ Veritabanı

Projede SQL Server kullanılmaktadır.

Mevcut bağlantı yapısı:

```text
Server=localhost;
Database=master;
Integrated Security=True;
TrustServerCertificate=True;
```

> Projeyi kendi bilgisayarınızda çalıştırırken SQL Server kurulumunuza göre `Server` ve `Database` bilgilerini değiştirmeniz gerekebilir.

## 📂 Tablo Yapısı

### CategoryTable

| Kolon           | Açıklama     |
| --------------- | ------------ |
| `category_name` | Kategori adı |

### Producttab

| Kolon            | Açıklama    |
| ---------------- | ----------- |
| `Product_id`     | Ürün ID     |
| `Product_Name`   | Ürün adı    |
| `Product_Price`  | Ürün fiyatı |
| `Product_Status` | Ürün durumu |

## ▶️ Çalıştırma

1. SQL Server'ı çalıştırın.
2. Gerekli tabloları oluşturun.
3. Projeyi Visual Studio veya VS Code ile açın.
4. `Microsoft.Data.SqlClient` paketinin yüklü olduğundan emin olun.
5. Connection String bilgilerini kendi SQL Server ortamınıza göre düzenleyin.
6. Projeyi çalıştırın.

## 🎯 Projenin Amacı

Bu proje, **C# ile SQL Server arasındaki bağlantıyı öğrenmek** ve temel veritabanı işlemlerini uygulamalı olarak geliştirmek amacıyla hazırlanmıştır.

Özellikle aşağıdaki konular üzerinde pratik yapılmıştır:

* SQL Server bağlantısı
* `SqlConnection`
* `SqlCommand`
* `SqlDataAdapter`
* `DataTable`
* `DataRow`
* SQL parametreleri
* INSERT
* SELECT
* UPDATE
* DELETE
* C# ile kullanıcıdan veri alma

## 🔮 Geliştirilebilir Özellikler

Projeye ilerleyen aşamalarda şu özellikler eklenebilir:

* [ ] Menü tabanlı CRUD sistemi
* [ ] Try-Catch ile hata yönetimi
* [ ] `using` yapısı ile bağlantı yönetimi
* [ ] `AddWithValue` yerine güçlü tipli SQL parametreleri
* [ ] Kategori ve ürün ilişkisi
* [ ] Foreign Key kullanımı
* [ ] Ürün arama
* [ ] Ürün filtreleme
* [ ] Stored Procedure kullanımı
* [ ] Katmanlı mimariye geçiş
* [ ] Repository Pattern
* [ ] ASP.NET Core Web API'ye dönüştürme

## 👨‍💻 Öğrenme Süreci

Bu proje, C# öğrenme sürecinde **ADO.NET ve SQL Server** konularını pekiştirmek amacıyla geliştirilmiştir.

Temel CRUD işlemlerinden başlayarak proje zaman içerisinde daha gelişmiş bir backend uygulamasına dönüştürülebilir.
