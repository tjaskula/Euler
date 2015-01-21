// sets the current directory to be same as the script directory
System.IO.Directory.SetCurrentDirectory (__SOURCE_DIRECTORY__)
#I @"../packages/FsCheck.1.0.4/lib/net45"
#I @"../packages/FsCheck.Xunit.1.0.4/lib/net45"
#I @"../packages/xunit.1.9.2/lib/net20"
#I @"bin/Debug"
#r @"FsCheck.dll"
#r @"FsCheck.XUnit.dll"
#r @"xunit.dll"
#r @"Euler.dll"

open FsCheck
open Euler.Problems

// Problem 1: Multiples of 3 and 5
let result = problem1 [0..999]