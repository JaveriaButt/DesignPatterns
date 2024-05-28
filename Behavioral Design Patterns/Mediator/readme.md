
<body>
    <h1>Mediator Design Pattern</h1>
    <h2>Scenario</h2>
    <p>
        In a system where different components (Concrete Colleagues) need to communicate with each other, a Concrete Mediator is used to coordinate this communication. The mediator interface declares methods that define how colleagues can talk to each other.
    </p>
    <h2>Implementation Steps</h2>
    <ol>
        <li>Define the Mediator Interface: Declare methods for communication between colleagues.</li>
        <li>Create Concrete Mediator Class: Implement methods to coordinate communication between colleagues.</li>
        <li>Define the Colleague Interface: Declare methods to set and communicate with the mediator.</li>
        <li>Implement Concrete Colleague Classes: Implement methods to interact with the mediator and perform actions.</li>
    </ol>
</body>
