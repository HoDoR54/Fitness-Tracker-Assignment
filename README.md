this project is for a school assignemnt. (specifically for the DDOOCP module of L4DC)
Nothing fancy will be in the project as the assignment prompts a simple window form program using C#.
Nothing fancy does not mean it will be easy for me. C# is not a comfort pick of mine and I'm not yet familiar with OOP.
I honestly have no idea how to write a professional-looking README. 
I will work on that for sure, but I'll just write a daily log of the development process and the problems I encounter throughout the project.


My current prototype of the app's routes is as follows. It might have slight changes in the future. 

```mermaid
graph TD;
    A[Registration Form] -->|Switch| B[Login Form];
    B -->|Login Success| C[Main Dashboard];
    A -->|Sign Up Success| C;
    C --> D["Calculator - Daily Calories Burnt"];
    C --> E["Goal Setter"];
    C --> F["Set activity List"];
    C --> G["Account Management"];
    C --> H["Go Back to Main"];

