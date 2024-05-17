// Step 1: Define CarState Interface
interface CarState {
    void TurnKeyClockwise();
    void TurnKeyCounterClockwise();
    void PressGas();
    void PressBrake();
}

// Step 2: Implement Concrete States
class OffState : CarState {
    private readonly Car _car;

    public OffState(Car car) {
        _car = car;
    }

    public void TurnKeyClockwise() {
        Console.WriteLine("The engine has started");
        _car.State = new StoppedState(_car);
    }

    public void TurnKeyCounterClockwise() {
        Console.WriteLine("The engine is already off");
    }

    public void PressGas() {
        Console.WriteLine("The engine is off, cannot press gas");
    }

    public void PressBrake() {
        Console.WriteLine("The car is already stopped");
    }
}

class StoppedState : CarState {
    private readonly Car _car;

    public StoppedState(Car car) {
        _car = car;
    }

    public void TurnKeyClockwise() {
        Console.WriteLine("The engine starts");
        _car.State = new DrivingState(_car);
    }

    public void TurnKeyCounterClockwise() {
        Console.WriteLine("The engine has stopped");
        _car.State = new OffState(_car);
    }

    public void PressGas() {
        Console.WriteLine("The car begins to drive");
        _car.State = new DrivingState(_car);
    }

    public void PressBrake() {
        Console.WriteLine("The car is already stopped");
    }
}

class DrivingState : CarState {
    private readonly Car _car;

    public DrivingState(Car car) {
        _car = car;
    }

    public void TurnKeyClockwise() {
        Console.WriteLine("You hear a grinding noise...");
    }

    public void TurnKeyCounterClockwise() {
        Console.WriteLine("The engine turns off, and the car stops suddenly");
        _car.State = new OffState(_car);
    }

    public void PressGas() {
        Console.WriteLine("The car is already driving");
    }

    public void PressBrake() {
        Console.WriteLine("The car slows to a stop");
        _car.State = new StoppedState(_car);
    }
}

// Step 3: Implement Car Class
class Car {
    public CarState State { get; set; }

    public Car() {
        State = new OffState(this);
    }

    public void HandleInput(string input) {
        switch (input) {
            case "turn-clockwise":
                State.TurnKeyClockwise();
                break;
            case "turn-counter":
                State.TurnKeyCounterClockwise();
                break;
            case "gas":
                State.PressGas();
                break;
            case "brake":
                State.PressBrake();
                break;
            case "exit":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}

// Step 4: Client Code
class Program {
    static void Main(string[] args) {
        Car car = new Car();
        Console.WriteLine("Welcome to the Driving Simulator");
        Console.WriteLine("Usage:");
        Console.WriteLine("    turn-clockwise  - Turns the car's key clockwise");
        Console.WriteLine("    turn-counter    - Turns the car's key counter clockwise");
        Console.WriteLine("    gas             - Presses the gas pedal");
        Console.WriteLine("    brake           - Presses the brake pedal");
        Console.WriteLine("    exit            - Exits the simulator");

        while (true) {
            Console.Write("> ");
            string input = Console.ReadLine();
            car.HandleInput(input);
        }
    }
}
