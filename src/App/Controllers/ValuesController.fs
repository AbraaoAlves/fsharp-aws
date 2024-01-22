namespace App.Controllers


open Microsoft.AspNetCore.Mvc
open App.Services

[<Route("api/[controller]")>]
type ValuesController() =
    inherit ControllerBase()

    [<HttpGet>]
    member this.Get() =
        GetInfo.getSocial

    [<HttpGet("{id}")>]
    member this.Get(id: int) =
        "value"

    [<HttpPost>]
    member this.Post([<FromBody>] value: string) =
        ()

    [<HttpPut("{id}")>]
    member this.Put(id: int, [<FromBody>] value: string) =
        ()

    [<HttpDelete("{id}")>]
    member this.Delete(id: int) =
        ()
