# 📚 BookHaven – Bookstore Management System

BookHaven is a Windows Forms–based bookstore management system developed using C#, .NET, and SQL Server.
It supports user authentication, book management, sales processing, customer handling, and reporting.

---

## 🚀 Features

* 🔐 User Login System (Admin / Sales Clerk roles)
* 📖 Book Management (Add, Update, Delete, View)
* 👥 Customer Management
* 🛒 Order Management
* 💳 Payment Processing
* 📊 Sales & Inventory Reports
* 🧾 Sales Transactions Dashboard
* 🔒 Basic Security (Password handling support)

---

## 🛠️ Technologies Used

* **Frontend:** Windows Forms (.NET)
* **Backend:** C#
* **Database:** Microsoft SQL Server
* **ORM:** Dapper
* **IDE:** Visual Studio

---

## 📁 Project Structure

```
BookHaven/
│
├── Classes/
│   ├── BusinessLogic/
│   │   ├── ReportManager.cs
│   │   └── UserManager.cs
│   │
│   ├── DataAccess/
│   │   ├── AdminData.cs
│   │   ├── BookDataAccess.cs
│   │   ├── CustomerDataAccess.cs
│   │   ├── DashboardData.cs
│   │   ├── OrderDataAccess.cs
│   │   ├── PaymentDataAccess.cs
│   │   ├── SalesDataAccess.cs
│   │   ├── SupplierDataAccess.cs
│   │   └── UserDataAccess.cs
│   │
│   └── Models/
│       ├── BookModel.cs
│       ├── CustomerModel.cs
│       ├── OrderModel.cs
│       ├── PaymentModel.cs
│       ├── SalesTransaction.cs
│       ├── SupplierModel.cs
│       └── UserModel.cs
│
├── Forms/
│   ├── Admin/
│   ├── BookManagement/
│   ├── CustomerManagement/
│   ├── Login/
│   ├── OrderManagement/
│   ├── PaymentManagement/
│   ├── Reports/
│   ├── SalesTransaction/
│   ├── Security/
│   └── SupplierManagement/
│
├── Utils/
│   ├── Extensions/
│   │   └── DBExtensions.cs
│   ├── Validators/
│   └── PasswordHasher.cs
│
├── Resources/
│   ├── Icons/
│   └── Images/
│
├── Database/
│   ├── BookHavenDB.sql
│   └── SeedData.sql
│
├── Program.cs
└── App.config
```

---

## ⚙️ Installation & Setup

### 1️⃣ Clone the Repository

```
git clone https://github.com/your-username/BookHaven.git
```

---

### 2️⃣ Open the Project

* Open in **Visual Studio**
* Build the solution

---

### 3️⃣ Setup the Database

1. Open **SQL Server Management Studio**
2. Run:

```
Database/BookHavenDB.sql
```

3. Then run:

```
Database/SeedData.sql
```

---

### 4️⃣ Configure Connection String

Update your `App.config`:

```xml
<connectionStrings>
  <add name="DefaultConnection"
       connectionString="Server=YOUR_SERVER;Database=BookHavenDB;Trusted_Connection=True;"
       providerName="System.Data.SqlClient"/>
</connectionStrings>
```

---

## 🔑 Default Login Credentials

| Role        | Username   | Password  |
| ----------- | ---------- | --------- |
| Admin       | admin      | Admin@123 |
| Sales Clerk | salesclerk | Clerk@123 |

---

## 📸 Screenshots (Optional)

Add screenshots here:

```
/Screenshots/login.png
/Screenshots/dashboard.png
```

---

## 🔒 Security Note

* Passwords are currently stored as plain text (for academic/demo purposes).
* A `PasswordHasher` utility is included for future enhancement.

---

## 📌 Future Improvements

* 🔐 Implement password hashing fully
* 📦 Add API layer (optional)
* 🌐 Convert to web-based system
* 📊 Advanced reporting dashboards
* 🧪 Unit testing

---

## 👩‍💻 Author

**Dulangika Malanakande**

* Software Engineering Undergraduate
* Project: Academic Assignment

---

## 📜 License

This project is for educational purposes only.

---

