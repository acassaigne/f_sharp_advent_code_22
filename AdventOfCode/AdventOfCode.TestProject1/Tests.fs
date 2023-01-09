module Tests

open System
open Xunit
open FsUnit.Xunit

let CountElves (calories: string list) : int =
    0

[<Fact>]
let ``count elves`` () = CountElves [] |> should equal 0 
