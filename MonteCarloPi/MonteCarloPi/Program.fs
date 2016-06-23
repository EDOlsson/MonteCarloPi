open MonteCarlo

[<EntryPoint>]
let main argv = 
    let iterations = 10000000
    printfn "Running simulation for %d iterations" iterations

    let pi = RunSimulation iterations

    printfn "Pi was calculated to be %f." pi

    System.Console.ReadKey() |> ignore

    0
