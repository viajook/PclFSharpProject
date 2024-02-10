let rec countPositives lst = 
    match lst with
    | [] -> 0
    | x::xs when x > 0 -> 1 + countPositives xs
    | x::xs -> countPositives xs

printfn "%A" (countPositives [6; 3; -3; 1; 2])