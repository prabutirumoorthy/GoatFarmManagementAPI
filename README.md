# GoatFarmManagement

Clean Architecture Solution Template
Build CodeQL Nuget Nuget Twitter Follow

The goal of this template is to provide a straightforward and efficient approach to enterprise application development, leveraging the power of Clean Architecture and ASP.NET Core. Using this template, you can effortlessly create a Single Page App (SPA) with ASP.NET Core and Angular or React, while adhering to the principles of Clean Architecture. Getting started is easy - simply install the .NET template (see below for full details).

If you find this project useful, please give it a star. Thanks! ⭐

Getting Started
The following prerequisites are required to build and run the solution:

.NET 9.0 SDK (latest version)
Node.js (latest LTS, only required if you are using Angular or React)
The easiest way to get started is to install the .NET template:

dotnet new install Clean.Architecture.Solution.Template::9.0.8
Once installed, create a new solution using the template. You can choose to use Angular, React, or create a Web API-only solution. Specify the client framework using the -cf or --client-framework option, and provide the output directory where your project will be created. Here are some examples:

To create a Single-Page Application (SPA) with Angular and ASP.NET Core:

dotnet new ca-sln --client-framework Angular --output YourProjectName
To create a SPA with React and ASP.NET Core:

dotnet new ca-sln -cf React -o YourProjectName
To create a ASP.NET Core Web API-only solution:

dotnet new ca-sln -cf None -o YourProjectName
Launch the app:

cd src/Web
dotnet run
To learn more, run the following command:

dotnet new ca-sln --help
You can create use cases (commands or queries) by navigating to ./src/Application and running dotnet new ca-usecase. Here are some examples:

To create a new command:

dotnet new ca-usecase --name CreateTodoList --feature-name TodoLists --usecase-type command --return-type int
To create a query:

dotnet new ca-usecase -n GetTodos -fn TodoLists -ut query -rt TodosVm
To learn more, run the following command:

dotnet new ca-usecase --help
Database
The templates supports PostgresSQL, SQLite, and SQL Server (default option). Specify the database to use with the --database option:

dotnet new ca-sln --database [postgresql|sqlite|sqlserver]
When you run the application the database will be automatically created (if necessary) and the latest migrations will be applied.

Running database migrations is easy. Ensure you add the following flags to your command (values assume you are executing from repository root)

--project src/Infrastructure (optional if in this folder)
--startup-project src/Web
--output-dir Data/Migrations
For example, to add a new migration from the root folder:

dotnet ef migrations add "SampleMigration" --project src\Infrastructure --startup-project src\Web --output-dir Data\Migrations

Deploy
This template is structured to follow the Azure Developer CLI (azd). You can learn more about azd in the official documentation. To get started:

# Log in to Azure
azd auth login

# Provsion and deploy to Azure
azd up
Technologies
ASP.NET Core 9
Entity Framework Core 9
Angular 18 or React 18
MediatR
AutoMapper
FluentValidation
NUnit, FluentAssertions, Moq & Respawn
Versions
The main branch is now on .NET 9.0. The following previous versions are available:



## STEPS TO PUSH THE CODE INTO GITHUB 
You can add your project to **GitHub** by following these steps:  

---

## **🚀 Steps to Push Your Project to GitHub**
### **1️⃣ Create a GitHub Repository**
1. Go to [GitHub](https://github.com/)
2. Click on **New Repository**.
3. Enter your **repository name** (e.g., `CleanArchDemo`).
4. Choose **Public or Private** (depending on your preference).
5. Do **not** initialize with `README`, `.gitignore`, or `LICENSE` (we will add these manually).
6. Click **Create Repository**.

---

### **2️⃣ Initialize Git in Your Project**
Open **Terminal (Command Prompt, PowerShell, or Git Bash)** inside your project folder:
```sh
cd path/to/your/project
git init
```
This initializes a Git repository inside your project folder.

---

### **3️⃣ Add Your Files to Git**
```sh
git add .
git commit -m "Initial commit"
```
- `git add .` → Stages all files.
- `git commit -m "Initial commit"` → Saves your changes locally.

---

### **4️⃣ Connect to Your GitHub Repository**
Copy the **GitHub repository URL** you created (e.g., `https://github.com/yourusername/CleanArchDemo.git`).

Now, add this repository as a remote:
```sh
git remote add origin https://github.com/yourusername/CleanArchDemo.git
```
Verify the remote:
```sh
git remote -v
```
You should see:
```
origin  https://github.com/yourusername/CleanArchDemo.git (fetch)
origin  https://github.com/yourusername/CleanArchDemo.git (push)
```

---

### **5️⃣ Push Your Code to GitHub**
Now, push your local project to GitHub:
```sh
git branch -M main
git push -u origin main
```
This uploads your project to GitHub under the **main** branch.

---

### **6️⃣ (Optional) Add a `.gitignore` File**
Create a `.gitignore` file in your project root and add:
```
bin/
obj/
*.user
*.suo
*.vs
appsettings.json
```
This prevents unnecessary files from being uploaded.

To commit the `.gitignore`:
```sh
git add .gitignore
git commit -m "Added .gitignore"
git push
```

---

## **🎉 Done!**
Now, go to your **GitHub repository**, and you should see your project files there.

Would you like help with GitHub Actions for **CI/CD deployment**? 🚀
