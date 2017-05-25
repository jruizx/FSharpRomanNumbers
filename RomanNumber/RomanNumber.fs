namespace RomanNumber


module RomanNumbers =

    open System.Collections.Generic

    let removeLastFromList list =
        list |> List.rev |> List.tail |> List.rev

    let rec romanNumber number =
        let romanList = [1,"I";4,"IV";5,"V";9,"IX";10,"X";40,"XL"]
        let numberToRoman = romanList |> Map.ofList

        if numberToRoman.ContainsKey number then numberToRoman.[number]        
        else
            let rec loop list =
                let maxConversion = list |> List.last
                let (arabic, roman) = maxConversion
                
                if romanList |> List.isEmpty then ""
                else 
                    if number >  arabic
                    then roman + romanNumber (number-arabic)
                    else loop (removeLastFromList list)

            loop romanList
