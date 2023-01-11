module Tests

open FunctionalDomain
open DayOne
open Xunit
open FsUnit.Xunit
open Xunit.Sdk

[<Fact>]
let ``count zero elf`` () = CountElves [] |> should equal 0

[<Fact>]
let ``count one elf`` () = CountElves [ "2000" ] |> should equal 1


let ``count one elf with two items`` () =
    CountElves [ "2000"; "3000" ] |> should equal 1


[<Fact>]
let ``count two elves with one item`` () =
    CountElves [ "2000"; ""; "3000" ] |> should equal 2


[<Fact>]
let ``count two elves the first one has two items and the second has one item`` () =
    CountElves [ "2000"; "4000"; ""; "3000" ] |> should equal 2

[<Fact>]
let ``the first elf has 5000 calories`` () =
    CaloriesPerElf [ "2000"; "3000" ] |> should equal [5000]
