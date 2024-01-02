using DMCCSocket;

// See https://aka.ms/new-console-template for more information

// Prompt for IP address
Console.WriteLine("Enter IP Address:");
string ipAddress = Console.ReadLine();
//string ipAddress = "10.0.0.147";

// Prompt for Port
Console.WriteLine("Enter Port #");
int port = int.Parse(Console.ReadLine());
//int port = 4545;

// Acknowledge Connect
Console.WriteLine("Press Enter to Connect");
Console.ReadKey();

SocketClient dataMan = new SocketClient(ipAddress, port);
//Console.WriteLine(inSight.Connect().ToString());

// Connect
Console.WriteLine(dataMan.Connect().ToString());
List<string> response;

// Prompt for Code 1
Console.WriteLine("DMCC Command 1");
//foreach (string line in response)
//{
//    Console.WriteLine(line);
//}
//dataMan.loggedIn = true;

// Code 1
string msg = Console.ReadLine();
response = dataMan.Send(msg);
foreach (string line in response)
{
    Console.WriteLine(line);
}

// Prompt for Code 2
Console.WriteLine("DMCC Command 2");

// Code 2
msg = Console.ReadLine();
response = dataMan.Send(msg);
foreach (string line in response)
{
    Console.WriteLine(line);
}

// Prompt for Code 3
Console.WriteLine("DMCC Command 3");

// Prompt for Command
msg = Console.ReadLine();
response = dataMan.Send(msg);
foreach (string line in response)
{
    Console.WriteLine(line);
}

// Prompt for disconnect
Console.WriteLine("Press Enter to Disconnect");
Console.ReadKey();

dataMan.Disconnect();
