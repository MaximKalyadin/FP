open System

[<EntryPoint>]
(*[1..100]
|> List.map(string)
|> List.filter(fun x -> x.Contains("1"))
|> List.sumBy(int)
|> printf "%i"*)

["врешоу"; "риртщр"; "тррвгоовЕово"; "о"; "орщшщтттщ"; "еЕ"; "КК"; "щтщ"]
|> List.filter(fun x -> not (x.Contains("е")))
|> List.filter(fun x -> not (x.Contains("Е")))
|> List.iter (fun i -> printf "%s " i)


