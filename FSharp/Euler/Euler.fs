namespace Euler

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