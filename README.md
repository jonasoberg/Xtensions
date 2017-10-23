# Xtensions

A collection of extension methods for use in more or less every project I create.
All extensions are capable of handling NULL objects.

.NET Standard compatible.

    // ########## String Extensions ########## 
    // .ToInt32()
    "hello".ToInt32();              // => 0 
    "hello".ToInt32(45);            // => 45 
    "123".ToInt32(45);              // => 123

    // .ToDecimal()
    "123.123".ToDecimal()           // => 123.123

    // .ToDouble()
    "123.123".ToDouble()            // => 123.123

    // .Left()
    "hello".Left(2)                 // => "he"

    // .Right()
    "hello".Right(2)                // => "lo"

    // .IsNullOrEmpty()
    ((string)null).IsNullOrEmpty()  // true
    "hello".IsNullOrEmpty()         // false

    // .ToNotNull()
    ((string)null).ToNotNull()      // ""

    // .ToListOfInt32()
    "1;2;;4".ToNotNull()            // List<int> {1, 2, 4} 
    