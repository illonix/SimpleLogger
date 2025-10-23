# 🪵 Logger Application (C# .NET)

A simple yet professional **C# .NET Logger Application** designed to demonstrate clean coding practices, file handling, error management, and object-oriented design.  
This project showcases a foundational utility often used in real-world software — a **logging system** that records application events, warnings, and errors with time-stamped entries and colored console output.

---

## ✨ Features

- 🕒 **Timestamped Logs** — Each message is automatically tagged with the current date and time.
- 🎨 **Color-Coded Console Output**  
  - 🟢 Info → Green  
  - 🟡 Warning → Yellow  
  - 🔴 Error → Red
- ⚙️ **Configurable Log Levels** — Filter logs to display only messages above a chosen importance level.
- 📁 **Daily Log Rotation** — Automatically creates a new log file each day (e.g., `log_20251022.txt`).
- 🧩 **Reusable Class Design** — Easily integrate `Logger.cs` into any future .NET project.
- 💬 **Exception Handling Demo** — Includes examples of clean error logging and user-friendly console feedback.

---

## 🧠 How It Works

### 1. Logger Class (`Logger.cs`)
Handles all logging operations:
```csharp
Logger logger = new Logger("log.txt", LogLevel.Info);
logger.LogInfo("Application started");
logger.LogWarning("This is a test warning");
logger.LogError("Something went wrong!");
```

Each log entry is written both to:
- The console (with colors)
- The `log.txt` file (inside `/bin/Debug/net8.0/`)

---

### 2. Program.cs
Demonstrates real-world use:
- Prompts for user input
- Handles exceptions (e.g., divide-by-zero)
- Writes logs to file and console simultaneously

Example console session:
```
=== Simple Logger Demo ===
Enter your favorite number: 10
Enter your second favorite number: 2
The result of 10 divided by 2 is 5.
Logs written to log_20251022.txt
```

---


## ⚙️ Requirements

- Visual Studio 2022 or later  
- .NET 6 or .NET 8 SDK  
- Windows, macOS, or Linux  

---

## 🧪 How to Run

1. **Clone or open** the project in Visual Studio  
2. Click **Run ▶️** (or press **F5**)  
3. Follow the prompts in the console  
4. Open the generated log file in  
   ```
   bin/Debug/net8.0/
   ```

---


## 🧠 Learning Highlights

This project demonstrates:
- ✅ Object-oriented design (class reuse)
- ✅ File I/O operations
- ✅ Exception handling and validation
- ✅ Console UI enhancements
- ✅ Extensible architecture for logging systems

---

## 👤 Author

**Jude Skrzat**  
Human Interface Computing | C# .NET  
📅 Created: October 2025  

---
