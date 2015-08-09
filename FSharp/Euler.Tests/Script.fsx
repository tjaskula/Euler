// sets the current directory to be same as the script directory
System.IO.Directory.SetCurrentDirectory (__SOURCE_DIRECTORY__)
#I @"../packages/FsCheck.2.0.4/lib/net45"
#I @"../packages/FsCheck.Xunit.2.0.4/lib/net45"
#I @"../packages/xunit.extensibility.core.2.0.0/lib/portable-net45+win+wpa81+wp80+monotouch+monoandroid+Xamarin.iOS"
#I @"bin/Debug"
#r @"FsCheck.dll"
#r @"FsCheck.XUnit.dll"
#r @"xunit.core.dll"
#r @"Euler.dll"

open FsCheck
open Euler.Problems

let lattice = Array2D.create 21 21 1L

let transform x y (t : int64) =
    match x, y with
    | (0, _) | (_, 0) -> ()
    | _ ->  lattice.[x, y] <- lattice.[x - 1, y] + lattice.[x, y - 1]

lattice
    |> Array2D.iteri transform

let result = lattice.[(Array2D.length1 lattice) - 1, (Array2D.length2 lattice) - 1]