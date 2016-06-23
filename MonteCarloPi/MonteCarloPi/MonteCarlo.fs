module MonteCarlo

open System

let IsInSector x y =
    x ** 2. + y ** 2. <= 1.

let GenerateRandomPoint (r : Random) =
    r.NextDouble(), r.NextDouble()

let SimulateOneIteration totalInSector r =
    let x,y = GenerateRandomPoint r

    match IsInSector x y with
    | true -> totalInSector + 1
    | false -> totalInSector

let RunSimulation iterationCount =
    let r = new Random()

    let rec RunSimulation' iterationCount runningTotal =
        match iterationCount with
        | 0 -> runningTotal
        | _ -> RunSimulation' (iterationCount - 1) (SimulateOneIteration runningTotal r)

    let totalInSector = RunSimulation' iterationCount 0

    4. * double totalInSector / double iterationCount