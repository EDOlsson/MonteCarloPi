open MonteCarlo
open MonteCarloParallel

[<EntryPoint>]
let main argv = 
    let iterations = 100000000

    printfn "Running simulation for %d iterations (no parallelism)" iterations

    printfn "Pi was calculated to be %f." <| RunSimulation iterations

    System.Console.ReadKey() |> ignore

    printfn "Running simulation for %d iterations (with parallelism)." iterations

    printfn "Pi was calculated to be %f." <| RunSimulationParallel iterations

    System.Console.ReadKey() |> ignore

    0
