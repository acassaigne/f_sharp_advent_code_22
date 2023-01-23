module Tests

open FunctionalDomain
open DayOne
open Xunit
open FsUnit.Xunit

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
let ``split one elf`` () =
    SplitElves [ "2000" ] |> should equal [["2000"]]

let ``split two Elves`` () =
    SplitElves [ "2000"; ""; "3000" ] |> should equal [["2000"]; ["3000"]]

[<Fact>]
let ``w`` () =
    x [ "2"; ""; "3"] |> should equal (["2"]; ["3"]) 

let ``w`` () =
    x [ "2"; ""; "3"; "4"] |> should equal (["2"]; ["3"; "4"]) 


//
// let ``the first elf has 5000 calories`` () =
//     CaloriesPerElf [ "2000"; "3000" ] |> should equal [5000]
//
//
// let ``the first elf has 3000 calories`` () =
//     CaloriesPerElf [ "1000"; "1000"; "500"; "500" ] |> should equal [3000]
