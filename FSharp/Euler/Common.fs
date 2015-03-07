namespace Euler

module NumericLiteralG =
    let inline FromZero () = LanguagePrimitives.GenericZero
    let inline FromOne () = LanguagePrimitives.GenericOne

[<AutoOpen>]
module Common =

    let inline isPrime (n:^a) =
        let (two:^a) = 1G + 1G
        if n < two then
            false
        else
            let upperBound = System.Convert.ChangeType(n |> float |> sqrt, n.GetType()) :?> ^a
            let res = seq{two..upperBound}
                        |> Seq.tryFind (fun i -> n % i = 0G)
            match res with
                | Some _ -> false
                | None -> true