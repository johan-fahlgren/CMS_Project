# [CMS Project](https://github.com/johan-fahlgren/CMS_Project)

A school project by [Johan Fahlgren](https://github.com/johan-fahlgren) 
and [Kim Bj�rnsen](https://github.com/Bjornsen016) focusing on two different Content
Managment systems or CMS's. 

1. **Umbraco** - The leading open-source CMS bulit for .NET(ASP.NET core). 
2. **Strapi** - The leading open-source headless CMS using JavaScript. 
___
## Umbraco Project

**A simple site containing a Home page with some posts and a About page.**

### Usings

* The project is bulit upon Paul Seals [Umbraco 10 Tutorial](https://github.com/prjseal/Umbraco-10-Tutorial/tree/main)
to use existing Html, CSS and JS since this isn't the courses main focus. 
* The Project also uses [JSON Placholder](https://jsonplaceholder.typicode.com/) as its external API for data. 


### Logins

* **Username:** admin@cms.com
* **Username:** editor@cms.com
* **Password:** ECUtbildning2022!

____
## Strapi Project

**A simple site containing a Home page with an article fetched from the Strapi Backend, a About page also fetched from Strapi and a 3rd party API page that shows quotes.**

### Usings

> **Strapi**
> 1. Start the Strapi-backend server by doing the following
> 2. `cd` into the `strapi-backend` folder
> 3. use the `npm run develop` command
> 4. When it has started up you can login using the credentials below

> **Blazor**
> 1. When the Strapi server is up and running you can start the Blazor project.
> 2. Start it up in the way you want to. I have been using Visual Studios 'Start without Debugging' (Ctrl + F5). Make sure to choose 'BlazorFrontend' as the project due to the Umbraco project also being in the same solution.
>
> When the site has started you will be at the startpage with an Article. This is fetched from Strapi.
> In the upper right corner you can click 'About' to get to the About us page that also fetches from Strapi.
>
> On the left side you can navigate to '3rd Party Api' to get to a page that gets data from an external API. 
> * The Project uses [JSON Dummy](https://dummyjson.com) as its external API for data. 



### Logins

**Strapi Admin**
* **Username:** admin@cms.com
* **Password:** Passw0rd!
