# APIUser

Este proyecto es una API hecha con Visual Studio 2019 y .NET Core 2.1. Se ha pedido desarrollar un CRUD para la entidad User con los  atributos Id, Name, LastName, Address, CreateDate, UpdateDate.

Para simplificar el proyecto y para que su funcionalidad sea más rápida, se ha realizado con la técnica "Code First", sin necesidad de la utilización de Entity Framework Core, utilizando como inyector de dependencias la propia herramienta con la que ya cuenta .NET Core, y no utilizar otros como Unity o Autofac. Se ha separado por capas el proyecto para facilitar la asignación de responsabilidades, creación de DTOs y métodos de extensión y para facilitar la utilización de herramientas de pruebas unitarias. Para esto último se utilizó NUnit para la ejecución de las pruebas y se han utilizado los Mocks como objetos de "simulación" con la herramienta Moq. Otras herramientas utilizadas para lograr el propósito ha sido, por ejemplo, NewtonsoftJson para la serialización y deserialización de los modelos.

Esta API pretende recoger y ejecutar la funcionalidad CRUD base. Se debe de crear con la autenticación de Windows la base de datos "APIUser" bajo un SQLServer para que la API cree la tabla necesaria para interactuar. Adicionalmente, se menciona que en la creación de la propia tabla también se insertan registros de prueba para probar la API.

También se añade que dentro de la carpeta del proyecto se encuentra la collección utilizada para la realización de pruebas de la API con Postman.
