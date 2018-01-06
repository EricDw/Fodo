module Processor
    
    open System
    open HelpDocs
    open Commands

    let ProcessCommands commands =
        let commandsList = Array.toList commands
        match commandsList with
        | [] -> commandsHelp
        | addCommandType::xs -> addCommand xs
        | listCommandType::xs -> listCommand xs
