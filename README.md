# Basics of SignalR

At first, SignalR might sound like a complex technical term, but once you grasp the basics, you'll see it’s simpler than it seems.

# Why SignalR?
In typical client-server communication (e.g., HTTP requests), the connection is stateless—meaning each request operates independently, with no memory of previous interactions. For example, when a client (not your company’s client, but any user accessing the URL) makes an HTTP request to a server to fetch data, the server doesn’t retain any context from earlier communications. However this can be enabled using additional mechanisms like cookies, sessions, or tokens.

SignalR changes this dynamic by establishing a persistent connection—a “tunnel”—between the client and the server using web-sockets which allow bi-directional communication. 

SignalR enables real-time communication by establishing a persistent connection between the client and server. Unlike typical HTTP requests, which are stateless and require the client to repeatedly ask the server for updates, SignalR allows the server to push updates to the client as they happen

Now that we understand the “why,” we can think about where this concept can be applied.

# Diagram illustration
Below is a simple explanation of how SignalR facilitates communication in a live chat scenario involving three individuals.
