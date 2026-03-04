<h1 align="center">🎓 Student Management System</h1>

<p align="center">
  <b>Console Application built using C# and SQL Server</b><br>
  A practical .NET learning project
</p>

<hr>

<h2>📌 Project Overview</h2>
<p>
Student Management System is a simple Console Application developed using 
<strong>C#</strong> and <strong>SQL Server</strong>.  
The system allows users to add and view students while storing data in a database 
using a Stored Procedure.
</p>

<hr>

<h2>🎯 Project Goals</h2>
<ul>
  <li>Apply Object-Oriented Programming (OOP)</li>
  <li>Practice Encapsulation & Access Modifiers</li>
  <li>Use Loops and Conditions</li>
  <li>Work with Lists</li>
  <li>Connect C# to SQL Server using ADO.NET</li>
  <li>Execute Stored Procedures</li>
  <li>Practice teamwork</li>
</ul>

<hr>

<h2>🏗️ Technologies Used</h2>
<ul>
  <li><strong>C#</strong></li>
  <li><strong>.NET Console Application</strong></li>
  <li><strong>SQL Server</strong></li>
  <li><strong>ADO.NET</strong></li>
  <li><strong>Stored Procedures</strong></li>
</ul>

<hr>

<h2>🗄️ Database Structure</h2>

<h3>Database Name:</h3>
<p><code>StudentDB</code></p>

<h3>Table: Students</h3>

<table border="1" cellpadding="8">
<tr>
<th>Column</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr>
<td>Id</td>
<td>INT (PK, Identity)</td>
<td>Auto-generated Student ID</td>
</tr>
<tr>
<td>Name</td>
<td>NVARCHAR(100)</td>
<td>Student Name</td>
</tr>
<tr>
<td>Age</td>
<td>INT</td>
<td>Student Age</td>
</tr>
<tr>
<td>Grade</td>
<td>NVARCHAR(10)</td>
<td>Student Grade</td>
</tr>
</table>

<hr>

<h2>⚙️ Application Features</h2>

<h3>➕ Add Student</h3>
<ul>
  <li>User enters Name, Age, and Grade</li>
  <li>Data is saved in the database</li>
  <li>Stored Procedure is executed from C#</li>
</ul>

<h3>📋 Show Students</h3>
<ul>
  <li>Retrieve all students from database</li>
  <li>Display using loop</li>
  <li>Call <code>PrintInfo()</code> method</li>
</ul>

<hr>

<h2>🧠 Concepts Implemented</h2>
<ul>
  <li>Classes & Objects</li>
  <li>Constructor</li>
  <li>Encapsulation</li>
  <li>Access Modifiers</li>
  <li>Loops (while / foreach)</li>
  <li>Conditions (if / switch)</li>
  <li>Lists</li>
  <li>Database Connectivity</li>
  <li>Stored Procedure Call</li>
</ul>

<hr>

<h2>👥 Team Members</h2>

<ul>
  <li><strong>Mariam</strong> – Database</li>
  <li><strong>Shahd</strong> – Connection</li>
  <li><strong>Abdelrahman</strong> – C# Development - Student Class</li>
  <li><strong>Baher</strong> – C# Development - Menu + Conditions + Loops</li>
  <li><strong>Naglaa</strong> – C# Development - Logic</li>
</ul>

<hr>

<h2>📂 Project Structure</h2>

<pre>
StudentManagementSystem
│
├── Student.cs
├── DatabaseHelper.cs
├── Program.cs
└── README.md
</pre>

<hr>

<h2>▶️ How to Run</h2>

<ol>
  <li>Create Database <code>StudentDB</code></li>
  <li>Create Table <code>Students</code></li>
  <li>Create Stored Procedure <code>AddStudent</code></li>
  <li>Update Connection String</li>
  <li>Run the Console Application</li>
</ol>

<hr>

<h2>📈 Learning Outcome</h2>

<p>
Through this project, we learned how to:
</p>

<ul>
  <li>Build a structured console application</li>
  <li>Apply OOP principles correctly</li>
  <li>Connect C# with SQL Server</li>
  <li>Work in a development team environment</li>
</ul>

<hr>

<p align="center">
  🚀 Built with passion while learning .NET
</p>
