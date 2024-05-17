<h2>Scenario</h2>
<p>You're designing a car simulation application where users can interact with a virtual car. This application aims to provide a realistic driving experience, with the car transitioning between different states: Off, Stopped, and Driving. Each state governs the car's behavior, such as starting the engine when in the Off state or accelerating when in the Driving state. Implement the State design pattern for this scenario. This pattern allows the car object to dynamically change its behavior based on its current state, providing users with a responsive and immersive driving experience.</p>

<h2>Implementation Steps</h2>
<ol>
  <li><strong>Define the interface CarState</strong> with methods for the actions that can be performed on the car.</li>
  <li><strong>Implement concrete state classes</strong> (OffState, StoppedState, DrivingState) representing different states of the car and their associated behaviors.</li>
  <li><strong>Create a Car class</strong> to maintain the current state of the car and delegate actions to the appropriate state object.</li>
  <li><strong>Implement the client code</strong> (Main class) to interact with the Car object and simulate various actions on the car.</li>
</ol>
