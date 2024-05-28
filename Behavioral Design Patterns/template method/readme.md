
<body>
    <h1>Template Method Design Pattern</h1>
    <h2>Scenario</h2>
    <p>
        Imagine you are creating a beverage-making system. The process of making a beverage involves boiling water, brewing the beverage, pouring it into a cup, and adding condiments. The steps are the same for both tea and coffee, but the brewing process and condiments differ. Using the Template Method pattern, you can define the general steps in an abstract class and let the subclasses provide specific implementations for brewing and adding condiments.
    </p>
    <h2>Implementation Steps</h2>
    <ol>
        <li>Define an abstract class <code>BeverageMaker</code> with a <code>MakeBeverage</code> method and abstract methods for specific steps.</li>
        <li>Implement concrete classes <code>TeaMaker</code> and <code>CoffeeMaker</code> that extend <code>BeverageMaker</code> and provide specific implementations for the abstract methods.</li>
    </ol>
</body>