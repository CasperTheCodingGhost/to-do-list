class TodoItem
{
    public string OppgaveBeskrivelse { get; set; }
    public string Beskrivelse { get; set; }
    public DateTime OpprettetDato { get; }

    public TodoItem(string beskrivelse, string oppgaveBeskrivelse)
    {
        OppgaveBeskrivelse = oppgaveBeskrivelse;
        Beskrivelse = beskrivelse;
        OpprettetDato = DateTime.Now;
    }
}