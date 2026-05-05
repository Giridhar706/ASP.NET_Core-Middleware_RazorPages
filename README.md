# MiddlewareApp

# 🌐 ASP.NET Core Middleware Application

## 📌 Overview

This project demonstrates how middleware works in ASP.NET Core.
It handles HTTP requests, logs request/response details, manages errors, and serves static files like HTML, CSS, and JavaScript.

---

## 🚀 Features

* Request and Response Logging
* Global Error Handling Middleware
* HTTPS Redirection for security
* Static File Serving from wwwroot
* Basic web page using HTML, CSS, JS

---

## 🛠️ Technologies Used

* ASP.NET Core
* C#
* Middleware Pipeline
* HTML, CSS, JavaScript

---

## 📁 Project Structure

MiddlewareApp/
│
├── Program.cs
└── wwwroot/
├── index.html
├── style.css
└── script.js

---

## ▶️ How to Run

1. Open project in Visual Studio
2. Click Run ▶️
3. Open browser and go to:
   [https://localhost:xxxx/index.html](https://localhost:xxxx/index.html)

---

## ✅ Output

* Static web page loads successfully
* Middleware logs requests and responses in console
* JavaScript interaction works (button click alert)

---

## 🔐 Security Features

* HTTPS Redirection enabled
* Basic content handling via middleware

---

## 🎯 Key Learning

* Understanding middleware pipeline
* Handling HTTP requests and responses
* Serving static files in ASP.NET Core
* Implementing basic security practices

---

# RazorApp

# 📄 ASP.NET Core Razor Pages Application

## 📌 Overview

This project demonstrates the use of Razor Pages in ASP.NET Core.
It allows users to view a list of items and add new items dynamically using form input.

---

## 🚀 Features

* Display list of items
* Add new item using form
* Dynamic update of data
* Razor syntax for server-side rendering
* PageModel for handling logic

---

## 🛠️ Technologies Used

* ASP.NET Core
* Razor Pages
* C#
* HTML

---

## 📁 Project Structure

RazorApp/
│
├── Pages/
│   ├── Index.cshtml
│   ├── Index.cshtml.cs
│   ├── AddItem.cshtml
│   ├── AddItem.cshtml.cs
│
├── Program.cs

---

## ▶️ How to Run

1. Open project in Visual Studio
2. Click Run ▶️
3. Open browser:
   [https://localhost:xxxx/Index](https://localhost:xxxx/Index)

---

## 🧠 How It Works

* Index page displays a list of items
* AddItem page allows user to add new item
* Data is stored in a static list
* After submission, user is redirected to updated list

---

## ✅ Output

* Initial items displayed (Book, Pen)
* New items added dynamically
* Updated list shown after form submission

---

## 🎯 Key Learning

* Razor syntax usage (@foreach, @model)
* PageModel for backend logic
* Handling form input with BindProperty
* Dynamic data rendering

---

## ⚠️ Note

This project uses a static list for simplicity.
In real applications, a database is used.

---

## 👩‍💻 Author

Giridhar Gopal
