module IndexHandler
open Giraffe
open Message
open IndexView

let indexHandler (name : string) =
    let greetings = sprintf "Hello %s, from Giraffe!" name
    let model     = { Text = greetings }
    let view      = IndexView.index model
    htmlView view