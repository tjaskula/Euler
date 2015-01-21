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