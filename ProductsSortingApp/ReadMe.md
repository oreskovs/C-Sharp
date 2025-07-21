# Product Sorting Application

## Overview

This is a simple C# console application that reads product data from a JSON file, groups the products into perishable and non-perishable categories, and displays details along with total values and quantities for each group.

## Features

- Reads products from a `products.json` file.
- Groups products based on their perishability (`IsPerishable` property).
- Displays product name (truncated if longer than 10 characters), price, and quantity.
- Calculates and shows the total value and total quantity per group.
- Validates product data with encapsulated properties in the `Product` class to ensure price and quantity are positive numbers.
- Handles errors gracefully with user-friendly messages.

## Product JSON Format

Each product in the JSON file should have the following structure:

```json
{
  "Name": "Product Name",
  "Price": 25.99,
  "Quantity": 10,
  "IsPerishable": true
}
