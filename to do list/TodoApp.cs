class TodoApp
{
    private TodoList todoList = new TodoList();

    public void Run()
    {

        bool continueApp = true;

        while (continueApp)
        {
            Console.Clear();
            Console.WriteLine("Todo App");
            Console.WriteLine("1. Legg til oppgave");
            Console.WriteLine("2. Vis oppgaver");
            Console.WriteLine("3. Slett oppgave");
            Console.WriteLine("4. Avslutt");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    todoList.LeggTilOppgave();
                    break;
                case "2":
                    todoList.VisOppgaver();
                    break;
                case "3":
                    todoList.SlettOppgave();
                    break;
                case "4":
                    continueApp = false;
                    break;
                default:
                    Console.WriteLine("Ugyldig valg. Prøv igjen.");
                    break;
            }
        }
    }
}