module Tests

open System
open Xunit
open FsUnit.Xunit

let CountElves (calories: string list) : int =
    calories.Length

[<Fact>]
let ``count zero elf`` () = CountElves [] |> should equal 0 

[<Fact>]
let ``count one elf`` () = CountElves ["2000"] |> should equal 1 
