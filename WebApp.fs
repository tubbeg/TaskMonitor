module WebApp


open Giraffe
open Message
open IndexView
open IndexHandler
open TaskHandler

let webApp : HttpHandler =
    choose [
        GET >=>
            choose [
                route "/" >=> indexHandler "world"
                routef "/hello/%s" indexHandler
                route "/tasks" >=> taskHandler
            ]
        setStatusCode 404 >=> text "Not Found" ]