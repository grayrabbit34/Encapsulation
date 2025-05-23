# 🚗 C# Encapsulation Örneği – Car Sınıfı

Bu proje, **C# dilinde nesne yönelimli programlamanın kapsülleme (encapsulation)** prensibini göstermek amacıyla geliştirilmiş basit bir uygulamadır.

---

## 🧱 Proje Hakkında

Projede `Car` adlı bir sınıf tanımlanmıştır. Bu sınıf, bir arabanın:
- Marka
- Model
- Renk
- Kapı sayısı

gibi özelliklerini kapsülleyerek kontrol altına alır. Özellikle `set` bloklarında yapılan kontroller sayesinde **hatalı veri girişi engellenir.**

---

## 🧠 Kullanılan Kavramlar

### ✅ Class
`Car` sınıfı, araba nesnelerinin şablonudur.

### ✅ Field
Sınıf içindeki özel veriler `_brand`, `_model`, `_colour`, `_doorNumber` gibi **private field**’larda saklanır.

### ✅ Property
Bu verilere dışarıdan erişim `get` ve `set` içeren **public property**’ler aracılığıyla kontrollü bir şekilde sağlanır.

### ✅ Constructor (Yapıcı Metot)
Sınıfın `overloaded constructor` yapısı sayesinde, araba nesneleri doğrudan ilk değerlerle oluşturulabilir. Constructor içinde atamalar **property üzerinden yapılır** böylece validasyon kuralları devreye girer.

### ✅ Encapsulation
`private` alanlara doğrudan erişim engellenmiş, sadece **doğrulamalı property**’ler ile veri güvenliği sağlanmıştır.

---
