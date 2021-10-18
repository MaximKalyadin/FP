// Learn more about F# at http://fsharp.org

open System
open System.IO

[<EntryPoint>]
let main argv =
    
    let split (str:String) = 
        str.Split (" ,:;!?.()\t\r\n".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries)

    let find (str:String) = 
        split str |> Seq.maxBy (fun elem -> Seq.length elem) |> Seq.length
        
    let reader = new StreamReader("C:\Users\Maxim\Desktop\пример.txt")
    let text = reader.ReadToEnd()
    printfn "%A" (find text)

    0
