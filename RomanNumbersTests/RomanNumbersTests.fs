module RomanNumbersTests

open NUnit.Framework
open FsUnit
open RomanNumber.RomanNumbers

[<TestCase(1,"I")>]
[<TestCase(2,"II")>]
[<TestCase(3,"III")>]
[<TestCase(4,"IV")>]
[<TestCase(5,"V")>]
[<TestCase(6,"VI")>]
[<TestCase(7,"VII")>]
[<TestCase(8,"VIII")>]
[<TestCase(9,"IX")>]
[<TestCase(10,"X")>]
[<TestCase(11,"XI")>]
[<TestCase(39,"XXXIX")>]
[<TestCase(41,"XLI")>]
let ``Recibo un numero arabe devuelvo numero romano`` number roman =
    romanNumber number |> should equal roman
