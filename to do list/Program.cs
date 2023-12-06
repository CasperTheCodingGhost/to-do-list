//Lag en todo app! Du skal kunne legge til oppgaver, slette dem og gå inn på en task for å se beskrivelse eller flere detaljer

using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        TodoApp todoApp = new TodoApp();
        todoApp.Run();
    }
}