# RecipesBlog-DevOps
A blog about cooking recipes using ASP.NET and Contentful headless CMS.
We use contentful to store our data which we then access through a Content Delivery API (CDA). The web application project is built on .NET Core 3.1.
HTML, CSS, JavaScript are used for making the website.
A Dockerfile is used to create the image used for the application's container in Docker.
The process of building the application, building the image, and pushing it onto my Docker Hub is done using a GitHub Actions pipeline based on an already made one called ".NET" in the marketplace.
After the image is published on Docker Hub, a docker compose file can be run to start the container using that image.
Surfing to "localhost" (port 80 is used in compose), the website can be seen :)
