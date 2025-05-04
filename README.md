# CRM Project

A web-based Customer Relationship Management (CRM) system developed using **ASP.NET Web Forms** and **C#**. This application facilitates the management of customer data, employee interactions, and administrative tasks within an organization.

## 📌 Features

* **User Authentication**: Secure login system for employees and administrators.
* **Dashboard**: Personalized dashboards for users post-login.
* **Customer Management**: Add, view, and manage customer details.
* **Employee Management**: Admin functionalities to manage employee records.
* **Master Pages**: Consistent layout using master pages for different user roles.([LinkedIn][1])

## 🛠️ Technologies Used

* **Frontend**: ASP.NET Web Forms (`.aspx`)
* **Backend**: C# (`.cs`)
* **Database**: MSSQL Database Server
* **Web Server**: IIS Express / Localhost via Visual Studio

## 🗂️ Project Structure

```
crm-project/
├── Admin/                          # Admin-specific pages and functionalities
├── Employee/                       # Employee-specific pages and functionalities
├── MasterPages/                    # Master pages for layout
├── App_Code/                       # Backend logic and helper classes
├── App_Data/                       # Database files (if any)
├── bin/                            # Compiled binaries
├── obj/                            # Temporary object files
├── AfterLoginEmployee.aspx         # Employee dashboard page
├── AfterLoginEmployeeMasterPage.Master  # Master page for employee after login
├── AfterloginHomePage.aspx         # General homepage after login
├── AfterloginMasterPage.Master     # Master page for general users after login
├── Web.config                      # Configuration file (connection strings, etc.)
└── ...
```



## 🚀 Getting Started

### Prerequisites

* Visual Studio 2015 or later
* .NET Framework 4.5 or higher
* SQL Server Express or higher

### Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/devjyotiprajapati/crm-project.git
   ```
2. **Open the Solution**

   * Open the `.sln` file in Visual Studio.
3. **Set Up the Database**

   * Create the necessary tables manually or import from a `.mdf` file (if available in `App_Data`).
   * Update the connection string in `Web.config`.
4. **Run the Application**

   * Press `F5` in Visual Studio or run through IIS Express.
