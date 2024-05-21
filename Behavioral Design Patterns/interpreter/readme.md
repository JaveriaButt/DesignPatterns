Scenario
Consider implementing a simple regular expression interpreter. The grammar includes literal expressions, sequence expressions, repetition expressions, and alternation expressions.

Implementation Steps
Define the AbstractExpression interface with an Interpret method.
Create LiteralExpression, SequenceExpression, RepetitionExpression, and AlternationExpression classes implementing the AbstractExpression interface.
Implement the Interpret method in each concrete class to evaluate the specific part of the grammar.
Build the abstract syntax tree in the client code to represent the expression to be interpreted.