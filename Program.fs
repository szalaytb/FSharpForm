// Learn more about F# at https://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

open System.Drawing

open System.Windows.Forms

let form = new Form(Text = "First F# form")
let button1 = new Button(Text = "Click me to close!", Dock = DockStyle.Top)
let button2 = new Button(Text = "This button does something", Dock = DockStyle.Top)
let label = new Label(Text = "This is a test application", Dock = DockStyle.Bottom)

button1.Click.Add(fun _ -> Application.Exit() |> ignore)

button2.Click.Add(fun _ -> 
// Generate random color and set it as background
let rnd = new Random()
let r, g, b = rnd.Next(256), rnd.Next(256), rnd.Next(256)
form.BackColor <- Color.FromArgb(r, g, b) )

//form.Controls.Add(button1)
//form.Controls.Add(button2)
//form.Controls.Add(label)
form.Controls.AddRange(new Control[]{button1,button2,label})
form.Show()

[<EntryPoint>]
Application.Run(form)
//let main argv =
//    printfn "%A" argv
//    0 // return an integer exit code
