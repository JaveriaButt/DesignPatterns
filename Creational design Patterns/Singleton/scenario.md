Imagine a bustling office environment where employees often need to print documents using shared printers. However, managing printer resources efficiently poses a challenge due to the potential for concurrency issues.

Description:
In this scenario, the provided C# code represents a Printer class implementing the Singleton design pattern. The Printer class ensures that only one instance of the printer is created throughout the application's lifecycle, allowing multiple clients to share the same printer instance.

The GetInstance() method uses a locking mechanism to guarantee thread safety and prevent multiple instances from being created concurrently. Each printer instance keeps track of the number of documents it has printed.