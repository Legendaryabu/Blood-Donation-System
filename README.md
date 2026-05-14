# Blood Donation Management System

A comprehensive .NET-based desktop application designed to streamline the management of blood donations, donor records, and inventory tracking. This project was developed to improve the efficiency and accuracy of blood bank operations.

## 🚀 Features
* **User Authentication:** Secure login system with role-based access.
* **Donor Management:** Register and maintain detailed records of blood donors.
* **Donation Tracking:** Track blood units from donation to screening and final issue.
* **Inventory Control:** Real-time monitoring of blood stock levels by blood type.
* **Audit Logging:** Detailed logs of system activities for security and transparency.
* **Reporting:** Generate summaries of donations and requests for better decision-making.

## 🛠️ Tech Stack
* **Language:** C#
* **Framework:** .NET 8.0 (Windows Forms)
* **Database:** MySQL / MariaDB (via Pomelo Entity Framework Core)
* **ORM:** Entity Framework Core

## 📂 Project Structure
* **Forms:** UI components for different modules (Dashboard, Donor, Inventory, etc.).
* **Models:** Data structures representing system entities like Donors, BloodUnits, and Users.
* **Services:** Business logic for authentication, auditing, and database operations.
* **Data:** Database context and migration history.

## ⚙️ Setup Instructions
1. Clone the repository.
2. Ensure you have the MySQL database configured.
3. Update the connection string in `AppDbContext` if necessary.
4. Build and run the solution using Visual Studio.

---
Developed as part of my Software Engineering studies at the South Eastern University of Sri Lanka (SEUSL).
