module TaskHandler

open Giraffe
open Message
open IndexView


let taskHandler : HttpHandler =
    let greetings = sprintf "Hello %s, from Giraffe!" "" //fetch from db
    let model     = { Text = greetings }
    let view      = IndexView.index model
    htmlView view