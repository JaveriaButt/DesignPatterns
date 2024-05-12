<b>Problem Scenario:</b>
`You're developing an application that needs to load and display images efficiently. Loading images from disk or remote sources can be resource-intensive, especially for large images. To optimize the process, you decide to implement the Proxy design pattern to load images lazily and cache them for future use.

<b>Implementation Steps:</b>

<ul>
<li>Identify Real Object: Determine the resource-intensive object to be proxied, which in this case is the image loading process.</li>
<li>Create Subject Interface: Define an interface IImage with a method for displaying images.
Implement Real Subject: Create a class RealImage representing the real image object that loads images from disk.</li>
<li>Implement Proxy: Create a class ProxyImage that acts as a surrogate for the real image object. It loads images lazily and caches them for future use.</li>
<li>Client Usage: In client code, use the proxy object to display images, allowing the proxy to manage image loading transparently.</li>
</ul>