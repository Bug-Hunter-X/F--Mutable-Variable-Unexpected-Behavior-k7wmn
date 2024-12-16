let mutable x = 10

let addOne x = x + 1

let y = addOne x

printf "%d %d" x y //Prints 10 11

x <- addOne x //This updates the mutable variable

printf "%d" x //Prints 11

//Alternatively, if you want to use a function to modify a mutable variable directly:

let addOneMutable (x:byref<int>) = x <- x + 1

let mutable z = 10

addOneMutable &z

printf "%d" z //Prints 11