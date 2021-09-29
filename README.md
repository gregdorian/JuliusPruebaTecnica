# JuliusPruebaTecnica
Prueba Tecnica de German Lopez para julius2grow

Se creo en backend metodología Clean Code y usando algunos patrones de diseño como DI y Repositorio. Se utilizo EntityFramework (EF) 5+ y .Net 5.0, y la metodología 
codefirst.

Se Crea un front-end con Javascript utilizando Jquery y boostrap. se crea un cliente en Javascript para consumir la API donde se debe autenticar con clave Json Web token 
y encriptación HmacSha256

Pasos para Clonar el proyecto:

0. Tener instalado .Net 5.0 y visual studio 2019
1. Eliminar (si existen carpetas de migración) y realizar el *Add-migration*
  si compila bien la primera migración realizar *update-database*
2. revisar que agrego las tablas a la base de datos donde realiza la migración, esta definida en la instancia que viene por defecto VisualStudio
   (localdb)\\MSSQLLocalDB
3. f5 para ejecutar por el proyecto de Inicio Web Wpi *co.JuliuPruebaTecnica.WebApi*
4. colocar la url del endpoint *http://localhost:63067/api/PostNews* debe arrojar listado de post.

Si no arroja datos ejecutar los siguientes insert en la BD:

    USE [JuliusDB]
      GO
      INSERT INTO [dbo].[PostNoticias] ([ImagenPost], [Titulo], [Contenido], [FechaCreacion]) VALUES (null,'Titulo2','Contenido 1','2020-01-01')
        GO
      INSERT INTO [dbo].[PostNoticias] ([ImagenPost], [Titulo], [Contenido], [FechaCreacion]) VALUES (null,'Titulo1','Contenido 2','2021-02-03')
        GO
      INSERT INTO [dbo].[PostNoticias] ([ImagenPost], [Titulo], [Contenido], [FechaCreacion]) VALUES (null,'Titulo5','Contenido 3','2020-9-12')
        GO
     INSERT INTO [dbo].[PostNoticias] ([ImagenPost], [Titulo], [Contenido], [FechaCreacion]) VALUES (null,'Titulo9','Contenido 4','2021-4-5')
        GO
#PENDIENTE
Consumo del api desde el FrontEnd
