namespace FunctionalDomain

open System.Text.RegularExpressions


module DayOne =
let CountElves (calories: string list) : int = 
     match calories with 
     | [] -> 0
     | _ -> (calories |> List.filter (fun (item) ->  item.Length = 0  ) |> List.length) + 1
   
// let CaloriesPerElf (calories: string list) : int list=
//      calories
//      |> List.map (fun (e) -> e |> int)
//      |> List.sum
//      |> List.collect (fun (e) -> e)

let SplitElves (allElves: string list) : string list list =
     [["2000"]]
     
let rec x (allElves: string list) =
    allElves |> List.sp