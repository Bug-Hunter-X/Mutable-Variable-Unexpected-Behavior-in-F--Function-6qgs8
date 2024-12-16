let xRef = ref 10
let yRef = ref 20

let add xRef yRef = !xRef + !yRef

let result = add xRef yRef
printf "%d\n" result

 xRef := 30
yRef := 40

let result2 = add xRef yRef
printf "%d\n" result2