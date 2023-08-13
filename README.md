# SimpleMauiEmbedIOServerApp

SimpleMauiEmbedIOServerApp is a cross-platform mobile application developed using .NET MAUI and EmbedIO. The application demonstrates how to create a basic .NET MAUI app that interacts with an EmbedIO-powered web server to retrieve location data and display it on the app interface.

## **Features**
* Clicking a button triggers a request to the EmbedIO web server running on the local machine.
* The web server responds with location data in JSON format.
* The received location data is displayed on the app's user interface.

### **Prerequisites**
Before you begin, ensure you have the following:

* [.NET MAUI SDK](https://dotnet.microsoft.com/en-us/learn/dotnet/hello-world-tutorial/install)
* [Newtonsoft.Json](https://learn.microsoft.com/en-us/dotnet/api/overview/azure/microsoft.core.spatial.newtonsoftjson-readme?view=azure-dotnet)

## **Project Structure**
This app is a simple example of a .NET MAUI application that combines both client-side and server-side functionality. 

 **Server-Side Code (LocationController Class and App Class):**

* LocationController class: This is a WebApiController that defines an API endpoint to retrieve location information. The endpoint is configured to respond to HTTP GET requests at the path "/location". When accessed, it returns a JSON object containing the latitude and longitude.
* App class: This is the entry point of the Maui application. It initializes the web server, listens on a specified URL (e.g., http://localhost:9696/), and configures a WebApi module to handle requests. The WebApi module is associated with the LocationController to handle requests to the "/api/location" path. 

**Client-Side Code (MainPage Class):**
* MainPage class: This is a Maui ContentPage that provides the user interface of the application.
* The UI includes an image, labels, and a button.
* The button is named CounterBtn and is used to trigger the OnCounterClickedAsync event handler when clicked.
* OnCounterClickedAsync event handler: This is executed when the button is clicked. It sends an HTTP GET request to the "/api/location" endpoint using an HttpClient. The response from the server is converted from json text to clear text displayed below the button. The button text is updated to read “Clicked”.

**Maui Markup (MainPage.xaml):**
* This XML file defines the layout of the UI using Maui's markup language.
* It includes an Image, Label elements, and a Button element with specified properties.

## **EmbedIO Web Server**
* The application uses the EmbedIO library to create a lightweight web server. The server serves a simple API endpoint at /location that returns mock location data.

![ImageOneAndroid](https://github.com/SamualUllrich/SimpleMauiEmbedIOServerApp/assets/131905000/aa920dbb-b2f7-4fe0-87c4-84f4faaf8cb5)

 ![ImageTwoAndroid](https://github.com/SamualUllrich/SimpleMauiEmbedIOServerApp/assets/131905000/0fcb5fec-0572-4412-b9eb-fd853f9ad9d0)

