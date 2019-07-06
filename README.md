# LibManage
LibManage is a helpful program for librarians to manage books, readers, and a convienient tool for statistics and reporting.

# What can we do?

Basically, we help you in manage readers and books, include:

* Create new reader account.
* Manage reader account.
* Adding new books into database.
* Listing books in the database.
* Manage lent books and returned books.

In advance, we also help you in:

* Making book lending report listed by genre.
* Making late returning book report.

Librarian (or manager) can also change the policy about adding new members, adding new books, or lending and returing books.

# Technologies

 * C# Winform
 * SQL Server

# Getting stated

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

## Presiquities INSTALL SQL SERVER version 2017
If you don't already have the SQL SERVER Database Server installed, you will need to install it to use this project.
Then install Visual studio version 2017 to run this project.
## Installing
* Change connection string to : SQLCMD -S 'YOUR SERVER NAME' -E -i createDBQLTV.sql. You can find YOUR SERVER NAME in microsoft sql server management studio.
* Run createDBQLTV.cmd file to set up database for this project. 
* Open Library Management.sln then change DATASOURCE = "YOUR SERVER NAME" in QLTVGUI/App.config .
* Start project and enjoy yourself.
# Contributing 
 * For reporting bug about an incorrect file not being processed, open a new issue.
 * PRs are always welcome to improve exisiting system.
# Authors
  * Võ Văn Tài Triển - University of Information Technology - Software Engineering - Student ID: 1752 1158
  * Nguyễn Thanh Trung - University of Information Technology - Software Engineering - Student ID: 1752 0021
