open System.Drawing
let path = __SOURCE_DIRECTORY__ + "\\bitmaps\\"
let bitmap = new Bitmap(16,16)
bitmap.Save(path+"bitmaps.png")

let largeBitmap = new Bitmap(32,32)
largeBitmap.Save(path+"large.png")