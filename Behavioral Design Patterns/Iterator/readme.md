
<body>
    <h1>Iterator Design Pattern</h1>
    <h2>Scenario</h2>
    <p>
        In a product catalog system, you need to iterate over a list of products. The <code>ProductCatalog</code> class (ConcreteAggregate) maintains a list of products and provides a method to create an iterator (<code>ProductIterator</code>). The <code>ProductIterator</code> class (ConcreteIterator) implements the iterator interface to allow traversal of the product list.
    </p>
    <h2>Implementation Steps</h2>
    <ol>
        <li>Define the <code>Iterator</code> interface with methods <code>HasNext</code> and <code>Next</code>.</li>
        <li>Create the <code>Aggregate</code> interface with a method <code>GetIterator</code>.</li>
        <li>Implement the <code>ConcreteIterator</code> class to traverse the collection.</li>
        <li>Implement the <code>ConcreteAggregate</code> class to hold the collection and return an iterator.</li>
    </ol>
</body>