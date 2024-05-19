<
<body>
    <h1>Chain of Responsibility Design Pattern - Customer Support Levels Example</h1>
    <p>In a customer support system, different levels of support staff handle customer queries based on their expertise. The Chain of Responsibility design pattern allows requests to be passed along a chain of handlers until they are handled by an appropriate handler.</p>
    <p>In this example, we'll implement a customer support system with three levels: Level 1, Level 2, and Level 3 support. Each level handles requests that fall within its expertise. If a request cannot be handled at a lower level, it is escalated to the next level.</p>
    <ol>
        <li>Create an abstract handler class <code>SupportHandler</code> with a method <code>HandleRequest</code> to handle requests.</li>
        <li>Implement concrete handler classes <code>Level1SupportHandler</code>, <code>Level2SupportHandler</code>, and <code>Level3SupportHandler</code>, each representing a level of support and handling requests within its expertise.</li>
        <li>In each concrete handler class, implement the <code>HandleRequest</code> method to handle requests within its capability. If a request cannot be handled, it is escalated to the next level handler.</li>
        <li>In the client code, create instances of the support handlers and simulate customer requests to observe how they are handled.</li>
    </ol>
</body>
