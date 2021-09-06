open System

let sequenceSum (stringValue: string) = 
    stringValue 
    |> Seq.map Char.GetNumericValue 
    |> Seq.map int 
    |> Seq.sum 

let myFunc (value: bigint) func1 = 
    let result = func1 (string value)
    result


[<EntryPoint>]
let main argv =
    let arg = 11111111111111111111I
    let result = myFunc arg sequenceSum
    printfn "Result is: %d" result
    0 // return an integer exit code
