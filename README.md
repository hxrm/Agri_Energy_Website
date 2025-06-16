The Agri-Ene prototype has been developed using the Model-View-Controller (MVC) architectural pattern in combination with Entity Framework for data storage and access.  The web application technical solution comprises of many components to deliver fully functional application, components include a front-end, back-end, database, hosting, and security. (Troelsen & Japikse, 2021) 

![image](https://github.com/user-attachments/assets/ad999f14-c608-4595-9a18-e6b5d9e34319)
## Front-end
The front-end for the Agri-Energy prototype’s functionality leans on Razor views and controllers. When a user request is received, they are appropriately routed handled by the certain controller. The controller handles the request by carry out tasks relating to user input and back-end services to determine which view or webpage to render to the user. Razor view render or display view HTML for the user interface to deliver a webpage. Additionally, client-side technologies are used by the front-end to enhance user experience such as CSS for styling and JavaScript for dynamic interactions. The MVC pattern is modular and maintainable approach as there is a functional separation that makes it easy to incorporate change in to the website which will be essential for the dynamic nature of the agricultural market. (Troelsen & Japikse, 2021)  

## Back-end
The back end for the Agri-Energy prototype’s developed using programming language C# and the ASP.NET Core framework, therefore components that comprise the back-end would be services, repositories, and models that handle business logic and data operations. Servies within the prototype provide functionality to ensure the application follows Agi-Energy’s business logic. Models represent entities in the application or rather they provide the back-end with a blueprint to guide how data will be structures and managed throughout application. A Repository is used to provide the back end with clean and efficient operations to access data from the databases. By using the Entity Framework, the retrieval of data is made easy, reducing load time for database operations and improving performance of website. (Troelsen & Japikse, 2021) 

## Database
The purposes of Agri-Energy prototypes data has been stored using Microsoft SQL Server as the database management system however cloud storage will be utilised in final product. Entity Framework is used as the Object-Relational Mapping (ORM) tool to interact with the database. Entity Framework maps the data object to the database, this means the Entity Framework acts as a translator between the database and application simplifies database operations through abstraction over database schema. Microsoft SQL Server provides for reliable and scalable solution for storing and retrieving data for the Agri-Energy Website. (Troelsen & Japikse, 2021) 

## Hosting
The Agri-Energy web app is hosted on web servers via ASP.NET Core hosting model. The hosting model environment incorporates the infrastructure to run the web app such as HTTP or user request to display web pages and the application lifecycle. Thus, the website can be assessed on the internet. Thus, hosting enables easy access for farmers which will broaden website reach and usability of the application. (Troelsen & Japikse, 2021). 

## Security
Security measures have been incorporated to protect sensitive data and ensure secure user authentication of farmers and employees alike.  ASP.NET Core Identity framework has been utilized to manage all user, authentication and assign roles. Features such as farmer registration, login, role-based access control, and password encryption or hashing has been developed based on the Identity framework. The business value added is the effect protection of user data which will stimulate user trust and therefore a better user experience. (Troelsen & Japikse, 2021) A diagram of a blue sphere with gears and a key

## Account Creation
![image](https://github.com/user-attachments/assets/ad999f14-c608-4595-9a18-e6b5d9e34319)

### Navigating to Registration:
   - Find and click on the "Register" link on the login page. 

### Complete Registration Form:
-	Fill in the required information and click on register to create your account.
-	Enter your name, surname, email address, and choose a secure password.
![image](https://github.com/user-attachments/assets/92ced83d-8af2-4b1f-861c-31fc27da5d8f)

### Submission:
   - Click the "Register" button to create your account.

![image](https://github.com/user-attachments/assets/a849837d-f72d-40a0-a13f-9406c0d02269)

## Logging In
![image](https://github.com/user-attachments/assets/7ecbfde8-0ef2-4a9f-9942-9ca82eb8d03a)

 
Open the website:
-	Open your preferred web browser.
-	Enter the website's URL.
At the Login Page and enter your credentials:
-	Input your registered email address and password in the respective fields.
-	Click Login."
-	![image](https://github.com/user-attachments/assets/8fa747e1-ddbf-4104-9bee-37cde1fe21d6)

 
## Home Dashboard Overview
### Home Dashboard
Upon logging in, you will see the home dashboard page which serves as the central hub with links to key sections of the website and module functions. 
![image](https://github.com/user-attachments/assets/5a5a7478-3ce1-490f-b61b-f19c80221646)
 
## Navigation
Use the navigation menu to access different sections of the website.
Navigation:
   - Easily navigate to “Create New Module”, ”View Modules”, “Record Study Modules” “View Study Progress” or “View Study Progress Graph”.

## Module Creation
### Accessing Module Creation
Navigate to the "Create Module" section”
-	Click on "Create New Module." Via the home page or navigation menu.
![image](https://github.com/user-attachments/assets/dd1df736-307c-4261-8fb0-d5a9f5618a36)

 
### Semester Details
When creating a module for the first time, you'll be prompted to provide your semester details:
-	Fill in module details such as start date, end date, and any additional information.
	![image](https://github.com/user-attachments/assets/294b70a3-bed1-4561-bb41-ddc1811cb864)
 
### Creating a New Module
Fill in module details in the form page:
-	Module Code, enter a unique code for the module (e.g., PROG6212).
-	Module Name, supply a descriptive name for the module (e.g., Programming 2B).
-	Number of Credits, specify the credit value for the module (e.g., 15).
-	Class Hours per Week, indicate the number of hours of in-class instruction per week (e.g., 5).
  ![image](https://github.com/user-attachments/assets/33de4be2-a4fa-4c64-8ef8-3d1588dec687)

 
### Saving and Submitting
To save module click “Create Module” and then “Next” to return to homepage.
Click “Create Module”:
-	Continue creating module by entering the new module data within the form or click “Next” if done.
  ![image](https://github.com/user-attachments/assets/440cf95e-c617-452e-af89-90ecbea59c91)

Confirmation Message: A confirmation message will appear, acknowledging the successful creation of the module.
![image](https://github.com/user-attachments/assets/88d7d2ec-d50e-45d3-a060-b22542e4dd97)

 

## Module Viewing
### Accessing Modules
Navigate to the "View Modules" section to see a list of all modules for the semester.
 ![image](https://github.com/user-attachments/assets/57844fd9-cd32-4878-bd3c-a7cd57a4def7)


## Record of Studied Hours

To record your studied hours for a specific module, follow these steps:

### Record Studied Hours for a Module: 
Navigate to the " Record Study Hours " section and select the desired module from the dropdown list.  
![image](https://github.com/user-attachments/assets/43fdb103-e0de-4ed0-9222-247c61d2db06)

 ![image](https://github.com/user-attachments/assets/98b40203-503f-4d29-890a-eb7bf31d3620)



### Select Date:
Input or click on the calendar icon and a calendar interface will appear. Select the date you want to record your study hours for.
  ![image](https://github.com/user-attachments/assets/c47a6469-3052-4d3d-a2d1-7602466e5b6b)

![image](https://github.com/user-attachments/assets/9dfa4a7e-2a21-4d47-9277-5dbd73f99a4b)

### Input Study Hours:
Once the date is selected, input the number of hours you dedicated to studying for that session.
 
![image](https://github.com/user-attachments/assets/91b26a80-69cd-40f7-afaa-3769e0c02d07)

 
### Save:
Click the "Save" button to confirm and save your recorded study hours.
 ![image](https://github.com/user-attachments/assets/87733b2e-c938-4112-bbca-aa2175074a2f)

Confirmation Message: A confirmation message will appear, acknowledging the successful recording of your study hours.
![image](https://github.com/user-attachments/assets/0daf53b5-34dc-4a65-8e28-a0ddbf248592)

 
This process allows you to precisely record your study efforts for each module on specific dates. The dropdown list, calendar interface, and confirmation message enhance user experience and provide a systematic way to keep track of your study sessions. 


### Weekly Study Progress
Navigate to the " View Stud Progress " section and select the desired module and week to display.
5.4.1 Selecting Module and Week
 Module Selection:
-	Use the dropdown list to select the module you want to review.
  ![image](https://github.com/user-attachments/assets/038e8a17-b077-41d9-92b9-8ab93c5b5072)

 
Week Selection:
-	Choose the specific week you want to analyze from the dropdown box.
-	 ![image](https://github.com/user-attachments/assets/563fa5ef-5d82-4b26-a61a-2d0107a7e22b)

### Displayed Information
After selecting the module and week, the following information will be displayed:
-	Module Code, the code associated with the selected module.
-	Hours Studied, the total number of hours you have studied for the selected module during the chosen week.
-	Remaining Hours, the remaining hours recommended for study based on your ideal study hours and the current week's progress.
-	![image](https://github.com/user-attachments/assets/430e53f6-50f1-4ae7-b06f-25672196376e)
-	![image](https://github.com/user-attachments/assets/296d1a3e-e1f8-47ae-b12f-76480b70be10)

 
 

This detailed breakdown provides a focused view of your study efforts for a specific module during a particular week, helping you manage your time effectively and stay on top of your academic commitments.


## Module Study Progress Graph 
Navigate to the "View Study Progress Graph" section and select the desired module to display.
![image](https://github.com/user-attachments/assets/639f7e9e-0e53-44a2-8d51-8726ac89a9fc)

 

### Selecting Module
Module Selection:
-	Use the dropdown list to select the module you want to review.
-	 ![image](https://github.com/user-attachments/assets/9063e732-433b-4143-8c17-42b1b12d2c39)


### Displayed Graph
After selecting the module, the system will display a bar graph representing the study progress for the chosen module.
![image](https://github.com/user-attachments/assets/14206d16-7516-45e7-8ca8-77877ac366ad)

 ![image](https://github.com/user-attachments/assets/0171d0d7-a12b-46ce-a06d-4f4b489ae46b)


Graph Information:
•	Y-Axis (Hours): Represents the total number of hours studied.
•	X-Axis (Weeks): Indicates the weeks under consideration.
Graph Elements:
•	Actual Hours of Study: The bars will show the actual hours of study completed for each week.
•	Ideal Study Hours: A reference line on the graph will indicate the ideal study hours for each week.
 
![image](https://github.com/user-attachments/assets/ac065bf5-c757-409d-9975-2076ae67d9be)

### Information Overlay
Additionally, the page will display a key for the graph and hovering over each bar on the graph will display detailed information:
•	Week: The specific week in consideration.
•	Actual Hours of Study: The exact number of hours studied during that week.
•	Ideal Study Hours: The recommended ideal study hours for that week.
![image](https://github.com/user-attachments/assets/31a45397-c5fe-4538-9e89-e2b0e84d1005)


 
This graphical representation provides a visual insight into your study progress, allowing you to compare your actual study hours with the recommended ideal study hours. It helps in identifying trends, evaluating consistency, and making informed adjustments to your study routine.

