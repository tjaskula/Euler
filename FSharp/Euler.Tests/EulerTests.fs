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