## CSharp Exercise

### Working with LINQ

1. Write a C# program to create a model class with name `Product` with following properties:

- ProductId
- ProductName
- Brand
- Quantity
- Price

Inside program class create an instance of List collection class of type Product.
Create a method with name `SeedData` inside program class and populate the list with some initial data (as mentioned below) by following the `Product` model.

ProductId | ProductName | Brand | Quantity | Price
----------|-------------|-------|----------|--------
P001      |  Laptop     | Dell  |   5      | 35000
P002      |  Camera     | Canon |   8      | 28500
P003      |  Tablet     | Lenovo|   4      | 15000
P004      |  Mobile     | Apple |   9      | 65000
P005      |  Earphones  | Boat  |   2      | 1500

Then call the `SeedData` method in main and perform the below operations on the List collection using LINQ.

- Write the code to retrieve the Product names from Product List where Price is between 20000 to 40000.
- Write the code for retrieving the data from Product List where ProductName contains letter `a`.
- Write the code for retrieving all data from Product List arranged in alphabetical order based on ProductName.
- Write the code for retrieving the highest Price from Product List.
- Write the code to check whether the Product with ProductId `P003` exists in Product List or not. The output should be a Boolean value.

