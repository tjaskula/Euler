﻿namespace Euler

[<AutoOpen>]
module Problems =

    (*  
        If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
        The sum of these multiples is 23.
        Find the sum of all the multiples of 3 or 5 below 1000.
    *)

    let problem1 lst =
        let checkMult3and5 number =
            match number % 3, number % 5 with
                | 0, 0 | 0, _ | _, 0 -> true
                | _ -> false
        lst 
            |> List.filter (fun elem -> checkMult3and5 elem)
            |> List.sum

    let problem1' lst =
        let checkMult3and5 =
            function
                | 0, 0 | 0, _ | _, 0 -> true
                | _ -> false
        lst 
            |> List.filter (fun elem -> checkMult3and5 (elem%3, elem%5))
            |> List.sum

    let problem1'' lst =
        let checkMult3and5 number =
            if (number % 3 = 0 || number % 5 = 0) then
                true
            else
                false
        lst 
            |> List.filter (fun elem -> checkMult3and5 elem)
            |> List.sum

    (*
        Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
        By starting with 1 and 2, the first 10 terms will be:
        1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

        By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
        find the sum of the even-valued terms.
    *)
    
    let problem2 () =
            Seq.unfold (fun (a, b)  -> Some(a + b, (b, a + b))) (0I, 1I)
            |> Seq.takeWhile (fun elem -> elem < 4000000I)
            |> Seq.filter (fun elem -> elem % 2I = 0I)
            |> Seq.sum

        
    (*
        The prime factors of 13195 are 5, 7, 13 and 29.

        What is the largest prime factor of the number 600851475143 ?
    *)

    type FactorTree =
        | Leaf of int64
        | Branch of int64 * FactorTree * FactorTree

    let (|Even|Odd|) (number, divisor) =
        match number % divisor with
            | 0L -> Even
            | _ -> Odd

    let rec findDivended number divisor =
        match (number, divisor) with
            | Even -> let quotient = number / divisor
                      quotient, divisor
            | Odd ->  findDivended number (divisor + 1L)     
    
    let rec buildUpFactorTree tree =
        match tree with
            | Leaf number -> let quotient, divisor = findDivended number 2L
                             match quotient with
                                | 1L -> tree
                                | _ -> buildUpFactorTree (Branch (number, Leaf quotient, Leaf divisor))
            | Branch (value, left, right) -> Branch(value, buildUpFactorTree left, buildUpFactorTree right)


    let rec evaluate tree biggestSoFar =
        match tree with
            | Leaf number -> if number > biggestSoFar then
                                number
                             else
                                biggestSoFar
            | Branch (value, left, right) -> let biggestLeft = evaluate left biggestSoFar
                                             let biggestRight = evaluate right biggestSoFar
                                             if (biggestLeft > biggestRight) then
                                                biggestLeft
                                             else
                                                biggestRight
                                             
    let problem3 number =
        let tree = buildUpFactorTree (Leaf number)
        evaluate tree 1L

    let rec maxFactor max min =
        if max = min then
            max
        else
            let isDivisible = max % min = 0L
            let nextMax = if isDivisible then max / min else max
            let nextMin = if isDivisible then min else min + 1L
            maxFactor nextMax nextMin

    let problem3' number =
        maxFactor number 2L

    (*
        A palindromic number reads the same both ways. The largest palindrome 
        made from the product of two 2-digit numbers is 9009 = 91 × 99.

        Find the largest palindrome made from the product of two 3-digit numbers.
    *)
 
    let isPalindrome number =
        let arr = number.ToString().ToCharArray()
        arr = Array.rev arr
 
    let problem4 () =
        let range = List.rev [100..999]
 
        let rec calculate largest left right =
            match left, right with
                | [], [] | _, [] -> largest
                | [], y::ys -> calculate largest range ys
                | x::xs, y::ys -> let res = x * y
                                  match isPalindrome res with
                                    | true -> calculate (max res largest) xs right
                                    | false -> calculate largest xs right
 
        calculate 0 range range

    (*
        2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

        What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    *)

    let positifNumbers = Seq.unfold (fun state -> Some(state, state + 1)) 1
 
    let isDivisible number =
        let n = [1..20]
                    |> List.tryFind (fun elem -> (number % elem) > 0)
        match n with
            | Some _ -> false
            | None -> true
 
    let problem5 () =
        positifNumbers
           |> Seq.find (fun elem -> isDivisible elem)

    (*
        The sum of the squares of the first ten natural numbers is,

        12 + 22 + ... + 102 = 385
        The square of the sum of the first ten natural numbers is,

        (1 + 2 + ... + 10)2 = 552 = 3025
        Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

        Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    *)

    let sumSquare range =
        range
            |> List.map (fun elem -> pown elem 2)
            |> List.sum
 
    let squareSum range =
        let sum = range
                    |> List.sum
        pown sum 2
 
    let problem6 range =
        (squareSum range) - (sumSquare range)