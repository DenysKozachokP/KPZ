# Principles of programming in Lab1.
 This document reveals how the MoneyClassLibrary project adheres to well-known programming principles. 

## DRY (Don't Repeat Yourself). 
The application of the DRY principle in the currency classes ['Dollar'](./MoneyClassLibrary/Dollar.cs) and ['UAH'](./MoneyClassLibrary/UAH.cs) is revealed. They inherit common behavior from the abstract class ['Currency'](./MoneyClassLibrary/Currency.cs), avoiding unnecessary code repetition. 

## KISS (Keep It Simple, Stupid).
 The project code supports simplicity and clarity, such as the PrintAllInvoices method in the ['Reporting'](./MoneyClassLibrary/Reporting.cs) which outputs reporting information or ReducePrice in the ['Product'](./MoneyClassLibrary/Product.cs) which only reduces the price of the product without undue complexity. 

 ## SOLID. 

 ## Single Responsibility Principle (SRP).
  The ['Product'](./MoneyClassLibrary/Product.cs) is responsible only for information and operations related to the product, adhering to SRP. 

 ## Open/Closed Principle (OCP). 
 The ['Currency'](./MoneyClassLibrary/Currency.cs) is open for expansion (creating new currencies as descendants), but closed for modification. 

 ## Liskov Substitution Principle (LSP).
 Descendants of the ['Currency'](./MoneyClassLibrary/Currency.cs), such as ['Dollar'](./MoneyClassLibrary/Dollar.cs) or ['UAH'](./MoneyClassLibrary/UAH.cs), can be interchangeable without affecting the correctness of the program. 

 ## Composition Over Inheritance. 
 This project uses a composition, such as the ['Reporting'](./MoneyClassLibrary/Reporting.cs), which contains ['Warehouse'](./MoneyClassLibrary/Warehouse.cs) or ['Product'](./MoneyClassLibrary/Product.cs), which contains ['Money'](./MoneyClassLibrary/Money.cs), instead of inheritance. 

 ## Fail Fast. 
 Methods such as the constructor in ['Currency'](./MoneyClassLibrary/Currency.cs) use argument checks to quickly detect errors without changing references.