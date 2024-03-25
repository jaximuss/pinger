
# PING2

PING2 is a simple, console-based application developed in C# that allows users to ping websites and check the connectivity and response time. It uses the `System.Net.NetworkInformation` namespace to send ping requests to specified targets and displays the round-trip time in milliseconds.

## Features

- **Simple Interface**: Just type in the website you want to ping, and the tool does the rest.
- **Real-time Feedback**: Get immediate response times and connectivity feedback.
- **Continuous Ping**: Unlike the traditional ping which sends a limited number of requests, this tool continues to ping the specified target until stopped.

## Prerequisites

Before running PING2, ensure you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download) compatible with C# 6.0 or later.

## How to Use

1. **Clone the Repository**

   First, clone this repository to your local machine using Git:

   ```bash
   git clone https://github.com/jaximuss/pinger.git
   ```

2. **Navigate to the Project Directory**

   After cloning, change into the project directory:

   ```bash
   cd ping
   ```

3. **Run the Application**

   To run the application, execute the following command:

   ```bash
   dotnet run
   ```

   Follow the on-screen instructions to input the website you wish to ping.

## How It Works

1. The application prompts the user to enter a website address.
2. It then continuously pings the given address, showing the round-trip time for each ping.
3. If the ping is successful, it displays the response time in milliseconds. If the connection is lost or the website is invalid, it informs the user accordingly.
4. The process repeats until manually stopped or an error occurs.

## Contributions

Contributions are welcome! If you have ideas for improvements or encounter any issues, please feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
```

Remember to replace `https://github.com/yourgithubusername/ping2.git` with the actual URL of your GitHub repository. You might also want to add a LICENSE file to your repository if you haven't already, to clarify how others can use your code.
