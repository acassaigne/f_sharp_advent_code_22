namespace FunctionalDomain

open System.Text.RegularExpressions


module DayOne =
let CountElves (calories: string list) : int = 
     match calories with 
     | [] -> 0
     | _ -> (calories |> List.filter (fun (item) ->  item.Length = 0  ) |> List.length) + 1
   
let CaloriesPerElf (calories: string list) : int list =
     [5000]