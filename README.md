# Progress Assignment

## Description

This is a simple web application built using the Blazor framework and .NET 7. The goal of the project is to demonstrate how to display information about collections of products using the Blazor framework.

![Screenshot of Product page.](products.png "Screenshot of Product page.")

## Hosting Model

The chosen hosting model for this project is Blazor WebAssembly. This model allows the application to run directly in the browser, providing a responsive and interactive user experience.

## Elements and Components

### The project consists of the following elements and components:

- Product Entity: A C# class that represents the structure of the product.
- Product Service: This class is responsible for fetching the product collection.
- ProductCard component: This component displays information about a single product. Each product is represented with its name, price, image, and category. In-stock products are highlighted differently from out-of-stock products.
- Product page: This page displays all products.
- Product data: Product information is provided statically within the project in a json file with the following structure:
  ```
    {
    "id": number,
    "title": string,
    "price": number,
    "stock": number,
    "category": string,
    "image": string
    }
  ```
- Telerik UI for Blazor:  Telerik UI for Blazor provides numerous ready-to-use components, like TelerikGridLayout and TelerikCard, which are used in this project. The documentation is well labeled and easy to follow. The demos are clear and concise, and they demonstrate the features of the components well. The code samples in the demos are well-written, easy to find, and easy to understand.
