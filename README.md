# 💬 Real-Time Chat Application

A secure, modern, microservices-based real-time chat application built using **.NET 8**, **gRPC**, **PostgreSQL**, and **SignalR**.  
Designed to serve organizations (like our own company) that avoid third-party solutions due to privacy or security concerns.

---

## 🚀 Motivation

At our company, we refrain from using public chat applications like Telegram, WhatsApp, or Slack due to data security concerns. This inspired me to create a **self-hosted, secure, and modern real-time chat solution** that:

- Runs **entirely on-premises**
- Requires **no installation** on end-user devices
- Provides **simple browser access**
- Supports **real-time messaging**, **user management**, and **extensibility** for future growth

---

## 🧱 Architecture Overview

This project is based on **Microservices** architecture following **Clean Architecture** principles and **Domain-Driven Design (DDD)** in key areas. It is designed for high modularity, scalability, and testability.

### 🗂️ Services

| Service             | Description                                                |
|---------------------|------------------------------------------------------------|
| 🧑‍💼 User Management  | Handles user registration, login, roles, and authentication |
| 💬 Chat Service     | Manages chat rooms, messages, and real-time delivery       |
| 🎯 API Gateway      | Acts as the single entry point for clients (Reverse Proxy) |
| 📊 Logging Service  | Centralized logs for all microservices                     |
| 🧪 Unit Tests       | Covers core logic across services                          |
| 🐘 PostgreSQL       | Primary data store for services                            |
| 🐳 Dockerized Setup | Docker support for each service and dev environment        |

---

## 📦 Technologies

- **.NET 8**
- **gRPC** – For inter-service communication
- **SignalR** – Real-time communication
- **PostgreSQL** – Relational database
- **Dapper** – Lightweight ORM
- **Docker + Docker Compose** – Containerization
- **xUnit / FluentAssertions** – Testing framework
- **Azure DevOps / GitHub Actions** (future) – CI/CD
- **Clean Architecture** & **DDD** – Codebase organization

---

## 🧪 Features (Phase 1)

- [ ] User registration with email or mobile (one required)
- [ ] Password hashing and secure login
- [ ] Token-based authentication (JWT)
- [ ] Real-time 1-to-1 messaging using SignalR
- [ ] Dockerized environment with PostgreSQL and pgAdmin
- [ ] Logging support per service
- [ ] CI/CD with GitHub Actions or Azure DevOps
---

## 📈 Future Roadmap (Phase 2+)

- [ ] Group messaging
- [ ] File and image sharing
- [ ] Message read receipts
- [ ] Chat history search
- [ ] WebSocket fallback support
- [ ] Admin dashboard
- [ ] Local desktop client (via WebView / Electron)

---

# 📂 For more details, please look at the Document folder.
