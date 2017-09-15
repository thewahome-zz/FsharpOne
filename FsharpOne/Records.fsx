let person = ("Mark","Gray","Man United",22)
type Person = {
    firstName : string
    lastName : string
    team: string
    age: int
} 
let me = {
    firstName ="Charles"
    lastName="Wahome"
    team="None"
    age=24 
}

let {firstName = myFirstname}=me
let {lastName = mylastName}=me
let {team = myteam}=me
let {age = myage}=me

let myFullname = me.firstName + " " + me.lastName

let temp = {me with age = 30}

type Date ={ 
    day:int
    month:int
    year:int
}
type Persons ={
    firstName : string
    lastName : string
    team: string
    age: int
    dateOfBirth:Date
}
let persons = {
    firstName ="Charles"
    lastName="Wahome"
    team="None"
    age=24 
    dateOfBirth = {day=1;month=6;year=1992;}
}

let changeDateOfBirth persons birthdate =
    let updated = {persons with dateOfBirth = birthdate}
    printfn "%A" updated
    printfn "%A" persons
    updated

