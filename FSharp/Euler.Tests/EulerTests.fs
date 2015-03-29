namespace Euler.Tests

open Xunit
open FsCheck
open Euler

module ``Euler problem tests tests`` =
 
    // Problem 1 : Multiples of 3 and 5
    [<Fact>]
    let ``Problem 1: Multiples of 3 and 5``() =
        let result = problem1 [1..999] = 233168
        Check.Quick result
    
    // Problem 1 : Multiples of 3 and 5
    [<Fact>]
    let ``Problem 1: Multiples of 3 and 5'``() =
        let result = problem1' [1..999] = 233168
        Check.Quick result
 
    // Problem 1 : Multiples of 3 and 5
    [<Fact>]
    let ``Problem 1: Multiples of 3 and 5''``() =
        let result = problem1'' [1..999] = 233168
        Check.Quick result

    // Problem 2 : Even Fibonacci numbers
    [<Fact>]
    let ``Problem 2: Even Fibonacci numbers''``() =
        let result = problem2 () = 4613732I
        Check.Quick result

    // Problem 3 : Largest prime factor
    [<Fact>]
    let ``Problem 3: Largest prime factor``() =
        let result = problem3 600851475143L = 6857L
        Check.Quick result

    // Problem 4 : Largest palindrome product
    [<Fact>]
    let ``Problem 4: Largest palindrome product``() =
        let result = problem4 () = 906609
        Check.Quick result

    // Problem 5 : Smallest multiple
    [<Fact>]
    let ``Problem 5: Smallest multiple``() =
        let result = problem5' () = 232792560.0
        Check.Quick result

    // Problem 6 : Sum square difference
    [<Fact>]
    let ``Problem 6: Sum square difference``() =
        let result = problem6 [1..100] = 25164150
        Check.Quick result

    // Problem 7 : 10001st prime
    [<Fact>]
    let ``Problem 7: 10001st prime``() =
        let result = problem7 10001 = 104743
        Check.Quick result

    // Problem 8 : Largest product in a series
    [<Fact>]
    let ``Problem 8: Largest product in a series``() =
        let result = problem8 13 = 23514624000L
        Check.Quick result

    // Problem 9 : Special Pythagorean triplet
    [<Fact>]
    let ``Problem 9: Special Pythagorean triplet``() =
        let result = problem9 1000 = 31875000
        Check.Quick result

    // Problem 10 : Summation of primes
//    [<Fact>]
//    let ``Problem 10: Summation of primes``() =
//        let result = problem10 2000000L = 142913828922L
//        Check.Quick result

    // Problem 10' : Summation of primes
    [<Fact>]
    let ``Problem 10': Summation of primes``() =
        let result = problem10' 2000000 = 142913828922L
        Check.Quick result

    // Problem 11 : Largest product in a grid
    [<Fact>]
    let ``Problem 11: Largest product in a grid``() =
        let result = problem11 () = 70600674
        Check.Quick result

    // Problem 12 : Highly divisible triangular number
    [<Fact>]
    let ``Problem 12: Highly divisible triangular number``() =
        let result = problem12 500L = 76576500L
        Check.Quick result

    // Problem 13 : Large sum
    [<Fact>]
    let ``Problem 13: Large sum``() =
        let result = problem13 () = "5537376230"
        Check.Quick result
