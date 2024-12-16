let mutable x = 10
let mutable y = 20

let add x y = x + y

let result = add x y
printf "%d\n" result

x <- 30
y <- 40

let result2 = add x y
printf "%d\n" result2