# Erp

Çeşitli microservisler ile kurgulanarak banka ve şirketlerin kullanabileceği erp çözümlerini içerir.

## Geliştirme Ortamı
Sistem özellikleri.
| Özellik   | Açıklama                      |
|-----------|-------------------------------|
| OS        | Windows 10 Enterprise         |
| CPU       | Intel(R) i7-8700K 3.70 GHz    |
| RAM       | 16 Gb                         |
| IDE       | Visual Studio Pro 2022        |
| Framework | .Net 8.0                      |

## Senaryo

Sistem, müşteri siparişi ile başlayan ve stok güncellemesi, muhasebe işlemleri ve raporlama adımları ile tamamlanan bir iş sürecini uçtan uca yönetir. 
Süreç, yeni bir ürün kaydı ile başlar ve Envanter Yönetimi servisinde stok bilgisi güncellenir. 
Müşteri, bu ürünü sipariş ettiğinde, CRM servisi stoğu kontrol eder ve satış işlemini gerçekleştirir. 
Ardından, Finans ve Muhasebe servisi ödeme işlemini yapar, müşteri faturası Fatura servisi ile oluşturulur. 
Stok belirli bir sınırın altına düşerse, Satın Alma modülü otomatik sipariş talebi başlatır. 
Tüm işlem tamamlandığında Raporlama modülü, satış, stok ve müşteri verileri üzerinden analiz raporları sunarak süreci sonlandırır.

## Çalışan Servisler

## Envanter

Güncel olarak çözüm içerisinde yer alan ve bir runtime'a sahip olan uygulamalara ait envanter aşağıdaki gibidir.

| **Servis**                      | **Tür**     | **Görev**                                                 | **Dev Adres**  |
----------------------------------|-------------|-----------------------------------------------------------|----------------|
 InvoiceService.Api               | REST        | Fatura sistemini yönetmek.                                | localhost:5002 |

 ## Sistemin çalıştırılması
 Hizmet Adı                 | Servis Adı   | Adresi                   |
|----------------------------|--------------|--------------------------|
| RabbitMQ, mesaj kuyruğu yönetimini sağlar. | rabbitmq    | amqp, localhost:15672  |

 ## Docker dosyaları

 # Docker-Compose'u sistemde build edip çalıştırmak için
docker-compose up --build

# Sonraki çalıştırmalarda aşağıdaki gibide ilerlenebilir
docker-compose up -d

# Container'ları durdurmak için
docker-compose down

## Dış sistem entegrasyonları

