module AdventOfCode.TestProject1.TestsUnderstandingTypes

open System
open FunctionalDomain
open DayOne
open Xunit
open FsUnit.Xunit


type Book = { title: string; price: decimal }

type ChocolateType =
    | Dark
    | Milk
    | SeventyPercent

type Chocolate =
    { chocType: ChocolateType
      price: decimal }


type Gift =
    | Book of Book
    | Chocolate of Chocolate



[<Fact>]
let ``Gift type`` () =
    let aBook = Book { title = "test"; price = 3.25m }
    aBook.GetType |> should be ofExactType<Gift>
    // aBook |> should be ofExactType<Gift>
