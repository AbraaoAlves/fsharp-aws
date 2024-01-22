namespace App.Services

open FSharp.Data

module GetInfo = 

  [<Literal>]
  let sample = "https://api.freecodecamp.org/api/users/get-public-profile?username=abraaoalves"
  let apiUrl = "https://api.freecodecamp.org/api/users/get-public-profile?username="

  type Info = JsonProvider<sample>
  
  let getSocial  = 

    let result = Info.Load(apiUrl + "abraaoalves")
    
    let ab: Info.Abraaoalves = result.Entities.User.Abraaoalves;
    
    [|ab.Twitter; ab.GithubProfile; ab.Linkedin|] 

