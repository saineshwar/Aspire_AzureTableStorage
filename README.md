# ☁️ Integrating Azure Data Table with .NET Aspire

This repository demonstrates how to integrate **Azure Data Table** with **.NET Aspire**, a modern framework by Microsoft for building cloud-native, observable, and scalable .NET applications.

## 🔍 What is .NET Aspire?

[.NET Aspire](https://devblogs.microsoft.com/dotnet/introducing-dotnet-aspire/) is an opinionated stack for building distributed applications in .NET. It supports service discovery, configuration management, cloud resources, and provides a unified development experience for microservices.

## 💾 What is Azure Data Table?

[Azure Table Storage](https://learn.microsoft.com/en-us/azure/storage/tables/table-storage-overview) is a NoSQL key-value store for rapid development using massive semi-structured datasets. It offers high availability, scalability, and a pay-as-you-go pricing model.

## 📖 Learn by Example

A detailed step-by-step guide is available here:

👉 [How to Integrate .NET Aspire with Azure Data Table](https://tutexchange.com/how-to-integrate-net-aspire-with-azure-data-table/)

The article explains:
- How to configure and register `Azure.Data.Tables` in an Aspire-based project
- Using `TableServiceClient` and `TableClient` with dependency injection
- Creating a custom service for data operations
- Interacting with table entities through minimal APIs

## 🛠️ Tech Stack

- [.NET Aspire](https://github.com/dotnet/aspire)
- ASP.NET Core
- Azure.Data.Tables (NuGet package)
- Visual Studio / VS Code
- Azure Storage Emulator or Azure Portal

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- Azure Storage Account or Emulator
- [Azure.Data.Tables](https://www.nuget.org/packages/Azure.Data.Tables/) NuGet package

### Run the App

1. Clone the repository:
   ```bash
   git clone https://github.com/saineshwar/Aspire_AzureTableStorage.git
   cd aspire-azure-data-table-integration
