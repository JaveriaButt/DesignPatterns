<h2>Problem Scenario (Glyph Problem):</h2>

    You're developing a text editing application where you need to display a large document consisting of characters (glyphs). Each character has its own properties such as font size, style, and color. However, creating a separate object for each character can consume a significant amount of memory. You decide to use the Flyweight pattern to optimize memory usage and improve performance.

<h2>Implementation Steps:</h2>

<ol>
<li><b>Identify Intrinsic and Extrinsic State:</b> Determine which properties of the characters can be shared (intrinsic state) and which properties are unique to each character (extrinsic state).</li>
<li><b>Create Flyweight Interface:</b> Declare an interface Glyph with a method for displaying the character.</li>
<li><b>Implement Concrete Flyweight:</b> Create a concrete class Character implementing the Glyph interface to represent shared characters. Store intrinsic properties such as character code and font information.</li>
<li><b>Implement Unshared Concrete Flyweight:</b> Optionally, create a class Row or Column representing objects with intrinsic state that cannot be shared.</li>
<li><b>Implement Flyweight Factory:</b> Create a factory class FlyweightFactory to manage flyweight objects and ensure proper sharing.</li>
<li><b>Client Code:</b> In the client code, use the flyweight objects provided by the factory, providing extrinsic state as necessary.</li>
</ul>