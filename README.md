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
