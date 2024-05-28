<body>
    <h1>Memento Design Pattern</h1>
    <h2>Scenario</h2>
    <p>
        Consider a text editor where users can write text and undo changes. The <code>Document</code> class maintains the content and can create and restore mementos representing its state at different points in time.
    </p>
    <h2>Implementation Steps</h2>
    <ol>
        <li>Create the Memento Class: Define a class to store the state of the <code>Document</code>.</li>
        <li>Modify the Originator (Document) Class: Add methods to create and restore mementos.</li>
        <li>Implement the Caretaker: A class to manage the mementos and provide undo functionality.</li>
    </ol>
</body>
