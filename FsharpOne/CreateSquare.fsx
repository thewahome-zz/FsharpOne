open System.Drawing
open System.IO

let bitmap = new Bitmap(16,16)
let path = __SOURCE_DIRECTORY__ + "\\bitmaps\\"
let pathAndFilename = Path.Combine(path,"square.png")
let createSquare () =
    for x in 2..10 do bitmap.SetPixel(x,2,Color.Black)
    for y in 2..10 do bitmap.SetPixel(2,y,Color.Black)
    for x in 2..10 do bitmap.SetPixel(x,10,Color.Black)
    for y in 2..10 do bitmap.SetPixel(10,y,Color.Black)

createSquare()
bitmap.Save(pathAndFilename)
