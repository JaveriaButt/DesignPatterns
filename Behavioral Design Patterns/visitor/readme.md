
<body>
    <h1>Visitor Design Pattern</h1>
    <h2>Scenario</h2>
    <p>
        Imagine you are implementing a shopping cart system where each item can be a book or a fruit. The system should calculate the total cost of items in the cart. Using the Visitor design pattern, you can define a visitor that performs the cost calculation for both books and fruits.
    </p>
    <h2>Implementation Steps</h2>
    <ol>
        <li>Define the <code>ShoppingCartVisitor</code> interface with visit methods for each element type.</li>
        <li>Implement the <code>ShoppingCartVisitorImpl</code> class that performs the operations.</li>
        <li>Define the <code>ItemElement</code> interface with the accept method.</li>
        <li>Implement concrete element classes <code>Book</code> and <code>Fruit</code> that implement the <code>ItemElement</code> interface.</li>
        <li>Implement the accept method in each concrete element class to accept the visitor and call the appropriate visit method.</li>
    </ol>
</body>
