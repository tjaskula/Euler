﻿// sets the current directory to be same as the script directory
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

let resProb2 = problem2 ()

let resProb3 = problem3 13L

let resProb5 = problem5' ()

// Problem 8: Largest product in a series
open System

let number = "73167176531330624919225119674426574742355349194934" +
                 "96983520312774506326239578318016984801869478851843" +
                 "85861560789112949495459501737958331952853208805511" +
                 "12540698747158523863050715693290963295227443043557" +
                 "66896648950445244523161731856403098711121722383113" +
                 "62229893423380308135336276614282806444486645238749" +
                 "30358907296290491560440772390713810515859307960866" +
                 "70172427121883998797908792274921901699720888093776" +
                 "65727333001053367881220235421809751254540594752243" +
                 "52584907711670556013604839586446706324415722155397" +
                 "53697817977846174064955149290862569321978468622482" +
                 "83972241375657056057490261407972968652414535100474" +
                 "82166370484403199890008895243450658541227588666881" +
                 "16427171479924442928230863465674813919123162824586" +
                 "17866458359124566529476545682848912883142607690042" +
                 "24219022671055626321111109370544217506941658960408" +
                 "07198403850962455444362981230987879927244284909188" +
                 "84580156166097919133875499200524063689912560717606" +
                 "05886116467109405077541002256983155200055935729725" +
                 "71636269561882670428252483600823257530420752963450"
 
let chop (input : string) len = 
    seq { for start in 0 .. input.Length - len
            do yield input.[start..start + len - 1] }
        |> Seq.toArray
 
let largestProduct len =
    let arr = chop number len
    arr
        |> Array.map (fun e -> e.ToCharArray()
                                |> Array.map (Char.GetNumericValue >> int64)
                                |> Array.reduce (fun acc i  -> acc * i))
        |> Array.max