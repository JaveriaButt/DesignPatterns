Scenario:

You've been tasked with developing a home entertainment system that consists of various devices such as a DVD player, a TV, and a sound system. Instead of having users interact with each device individually, you need to create a single remote control interface that serves as a facade, allowing users to perform operations like "watch movie" with a single button press. This abstraction should hide the complexities of managing multiple devices and provide a seamless experience for users.

Problem:

Design and implement a home entertainment system using the Facade design pattern. Create a facade class named EntertainmentSystemFacade that encapsulates the functionalities of the DVD player, TV, and sound system. This facade should provide methods for common operations such as "watch movie," "listen to music," and "turn off." The facade should handle the interactions with individual devices internally, abstracting away the complexities from the client code.