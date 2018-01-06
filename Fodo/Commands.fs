module Commands
    
    open System
    open System.IO
    
    let todoFileName = "Todo.txt"

    let addCommandType = "add"

    let listCommandType = "list"

    let appendLines linesToAppend =
        File.AppendAllLines(todoFileName, linesToAppend)

    let readAllLines fileName =
        File.ReadAllLines(fileName)

    let addCommand text =
        appendLines text

    let  listCommand searchTerm =
        match searchTerm with
        | [] -> printfn "%A" (readAllLines todoFileName)
        | _ -> readAllLines todoFileName |> Seq.filter(fun line -> if line.Contains(searchTerm.Head) then false else true) |> printfn "%A"


