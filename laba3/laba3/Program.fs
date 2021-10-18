// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    
    let rand = new Random()

    let array = [|for i in 1 .. 10 -> rand.Next(100)|]

    Seq.iter (printf "%d ") array
    printfn ""
    let seq = seq {
        for i in 0 .. 8 -> 
            if array.[i] > array.[i+1]
            then 1
            else 0
    }

    Seq.iter (printf " %d ") seq
    printf "%d" (Seq.sum seq)
    
    0
