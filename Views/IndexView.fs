
// ---------------------------------
// Views
// ---------------------------------

module IndexView
    open Giraffe.ViewEngine
    open Message
    let layout (content: XmlNode list) =
        html [] [
            head [] [
                title []  [ encodedText "TaskMonitor" ]
                link [ _rel  "stylesheet"
                       _type "text/css"
                       _href "/main.css" ]
            ]
            body [] content
        ]

    let partial () =
        h1 [] [ encodedText "TaskMonitor" ]

    let index (model : Message) =
        [
            partial()
            p [] [ encodedText model.Text ]
        ] |> layout