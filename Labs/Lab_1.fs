open System
open System.Drawing
open System.Collections.Generic

let lab1 () = 
    let rec numbersSum (x : bigint) =
        if x = Numerics.BigInteger(0) then x
        else (x % Numerics.BigInteger(10)) + numbersSum (x / Numerics.BigInteger(10))
    
    let getNumbers pw x =
        let number = pw x
        numbersSum number

    let n =
        Console.ReadLine()
        |> Double.Parse
        |> getNumbers (fun x -> Numerics.BigInteger((2.0 ** x)))
    let result = n.ToString()
    printfn "Result: %s" result

let lab2 () =
    let alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"
    let nums =
        [
            let wordsLlist =
                [
                    let lines = System.IO.File.ReadLines("C:\Users\Maxim\Desktop\пример.txt")
                    for line in lines do
                        let words = 
                            line.ToLower().Split(' ')
                            |> Seq.mapi (fun i el -> el, i)
                            |> Seq.filter (fun (el, i) -> i % 3 = 2)
                            |> Seq.map fst
                        for word in words do yield word
                ]

            let rec charInList c (list : string list) =
                let rec charInWord c (word : string) =
                    if word.Length = 0 then 0
                    elif word.[0] = c then 1 + charInWord c (word.Remove(0, 1))
                    else charInWord c (word.Remove(0, 1))
                let rec loop list acc =
                    match list with
                    | head :: tail -> loop tail (acc + charInWord c head)
                    | [] -> acc
                loop list 0

            for c in alphabet do
                yield charInList c wordsLlist
        ]

    printfn "Result: %c" alphabet.[nums |> Seq.mapi(fun i v -> i, v) |> Seq.maxBy snd |> fst]

let lab3() =
    let rec arrSum (arr : int[]) (index : int) =
        if index >= arr.Length then 0
        else 
            arr.[index] <- arr.[index] + (arrSum arr (index + 1))
            arr.[index]
    let arr = [| 3; 2; 1; 0; 4 |]
    let result = arrSum arr 0
    printf "Result: %A" arr
   
(*[<EntryPoint>]
let main argv =
    lab3()
    0*)



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
    lab2()
    0 // return an integer exit code
