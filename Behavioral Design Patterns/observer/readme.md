<h2>Observer Design Pattern</h2>
<p>The Observer pattern is a behavioral design pattern that defines a one-to-many dependency between objects, where changes to one object (the subject) trigger updates to all dependent objects (observers). This pattern is useful in scenarios where multiple objects need to be notified of changes in another object's state.</p>

<h3>Definition</h3>
<p>The Observer pattern defines a one-to-many dependency between objects, where changes to one object (the subject) trigger updates to all dependent objects (observers).</p>

<h3>Real-Life Examples</h3>
<ul>
  <li>Subscribers to a newsletter: When a new article is published, all subscribers receive a notification.</li>
  <li>Stock market updates: Investors subscribe to receive updates on stock prices, and changes in stock prices trigger notifications to all subscribers.</li>
</ul>

<h3>Applicability</h3>
<ul>
  <li>When there is a one-to-many relationship between objects, and changes to one object should be propagated to multiple dependent objects.</li>
  <li>When the abstraction and implementation of observer and subject should be separated.</li>
  <li>When changes to the state of one object should trigger updates to other objects without them being tightly coupled.</li>
</ul>

<h3>Participants</h3>
<ul>
  <li><strong>Subject:</strong> Represents the object being observed. It maintains a list of observers and notifies them of changes in its state.</li>
  <li><strong>Observer:</strong> Defines an interface for objects that should be notified of changes in the subject's state.</li>
  <li><strong>ConcreteSubject:</strong> Implements the Subject interface. It maintains the state of interest and notifies observers when changes occur.</li>
  <li><strong>ConcreteObserver:</strong> Implements the Observer interface. It receives notifications from the subject and updates its state accordingly.</li>
</ul>

<h3>Structure</h3>
<p>The Observer pattern typically consists of a Subject interface or class, an Observer interface or class, and concrete implementations of both. The Subject maintains a list of observers and provides methods for attaching, detaching, and notifying observers. Observers register with the subject to receive updates and implement a method to handle notifications.</p>

<h3>Scenario:<h3>
<p>Suppose you're developing a weather application that provides real-time updates to users. Users can receive weather updates on their phones and TVs. To achieve this, you decide to implement the Observer design pattern. The weather station acts as the subject, while phone displays and TV displays are observers. When the weather changes, all observers are notified with the updated weather information.</p>

<h3>Implementation Steps:</h3>
  <ol>
        <li>Define an interface <code>IObserver</code> with a method <code>Update(string weather)</code> to receive weather updates.</li>
        <li>Define an interface <code>ISubject</code> with methods <code>AddObserver</code>, <code>RemoveObserver</code>, and <code>NotifyObservers</code> to manage observers.</li>
        <li>Implement a concrete subject class <code>WeatherStation</code> that maintains a list of observers and notifies them of weather updates.</li>
        <li>Implement concrete observer classes <code>PhoneDisplay</code> and <code>TVDisplay</code> that receive weather updates and display them.</li>
        <li>In the client code, create instances of the subject and observer classes, attach observers to the subject, and simulate weather changes to observe updates.</li>
    </ol>
</html>
