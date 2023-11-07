<h1>Hotel Management Web App</h1>

<p>This is a simple web app built in .NET CORE, ANGULAR 16 & SQL Server that allow users to manage Hotels information. This project contains one main model, <strong>Hotel</strong></p>

<h2>Hotel Model</h2>

<p>The <strong>Hotel</strong> model represents a object which contains the following fields</p>

<ul>
 <li><strong>Name</strong>The name of the hotel</li>
 <li><strong>Stars</strong> Ranking in stars</li>
 <li><strong>Country</strong>The country where the office is located</li>
 <li><strong>City</strong>The city where the office is located</li>
 <li><strong>Address</strong>Address of the hotel</li>
 <li><strong>Description</strong>A short description of the hotel/li>
</ul>

<h2>API Usage</h2>

<p>To run this application locally, you will be need to have .NET, ANGULAR, SQL Server Management Studio & VS Code installed on your machine, Afterward, the repository should be cloned, and once this is done, we will open the project named API_Hoteles.sln. Following that, a series of steps must be followed</p>

<p>You should open SQL Server Management Studio, and in a new query window, proceed to create a table named <strong>Hotels</strong> using the query<strong>create database Hotels;</strong></p>

<p>Once done, you should configure the database connection string with the API. Now, in the .NET project, navigate to the appsettings.json file, and within it, you will place the connection string. Inside, you will find a JSON object named 'ConnectionStrings,' and within it, an attribute named 'SqlConnection.' This last one will contain the value for our connection string. Currently, you will find an example connection string, and the values in it should be configured with the connection data for your local database</p>

<p>The current connection string looks like this <strong>"Server=DESKTOP-LBFSQMT\\SQLEXPRESS; DataBase=HOTELS;Integrated Security=true; Encrypt=False"</strong></p>

<p>The only value you should change is the server information, which is shown in the following example <strong>"Server=MY-SERVER-INFORMATION; DataBase=HOTELS;Integrated Security=true; Encrypt=False"</strong>, If you don't know where to find the information you need to put in this part of the connection, you can find it within SQL Server Management Studio, just as shown in the image below </p>

<img src="https://res.cloudinary.com/dqslkpyki/image/upload/v1699387716/ywdjbcrf1ggdb9ihb772.jpg">

<p>Once the connection string has been configured, we can synchronize our API with the database. To do this, you should go to the .NET package manager console and run the 'Update-database' command. When the process is complete, our database and API will be linked, and we can start using it. However, it's advisable to insert some data into the newly created table. Below, you will see an SQL query with some data that you can insert</p>

<pre>
insert into Hotels(Name, Stars, Country, City, Address, Description ,CreationDate) values
('Four Seassons', 5, 'Colombia', 'Bogotá', 'Cra. 7 #69a-22', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. In quis massa sed nunc faucibus mollis in a nisl. Proin eget tellus ut dolor tincidunt ullamcorper eu et eros.' ,GETDATE()),
('Hampton by Hilton', 5, 'Colombia', 'Medellín', 'Calle 6 Sur 42 - 14', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. In quis massa sed nunc faucibus mollis in a nisl. Proin eget tellus ut dolor tincidunt ullamcorper eu et eros.' ,GETDATE()),
('Hotel Sonora', 3.8, 'México', 'Ciudad de México', 'Centro, Cuauhtémoc, 06010 ', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. In quis massa sed nunc faucibus mollis in a nisl. Proin eget tellus ut dolor tincidunt ullamcorper eu et eros.' ,GETDATE()),
('Hyatt', 4.5, 'USA', 'New York', '134 4th Ave, New York, NY 10003', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. In quis massa sed nunc faucibus mollis in a nisl. Proin eget tellus ut dolor tincidunt ullamcorper eu et eros.' ,GETDATE()),
('Hotel East 21 Tokyo', 4, 'Japon', 'Tokyo', '6 Chome-3-3 Toyo - Tokyo 135-0016', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. In quis massa sed nunc faucibus mollis in a nisl. Proin eget tellus ut dolor tincidunt ullamcorper eu et eros.' ,GETDATE())
</pre>

<p>Now we can start our server. To do so, you need to go to the .NET toolbar, and in the project startup button, start the server using either of the two options shown in the following image.</p>

<img src="https://res.cloudinary.com/dqslkpyki/image/upload/v1699387716/inin0deopwwrbybzm6sq.jpg">

<p>With the server running, you can test the CRUD queries on the Swagger interface</p>

<h2>APP Usage</h2>

<p>Now, we will move on to running the user interface of the application, to do this, we will navigate to the path of our Angular project, in this case, within the 'APP_hoteles' folder, and proceed to open it in VSCode. Once this is done, within the command console, we will download the 'node_modules' folder by running the 'npm install' command.</p>

<p>Once the dependencies are downloaded, we can run our project by executing the 'ng serve -o' command in the console. This will open the application and display the user interface at 'http://localhost:4200/'.</p>

<p>Below you will find some explanatory images of the user interface.</p>


<h4>Desktop & mobile main view</h4>

<p>Here are the main views on both desktop and mobile devices. This view includes various buttons that perform specific functions. For example, the 'Details' button displays all the information contained in all the different attributes of the hotel object. The other buttons with functions like 'Add,' 'Delete,' or 'Edit a Hotel' call functions that are not yet implemented but display toast messages that clarify this to the user</p>

<img src="https://res.cloudinary.com/dqslkpyki/image/upload/v1699390432/general_js5kqd.jpg">
<img src="https://res.cloudinary.com/dqslkpyki/image/upload/v1699390330/mobile-main_mzgb6i.jpg">

<p>Here is the detailed view of the information. This is executed by filtering the ID of each instance of the Hotel object</p>

<img src="https://res.cloudinary.com/dqslkpyki/image/upload/v1699391061/details-desktop_zdjeuu.jpg">
<img src="https://res.cloudinary.com/dqslkpyki/image/upload/v1699391061/details-mobile_sdoyhk.jpg">








