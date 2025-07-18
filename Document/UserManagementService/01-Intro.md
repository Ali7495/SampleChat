# 🛡️ User Management Microservice

A clean, scalable, and production-ready microservice for managing user registration, authentication, and authorization using **.NET 8**, **PostgreSQL**, **gRPC**, and **Dapper**. Built following Clean Architecture principles.

## 📌 Key Features
- Clean Architecture with clear separation of concerns
- gRPC-based service communication
- PostgreSQL with Dapper for high-performance data access
- Dockerized for easy deployment
- JWT-based authentication and role-based authorization

## ⚙️ Tech Stack
- .NET 8
- gRPC
- PostgreSQL
- Dapper
- Docker
- FluentValidation
- AutoMapper


## 🧩 Layers

### 1. Domain
- Contains core entities and value objects.
- No dependencies on other layers.

### 2. Application
- Contains use cases and interfaces for infrastructure (e.g., IUserRepository).
- Handles business rules, validation, and orchestration logic.

### 3. Infrastructure
- Implements interfaces from the Application layer (e.g., PostgreSQL repository using Dapper).
- Handles actual data access, external services, and IO.

### 4. API (Presentation)
- Exposes gRPC endpoints and configures middlewares.
- Maps use cases to gRPC calls.

## 📡 Communication
- Internal service communication is handled using gRPC.
- JWT is used for securing endpoints.

## 📐 Design Patterns
- Dependency Injection
- Repository Pattern
- CQRS (basic form)
- Mediator Pattern (planned)
