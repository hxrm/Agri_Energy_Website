The Agri-Ene prototype has been developed using the Model-View-Controller (MVC) architectural pattern in combination with Entity Framework for data storage and access.  The web application technical solution comprises of many components to deliver fully functional application, components include a front-end, back-end, database, hosting, and security. (Troelsen & Japikse, 2021) 


## Front-end:
The front-end for the Agri-Energy prototype’s functionality leans on Razor views and controllers. When a user request is received, they are appropriately routed handled by the certain controller. The controller handles the request by carry out tasks relating to user input and back-end services to determine which view or webpage to render to the user. Razor view render or display view HTML for the user interface to deliver a webpage. Additionally, client-side technologies are used by the front-end to enhance user experience such as CSS for styling and JavaScript for dynamic interactions. The MVC pattern is modular and maintainable approach as there is a functional separation that makes it easy to incorporate change in to the website which will be essential for the dynamic nature of the agricultural market. (Troelsen & Japikse, 2021) 


 

Back-end: The back end for the Agri-Energy prototype’s developed using programming language C# and the ASP.NET Core framework, therefore components that comprise the back-end would be services, repositories, and models that handle business logic and data operations. Servies within the prototype provide functionality to ensure the application follows Agi-Energy’s business logic. Models represent entities in the application or rather they provide the back-end with a blueprint to guide how data will be structures and managed throughout application. A Repository is used to provide the back end with clean and efficient operations to access data from the databases. By using the Entity Framework, the retrieval of data is made easy, reducing load time for database operations and improving performance of website. (Troelsen & Japikse, 2021) 

 

 

 

Database: The purposes of Agri-Energy prototypes data has been stored using Microsoft SQL Server as the database management system however cloud storage will be utilised in final product. Entity Framework is used as the Object-Relational Mapping (ORM) tool to interact with the database. Entity Framework maps the data object to the database, this means the Entity Framework acts as a translator between the database and application simplifies database operations through abstraction over database schema. Microsoft SQL Server provides for reliable and scalable solution for storing and retrieving data for the Agri-Energy Website. (Troelsen & Japikse, 2021) 


Hosting: The Agri-Energy web app is hosted on web servers via ASP.NET Core hosting model. The hosting model environment incorporates the infrastructure to run the web app such as HTTP or user request to display web pages and the application lifecycle. Thus, the website can be assessed on the internet. Thus, hosting enables easy access for farmers which will broaden website reach and usability of the application. (Troelsen & Japikse, 2021). 

 

Security: Security measures have been incorporated to protect sensitive data and ensure secure user authentication of farmers and employees alike.  ASP.NET Core Identity framework has been utilized to manage all user, authentication and assign roles. Features such as farmer registration, login, role-based access control, and password encryption or hashing has been developed based on the Identity framework. The business value added is the effect protection of user data which will stimulate user trust and therefore a better user experience. (Troelsen & Japikse, 2021) A diagram of a blue sphere with gears and a key

Description automatically generated, Picture 

Figure 3:Password Hashing (Lock, 2017) 
