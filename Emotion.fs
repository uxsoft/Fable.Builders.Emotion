namespace Fable.Builders.Emotion

open Fable.Core.JsInterop
open Fable.Core
open Feliz

[<AutoOpen>]
module Emotion =

    [<Import("css", "@emotion/css")>]
    let css (style: 't) : string = jsNative
    
    let cssFeliz (props: #IStyleAttribute list) =
        let obj = (createObj !!props)
        let className = css obj
        className