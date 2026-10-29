# DotnetProject-237
🛡️ Indian Crime Records System

A Modern Digital Solution for Law Enforcement

The Indian Crime Records System is a secure, web-based portal designed to transition law enforcement agencies from fragmented paper-based records to a unified digital system. It streamlines the process of registering FIRs, tracking active investigations, and maintaining a centralized database of known offenders.

🌟 Key Features

Secure Officer Portal: Role-based authentication requiring an Official Badge ID and password (e.g., restricted access for DGP and Investigating Officers).

Command & Control Dashboard: Real-time metrics displaying Total FIRs Logged, Active Investigations, Cases Closed, and Criminal Profiles, alongside a visual status distribution chart.

Digital FIR Registration: A streamlined form to capture critical incident details, including the Victim's Name, Police Station (Thana), Crime Type, and applicable legal frameworks (IPC / BNS Sections).

Active Case Tracking: A tabular interface to monitor the progress of ongoing investigations, allowing authorized personnel to update case statuses (e.g., "Under Investigation", "Charge Sheet Filed", "Closed").

Known Offenders Database: A highly searchable repository of criminal profiles, logging physical descriptions, Aadhar numbers, and historical offenses to aid in rapid identification.

💻 Technology Stack

Frontend: HTML5, CSS3, Bootstrap 5, Razor Views

Backend: ASP.NET Core MVC (C#)

Database: MySQL

ORM: Entity Framework Core

Architecture: Model-View-Controller (MVC)

⚙️ Local Setup & Installation

To run this project locally on your machine, follow these steps:

Prerequisites

.NET SDK installed.

MySQL Server installed and running.

Instructions

Clone the repository:

git clone https://github.com/KrinaKansara/DotnetProject-237.git
cd DotnetProject-237


Configure the Database Connection:
Open appsettings.json and update the DefaultConnection string with your local MySQL credentials (Server, User, Password, and Database name).

Apply Database Migrations:
Open your terminal in the project directory and run Entity Framework Core commands to generate the database schema:

dotnet ef database update


Run the Application:

dotnet run


The application will start on http://localhost:<port>.

⚖️ Legal Disclaimer

RESTRICTED ACCESS: This is an academic project simulating a law enforcement application. Authorized Law Enforcement Personnel Only. Unauthorized access is punishable under the Information Technology Act, 2000.

# Poster
<img width="1792" height="2400" alt="poster_237 (1)" src="https://github.com/user-attachments/assets/599d1a33-e2eb-469c-ae84-1937cd3a72d2" />

