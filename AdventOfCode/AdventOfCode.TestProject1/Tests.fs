module Tests

open FunctionalDomain
open DayOne
open Xunit
open FsUnit.Xunit

[<Fact>]
let ``count zero elf`` () = CountElves [] |> should equal 0 

[<Fact>]
let ``count one elf`` () = CountElves ["2000"] |> should equal 1 
