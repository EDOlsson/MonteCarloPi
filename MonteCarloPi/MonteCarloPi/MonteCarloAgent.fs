module MonteCarloParallel

open MonteCarlo

let RunSimulationParallel totalIterations =

   seq { for i in 1..8 do yield async { return RunSimulation totalIterations } }
        |> Async.Parallel
        |> Async.RunSynchronously
        |> Array.average