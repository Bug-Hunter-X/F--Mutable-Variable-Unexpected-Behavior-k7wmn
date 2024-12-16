# F# Mutable Variable Unexpected Behavior

This example demonstrates a common pitfall when working with mutable variables in F#.  The initial expectation might be that the variable 'x' will be modified directly after the `addOne` function, but the function operates on a copy unless explicitly designed to modify the input.