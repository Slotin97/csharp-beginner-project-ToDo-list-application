# csharp-beginner-project-ToDo-list-application

c# ToDo list application beginner project

ToDo List Application
This is a simple console-based ToDo list application written in C#. The application allows you to:

Add new ToDo items
View the current list of ToDo items
Mark ToDo items as completed

How to Use
Start the application and you will be presented with a menu of options
To add a new ToDo item, select option 1 and enter the item's title, description, and due date

To view the current list of ToDo items, select option 2
To mark a ToDo item as completed, select option 3 and enter the title of the item you want to mark as completed
To exit the application, select option 4

Note
When adding new todo, due date should be entered in the format of yyyy-mm-dd
When marking the todo as completed, it will be removed from the list of current todos
If the entered todo for completion is not found, it will display that the todo is not found.

If the list is empty it will display 'No Todo Found'
Invalid inputs will be handled by displaying "Invalid input, please enter number.".
Code

The code is written in C# and makes use of the List<T> collection to store the ToDo items and a do-while loop to present the menu of options to the user until they choose to exit the application. The TodoItems class is used to store the properties of each ToDo item (title, description, due date) and the TodoItems objects are added to the toDoList list.
