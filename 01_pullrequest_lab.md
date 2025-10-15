# Lab to understand  Github Copilot support for Pull Requests
In this lab, we will explore how GitHub Copilot can assist you in creating and managing pull requests. We will cover the following topics:
1. Creating a pull request
2. Reviewing a pull request
3. Merging a pull request
4. Best practices for pull requests

## Step-by-Step Lab: Using GitHub Copilot with a C# Program for Pull Requests

### Step 1: Create a New C# Console Application

1. Open Visual Studio or VS Code.
2. Create a new folder for your project and open it in your editor.
3. Run the following command to create a new console app:

    ```bash
    dotnet new console -n CopilotPullRequestDemo
    cd CopilotPullRequestDemo
    ```

### Step 2: Write Initial Code

1. Open `Program.cs`.
2. Add the following code:

    ```csharp
    using System;

    namespace CopilotPullRequestDemo
    {
         class Program
         {
              static void Main(string[] args)
              {
                    Console.WriteLine("Hello, GitHub Copilot!");
              }
         }
    }
    ```

3. Commit and push this code to your GitHub repository.

### Step 3: Create a New Branch for a Feature

1. Create a new branch:

    ```bash
    git checkout -b feature/add-greeting
    ```

2. Modify `Program.cs` to add a method that greets the user by name. Use GitHub Copilot to suggest the method.

    ```csharp
    static void GreetUser(string name)
    {
         Console.WriteLine($"Hello, {name}!");
    }
    ```

3. Update `Main` to call `GreetUser`.

    ```csharp
    static void Main(string[] args)
    {
         Console.WriteLine("Enter your name:");
         string name = Console.ReadLine();
         GreetUser(name);
    }
    ```

4. Save, commit, and push your changes.

### Step 4: Create a Pull Request

1. Go to your repository on GitHub.
2. You will see a prompt to create a pull request for `feature/add-greeting`.
3. Click "Compare & pull request".
4. Add a description and create the pull request.

### Step 5: Review the Pull Request

1. Review the code changes in the "Files changed" tab.
2. Use GitHub Copilot to suggest improvements or leave comments.

### Step 6: Merge the Pull Request

1. Once the review is complete, click "Merge pull request".
2. Delete the feature branch if desired.

### Step 7: Best Practices

- Use descriptive branch names.
- Write clear pull request descriptions.
- Request reviews from teammates.
- Use Copilot to suggest code improvements and documentation.

---

By following these steps, you can leverage GitHub Copilot to streamline your pull request workflow in a C# project.

# Let summarise how github copilot helped in pull request
    In pull request creation, Copilot can assist by suggesting descriptive titles and summaries based on the changes made in the code. This helps in providing clear context to reviewers.
    During code reviews, Copilot can analyze the changes and suggest improvements or highlight potential issues, making the review process more efficient.
    When merging pull requests, Copilot can help ensure that the merge commit message is informative and follows best practices, aiding in maintaining a clean project history.
    In our example for pull request creation, Copilot suggested a clear and concise title and description for the pull request based on the changes made in the code. This helped in providing context to reviewers and made the pull request more understandable.
