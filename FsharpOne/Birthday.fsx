let birthday = (23,10,1992)
let altered birthday =
    let dd,mm,yy = birthday
    (yy,mm,dd)

printfn "%A" (altered,birthday)