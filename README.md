# Rental Car Project Backend

##  Giriş 

- **Entities, DataAccess, Business, Core ve WebAPI katmanlarından oluşan araba kiralama projesidir. Bu projede Katmanlı mimari yapısı ve SOLID prensiplerine dikkate alınarak yazılmıştır. JWT entegrasyonu; Transaction, Cache, Logging, Validation ve Performance Aspect'lerinin implementasyonu gerçekleştirilmiştir.** 
- **Validation için FluentValidation desteği, IoC için ise Autofac desteği eklenmiştir.**


### Katmanlar

- **Core**: Projenin çekirdek katmanı, evrensel operasyonlar için kullanılmaktadır.
- **DataAccess**: Projenin, Veritabanı ile bağını kuran katmandır.
- **Entities**: Veritabanındaki tablolarımızın projemizde nesne olarak kullanılması için oluşturulmuştur. Ayrıca DTO nesnelerinide barındırmaktadır.
- **Business**: Projemizin iş katmanıdır. Türlü iş kuralları; Veri kontrolleri, validasyonlar, IoC Container'lar ve yetki kontrolleri bu katmanda gerçekleştirilir


## Kullanılan Yapılar

<ul>
    <li>Back-End
    <ul>
        <li>C# </li>
        <li>Restful Web Api .Net C</li>
        <li>Katmanlı Mimari</li>
        <li>Temel Result Türü</li>
        <li>Interceptor, Aspectler</li>
        <li>Caching, Validation, Logging, Performance,Transaction ve Authorize Aspect</li>
        <li>Autofac</li>
        <li>Fluent Validation</li>
        <li>Json Web Token</li>
        <li>Repository Design Pattern</li>
        <li>Asenkron Yapı</li>
    </ul>
    </li></ul>








#### Prerequest 

 - [ ] EntityFrameworkCore.SqlServer 
 - [ ] FluentValidation 
 - [ ] Autofac 
 - [ ] Autofac.Extensions.DependencyInjection 
 - [ ] Autofac.Extras.DynamicProxy 
 - [ ] Serilog





