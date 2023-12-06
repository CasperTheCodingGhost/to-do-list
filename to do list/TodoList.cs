class TodoList
{
    private List<TodoItem> todoItems = new List<TodoItem>();

    public void LeggTilOppgave()
    {
        Console.Clear();
        Console.WriteLine("Legg til oppgave:");
        string beskrivelse = Console.ReadLine();
        Console.WriteLine("Legg til Beskrivelse:");
        string oppgaveBeskrivelse = Console.ReadLine();

        TodoItem todoItem = new TodoItem(beskrivelse, oppgaveBeskrivelse);
        todoItems.Add(todoItem);

        Console.WriteLine("Oppgave lagt til. Trykk Enter for å fortsette.");
        Console.ReadLine();
    }

    public void VisOppgaver()
    {
        Console.Clear();
        Console.WriteLine("Oppgaver:");

        for (int i = 0; i < todoItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todoItems[i].Beskrivelse}");
        }

        Console.WriteLine("Velg oppgave for detaljer (tall) eller trykk Enter for å fortsette.");
        string choice = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(choice) && int.TryParse(choice, out int index) && index >= 1 && index <= todoItems.Count)
        {
            // Vis detaljer for valgt oppgave
            VisOppgaveDetaljer(index - 1);
        }
    }

    public void SlettOppgave()
    {
        Console.Clear();
        Console.WriteLine("Slett oppgave:");

        VisOppgaver();

        Console.WriteLine("Velg oppgave å slette (tall) eller trykk Enter for å avbryte.");
        string choice = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(choice) && int.TryParse(choice, out int index) && index >= 1 && index <= todoItems.Count)
        {
            // Slett valgt oppgave
            todoItems.RemoveAt(index - 1);
            Console.WriteLine("Oppgave slettet. Trykk Enter for å fortsette.");
            Console.ReadLine();
        }
    }

    public void VisOppgaveDetaljer(int index)
    {
        Console.Clear();
        Console.WriteLine($"Beskrivelse: {todoItems[index].OppgaveBeskrivelse}");
        Console.WriteLine($"Oppgavedetaljer for: {todoItems[index].Beskrivelse}");
        Console.WriteLine($"Opprettet: {todoItems[index].OpprettetDato}");
        Console.WriteLine("Trykk Enter for å gå tilbake.");
        Console.ReadLine();
    }
}