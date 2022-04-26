
namespace Fable.Builders.Emotion

open Fable.Builders.Emotion
open Fable.Builders.Common
open Fable.Core.JsInterop
open Feliz

[<AutoOpen>]
module ReactBuilder =

    type ReactBuilder with
        [<CustomOperation("css")>]
        member inline _.css (x: DSLElement, v: #IStyleAttribute list) =
            let styleObj = createObj !!v
            let className = Emotion.css styleObj
            x.attr "className" className