# 🏛️ C# Kurumsal N-Katmanlı Mimari & Entity Framework Kampı
### Enterprise N-Tier Architecture & Entity Framework Bootcamp (301)

[![C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/.NET-Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework-6-blue?style=for-the-badge)](https://learn.microsoft.com/en-us/ef/ef6/)
[![Architecture](https://img.shields.io/badge/Pattern-Repository%20%26%20N--Tier-orange?style=for-the-badge)](#)

---

## 🇹🇷 Türkçe Açıklama

Bu depo, C# ile kurumsal düzeyde yazılım geliştirme süreçlerini kapsayan **N-Katmanlı Mimari (N-Tier)**, **Generic Repository Pattern** ve **Entity Framework (Code-First & Database-First)** uygulamalarını içeren kapsamlı eğitim ve pratik projesidir.

### 📂 Katman Mimarisi ve Projeler

1. **`C#Egitim301EntityLayer` (Varlık Katmanı):**
   * Veritabanı tablolarının nesne modellerini (`Product`, `Category`, `Order`, `Customer`, `Admin`) barındırır.
2. **`C#Egitim301DataAccesLayer` (Veri Erişim Katmanı - DAL):**
   * `IGenericDal<T>` ve `GenericRepository<T>` yapıları ile veritabanı işlemlerini soyutlar.
   * Entity Framework DbContext konfigürasyonlarını ve Migration geçmişini yönetir.
3. **`C#Egitim301BusinessLayer` (İş Mantığı Katmanı - BLL):**
   * `IGenericService<T>` ve yönetici sınıfları (`ProductManager`, `CategoryManager`) ile iş kurallarını denetler.
4. **`C#Egitim301PresentationLayer` (Sunum Katmanı - UI):**
   * Windows Forms tabanlı kullanıcı arayüzü ile CRUD işlemlerini tetikler.
5. **`C#Egitim301.EFProject` (EF Pratikleri):**
   * Seyahat/Lokasyon ve rehber yönetimini içeren Entity Framework pratik modülü.

---

## 🇬🇧 English Description

This repository contains comprehensive hands-on practices and enterprise implementation of **N-Tier Architecture**, **Generic Repository Pattern**, and **Entity Framework** in C#.

### 📂 Layer Breakdown & Projects

1. **`C#Egitim301EntityLayer` (Domain / Entity Layer):**
   * Holds business entities: `Product`, `Category`, `Order`, `Customer`, `Admin`.
2. **`C#Egitim301DataAccesLayer` (Data Access Layer - DAL):**
   * Implements the **Generic Repository Pattern** (`IGenericDal<T>`, `GenericRepository<T>`).
   * Manages Entity Framework database contexts and Code-First migrations.
3. **`C#Egitim301BusinessLayer` (Business Logic Layer - BLL):**
   * Validates operations and decouples data access via service contracts (`IGenericService<T>`).
4. **`C#Egitim301PresentationLayer` (Presentation Layer - UI):**
   * Windows Forms desktop interface for administrative product and category management.
5. **`C#Egitim301.EFProject`:**
   * Module covering entity relationships, LINQ queries, and location management.

---

**Geliştirici / Developer:** [Bora Irgın](https://github.com/BoraIrgin)
