let mutable x = 10

let addOne x = x + 1

let y = addOne x

printf "%d %d" x y //Prints 10 11

x <- addOne x

printf "%d" x //Prints 11