namespace Euler.Tests

open Xunit
open FsCheck
open Euler

module ``Euler problem tests tests`` =

    // Problem 1 : Multiples of 3 and 5
    [<Fact>]
    let ``Multiples of 3 and 5``() =
        let result = problem1 [1..999] = 233168
        Check.Quick result
    
    // Problem 1 : Multiples of 3 and 5
    [<Fact>]
    let ``Multiples of 3 and 5'``() =
        let result = problem1' [1..999] = 233168
        Check.Quick result

    // Problem 1 : Multiples of 3 and 5
    [<Fact>]
    let ``Multiples of 3 and 5''``() =
        let result = problem1'' [1..999] = 233168
        Check.Quick result

    // Problem 2 : Even Fibonacci numbers
    [<Fact>]
    let ``Even Fibonacci numbers''``() =
        let result = problem2 () = 4613732I
        Check.Quick result

    // Problem 4 : Largest palindrome product
    [<Fact>]
    let ``Largest palindrome product``() =
        let result = problem4 () = 906609
        Check.Quick result