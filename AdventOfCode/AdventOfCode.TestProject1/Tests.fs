module Tests

open System
open Xunit
open FsUnit.Xunit


[<Fact>]
let ``My test`` () =
    Assert.True(true)
    
[<Fact>]
let ``Expected minutes in oven`` () = 42 |> should equal 42
