let rec printList nabin =
    match nabin with
    | [] -> ()
    | head :: tail ->
        printfn "%A" head
        printList tail
 
 
let listofsports = ["Volleyball"; "Cricket"; "Football"]
printList listofsports


let productOfOdd (n: int) =
    let rec helper (current: int) (acc: int) =
        if current <= 1 then acc
        else helper (current - 2) (acc * current)
    helper n 1

let result = productOfOdd 13
printfn "The product of all odd numbers from 13 to 1 is %d" result

let trimTheGivenSpace (givenList: string list) =
    givenList |> List.map (fun x -> x.Trim())

let list = [" CharlesBabbage  "; "  VonNeumann  "; "  DennisRitchie  "]
let trimmedNames = trimTheGivenSpace list

trimmedNames |> List.iter (printfn "%s")

let sequence = seq { 1 .. 700 }
let numberList = Seq.toList sequence
let filteredList = List.filter (fun x -> x % 7 = 0 && x % 5 = 0) numberList
let sumOfFilteredNumbers = List.fold (+) 0 filteredList

printfn "%A" filteredList
printfn "The sum of all numbers that are multiples of both 7 and 5 is %d" sumOfFilteredNumbers

let names: string list = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]
let filteredNames: string list = List.filter (fun name -> name.IndexOf("i", System.StringComparison.OrdinalIgnoreCase) >= 0) names
let concatenatedNames: string = List.fold (fun acc name -> acc + name) "" filteredNames

printfn "Concatenated names containing 'i': %s" concatenatedNames

